using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_SIM.Clases.Distribuciones;
using TP_SIM.TP5.Clases;

namespace TP_SIM.TP5
{
    public partial class tablaSimulacion : Form
    {
        public decimal iteraciones;
        public decimal mecanicos;
        public decimal lavadores;
        public decimal filas_a_mostrar;
        public decimal fila_desde;
        public decimal exp_media_lavado;
        public decimal exp_media_mantenimiento;
        public decimal lambda_poisson;
        public decimal exp_llegada;
        public List<Estado> estados_posibles;
        public List<Evento> eventos_posibles;
        public tablaSimulacion(decimal _iteraciones, decimal _mecanicos, decimal _lavadores, decimal _filas_a_mostrar, decimal _fila_desde, decimal _exp_media_lavado, decimal _exp_media_mantenimiento, decimal _lambda_poisson)
        {
            InitializeComponent();
            iteraciones = _iteraciones;
            mecanicos = _mecanicos;
            lavadores = _lavadores;
            filas_a_mostrar = _filas_a_mostrar;
            fila_desde = _fila_desde;
            exp_media_lavado = _exp_media_lavado;
            exp_media_mantenimiento = _exp_media_mantenimiento;
            lambda_poisson = _lambda_poisson;
            exp_llegada = 1 / _lambda_poisson;
    }

        private void tablaSimulacion_Load(object sender, EventArgs e)
        {
            cargarEstados();
            cargarEventos();
            agregarColumnasMecanicos();
            agregarColumnasLavado();
            simular();
        }

        private void cargarEventos()
        {
            var llegada = new Evento
            {
                id = 0,
                nombre = "Llegada Camion"
            };
            var fin_mantenimiento = new Evento
            {
                id = 1,
                nombre = "Fin Mantenimiento"
            };
            var fin_lavado = new Evento
            {
                id = 2,
                nombre = "Fin Lavado"
            };

            this.eventos_posibles.Add(llegada);
            this.eventos_posibles.Add(fin_mantenimiento);
            this.eventos_posibles.Add(fin_lavado);
        }

        private void cargarEstados()
        {
            var EM = new Estado()
            {
                id = 0,
                nombre = "Esperando Mantenimiento"
            };
            var SM = new Estado()
            {
                id = 1,
                nombre = "Siendo Mantenido"
            };
            var EL = new Estado()
            {
                id = 2,
                nombre = "Esperando Lavado"
            };
            var SL = new Estado()
            {
                id = 3,
                nombre = "Siendo Lavado"
            };

            var L = new Estado()
            {
                id = 4,
                nombre = "Libre"
            };
            var O = new Estado()
            {
                id = 5,
                nombre = "Ocupado"
            };

            this.estados_posibles.Add(EM);
            this.estados_posibles.Add(SM);
            this.estados_posibles.Add(EL);
            this.estados_posibles.Add(SL);
            this.estados_posibles.Add(L);
            this.estados_posibles.Add(O);
        }

        private void simular()
        {
            // Contador para ID de camiones

            int contador_id = 1;
            // Se instancian los generadores
            var genLlegada = new Random();
            var genMantenimiento = new Random();
            var genLavado = new Random();

            // Se crea la fila inicial

            var fila_anterior = new VectorEstado();
            fila_anterior.reloj = 0;
            fila_anterior.evento = new Evento() { nombre = "Inicial" };
            fila_anterior.servidor_mantenimiento = crearServidores((int)mecanicos);
            fila_anterior.servidor_lavado = crearServidores((int)lavadores);
            fila_anterior.t_fin_mantenimiento = new List<decimal>(new decimal[(int)mecanicos]);
            fila_anterior.t_fin_lavado = new List<decimal>(new decimal[(int)lavadores]);
            fila_anterior.cola_lavado = new List<Camion>();
            fila_anterior.cola_mantenimiento = new List<Camion>();
            fila_anterior.camiones = new List<Camion>();
            var resultados = generarRNDExponencial(genLlegada, (double)this.exp_llegada);
            fila_anterior.rnd1 = resultados[0];
            fila_anterior.t_llegada = (decimal)resultados[1];
            fila_anterior.t_prox_llegada = fila_anterior.reloj + fila_anterior.t_llegada;


            // Se crea las siguientes filas

            for (int i = 0; i < this.iteraciones; i++)
            {
                var fila_actual = new VectorEstado();

                // Se calcula segun la fila anterior, el proximo evento (el mas cercano)

                var prox_reloj = calcularProximoReloj(fila_anterior.t_fin_mantenimiento, fila_anterior.t_fin_lavado, fila_anterior.t_prox_llegada);
                fila_actual.reloj = prox_reloj[0];
                fila_actual.evento = eventos_posibles[(int)prox_reloj[1]];

                // Se arrastran los valores anteriores para modificarlos

                fila_actual.servidor_mantenimiento = fila_anterior.servidor_mantenimiento;
                fila_actual.servidor_lavado = fila_anterior.servidor_lavado;
                fila_actual.camiones = fila_anterior.camiones;
                fila_actual.cola_mantenimiento = fila_anterior.cola_mantenimiento;
                fila_actual.cola_lavado = fila_anterior.cola_lavado;
                fila_actual.t_fin_mantenimiento = fila_anterior.t_fin_mantenimiento;
                fila_actual.t_fin_lavado = fila_anterior.t_fin_lavado;

                // Si el evento es una llegada, se calcula la proxima. Caso contrario, arrastra el valor anterior

                if (fila_actual.evento.id == 0)
                {
                    // Se crea el camion que llega
                    var camion = new Camion
                    {
                        id = contador_id,
                        diaEntradaSistema = fila_actual.reloj
                    };
                    contador_id += 1;
                    fila_actual.camiones.Add(camion);

                    // Se calcula la proxima llegada

                    var proxLlegada = generarRNDExponencial(genLlegada, (double)this.exp_llegada);
                    fila_actual.rnd1 = proxLlegada[0];
                    fila_actual.t_llegada = (decimal)proxLlegada[1];
                    fila_actual.t_prox_llegada = fila_actual.reloj + fila_actual.t_llegada;

                    // El camion chequea si hay servidores libres, si el id es distinto de 0, hay uno libre

                    int servidorEstaLibre = servidorLibre(fila_anterior.servidor_mantenimiento);
                    if (servidorEstaLibre != 0)
                    {
                        // Se cambia el estado del camion a SM, y el estado del servidor a ocupado
                        // Se asigna el servidor al camion
                        camion.estado = estados_posibles[1];
                        camion.servidor_atencion = fila_actual.servidor_mantenimiento[servidorEstaLibre];
                        fila_actual.servidor_mantenimiento[servidorEstaLibre].estado = estados_posibles[5];

                        // Se calcula el tiempo de mantenimiento, y el proximo fin de mantenimiento (hay un tiempo por cada servidor)

                        var finMantenimiento = generarRNDExponencial(genMantenimiento, (double)this.exp_media_mantenimiento);
                        fila_actual.rnd2 = (decimal)finMantenimiento[0];
                        fila_actual.t_mantenimiento = (decimal)finMantenimiento[1];
                        fila_actual.t_fin_mantenimiento[servidorEstaLibre - 1] = fila_actual.reloj + fila_actual.t_mantenimiento;
                    }
                    else
                    {
                        // Si no hay servidores libres, los añade a la cola
                        fila_actual.cola_mantenimiento.Add(camion);
                    }

                }
                else
                {
                    // Si el evento no es una llegada, arrasta la anterior para calcular.
                    fila_actual.t_prox_llegada = fila_anterior.t_prox_llegada;
                }

            }


        }

        private int servidorLibre(List<Servidor> servidores)
        {
           for(int i= 0; i < servidores.Count; i++)
            {
                if (servidores[i].estado.Equals(estados_posibles[4]))
                {
                    return i;
                }
            }
            return 0;
        }

        private List<decimal> calcularProximoReloj(List<decimal> t_fin_mantenimiento, List<decimal> t_fin_lavado, decimal t_prox_llegada)
        {
            var lista = new List<decimal>(); 
            decimal minimo = t_prox_llegada;
            int index = 0;
            decimal min_lavado = 100;
            decimal min_mantenimiento = 100;

            for(int i = 0; i < t_fin_mantenimiento.Count; i++)
            {
                if(t_fin_mantenimiento[i] != 0 && t_fin_mantenimiento[i] < min_mantenimiento)
                {
                    min_mantenimiento = t_fin_mantenimiento[i];
                }
            }

            for (int i = 0; i < t_fin_lavado.Count; i++)
            {
                if (t_fin_lavado[i] != 0 && t_fin_lavado[i] < min_lavado)
                {
                    min_lavado = t_fin_lavado[i];
                }
            }

            if (min_mantenimiento < minimo)
            {
                minimo = min_mantenimiento;
                index = 1;
            }
            if(min_lavado < minimo)
            {
                minimo = min_lavado;
                index = 2;
            }
            lista.Add(minimo);
            lista.Add(index);
            return lista;

        }

        private List<Servidor> crearServidores(int num_servidor)
        {
            var lista = new List<Servidor>();
            for(int i = 1; i <= num_servidor; i++)
            {
                var obj = new Servidor()
                {
                    id = i,
                    estado = estados_posibles[4],
                    tipoServidor = 0,
                    tiempoLibre = 0
                };
                lista.Add(obj);
            }
            return lista;
        }

        private void agregarColumnasLavado()
        {
            dgv_colas.Columns.Add("rnd3", "RND");
            dgv_colas.Columns.Add("tlavado", "T Lavado");
            for (int i = 1; i <= lavadores; i++)
            {
                dgv_colas.Columns.Add($"tfin_lavado{i}", $"T F Lavado {i}");
            }
            dgv_colas.Columns.Add("cola_lavado", "Cola Lavado");
            for (int i = 1; i <= lavadores; i++)
            {
                dgv_colas.Columns.Add($"e_lavador{i}", $"Estado L{i}");
            }
        }

        private void agregarColumnasMecanicos()
        {
            for (int i = 1; i <= mecanicos; i++)
            {
                dgv_colas.Columns.Add($"tfin_mantenimiento{i}", $"T F Mantenimiento {i}");
            }

            dgv_colas.Columns.Add("cola_mantenimiento", "Cola Mantenimiento");

            for (int i = 1; i <= mecanicos; i++)
            {
                dgv_colas.Columns.Add($"e_mecanico{i}", $"Estado M{i}");
            }
        }

        public List<double> generarRNDExponencial(Random generador, double m)
        {
            var lista_resultado = new List<double>();
            var rnd = generador.NextDouble();
            lista_resultado.Add(rnd);
            double valor = -(m) * Math.Log(1 - rnd);
            lista_resultado.Add(valor);
            return lista_resultado;

        }
    }
}
