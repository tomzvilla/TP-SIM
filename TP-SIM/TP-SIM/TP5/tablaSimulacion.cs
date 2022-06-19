using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_SIM.Clases.Distribuciones;
using TP_SIM.Runge_Kutta;
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

        public int columas_a_agregar_AC;
        public List<int> lista_ids;
        public decimal reloj_anterior;

        // atributos para ataques
        public decimal A;
        public Camion camion_a_suspender = new Camion();
        public bool ataque_llegada = false;
        public bool primer_ataque = false;
        public bool estaba_ocupado = false;
        public string pathFile;




        public tablaSimulacion(decimal _iteraciones, decimal _mecanicos, decimal _lavadores, decimal _filas_a_mostrar, decimal _fila_desde, decimal _exp_media_lavado, decimal _exp_media_mantenimiento, decimal _lambda_poisson)
        {
            InitializeComponent();
            iteraciones = _iteraciones;
            mecanicos = _mecanicos;
            lavadores = _lavadores;
            filas_a_mostrar = _filas_a_mostrar;
            fila_desde = _fila_desde;
            exp_media_lavado = _exp_media_lavado / 24;
            exp_media_mantenimiento = _exp_media_mantenimiento;
            lambda_poisson = _lambda_poisson;
            exp_llegada = 1 / _lambda_poisson;
            estados_posibles = new List<Estado>();
            eventos_posibles = new List<Evento>();


            columas_a_agregar_AC = 0;
            lista_ids = new List<int>();

        }

        private void tablaSimulacion_Load(object sender, EventArgs e)
        {
            borrarArchivos();
            cargarEstados();
            cargarEventos();
            agregarColumnasMecanicos();
            agregarColumnasLavado();
            agregarColumasMetricas();
            simular();
        }

        private void borrarArchivos()
        {
            this.pathFile = AppDomain.CurrentDomain.BaseDirectory + "excel";
            Directory.CreateDirectory(this.pathFile);
            DirectoryInfo di = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + "excel");
            FileInfo[] files = di.GetFiles();
            if(files.Length != 0)
            {
                foreach (FileInfo file in files)
                {
                    file.Delete();
                }
            }
        }

        private void agregarColumasMetricas()
        {
            dgv_colas.Columns.Add("tasa_entrada", "Tasa Entrada");
            dgv_colas.Columns.Add("tasa_salida", "Tasa Salida");
            dgv_colas.Columns.Add("t_prom_cola_m", "T Prom Cola Mantenimiento");
            dgv_colas.Columns.Add("t_prom_cola_l", "T Prom Cola Lavado");
            dgv_colas.Columns.Add("cant_prom_cam_cola_m", "Q. Camiones Prom Cola M");
            dgv_colas.Columns.Add("cant_prom_cam_cola_l", "Q. Camiones Prom Cola L");
            dgv_colas.Columns.Add("cant_camiones_atendidos_sin_espera", "Q. Camiones Atendidos Sin Esperar");
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
            var llegada_ataque= new Evento
            {
                id = 3,
                nombre = "Llegada Ataque"
            }; 
            var fin_ataque_llegada = new Evento
            {
                id = 4,
                nombre = "Fin Ataque Clientes"
            }; 
            var fin_ataque_servidor = new Evento
            {
                id = 5,
                nombre = "Fin Ataque Servidor"
            };

            this.eventos_posibles.Add(llegada);
            this.eventos_posibles.Add(fin_mantenimiento);
            this.eventos_posibles.Add(fin_lavado);
            this.eventos_posibles.Add(llegada_ataque);
            this.eventos_posibles.Add(fin_ataque_llegada);
            this.eventos_posibles.Add(fin_ataque_servidor);
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
            var destruccion = new Estado()
            {
                id = 6,
                nombre = "/////////"
            };
            var SA = new Estado()
            {
                id = 7,
                nombre = "Siendo Atacado"
            };
            var MS = new Estado()
            {
                id = 8,
                nombre = "Mantenimiento Suspendido"
            };

            this.estados_posibles.Add(EM);
            this.estados_posibles.Add(SM);
            this.estados_posibles.Add(EL);
            this.estados_posibles.Add(SL);
            this.estados_posibles.Add(L);
            this.estados_posibles.Add(O);
            this.estados_posibles.Add(destruccion);
            this.estados_posibles.Add(SA);
            this.estados_posibles.Add(MS);
        }

        private void simular()
        {

            int cant_camiones_actual = 0;

            // Contadores y acumuladores para metricas

            int cant_camiones_entran = 0;
            int cant_camiones_salen = 0;
            int cant_camiones_atendidos_directo = 0;

            decimal acum_permanencia_mantenimiento = 0;
            decimal acum_permanencia_lavado = 0;

            int cant_camiones_mantenidos = 0;
            int cant_camiones_lavados = 0;

            decimal diferencia_horaria = 0;


            // Contador para ID de camiones

            int contador_id = 1;
            // Se instancian los generadores
            var genLlegada = new Random();
            var genMantenimiento = new Random();
            var genLavado = new Random();
            var genBeta = new Random();

            var genAtaque = new Random();

            // Se crea la fila inicial

            var fila_anterior = new VectorEstado();
            fila_anterior.reloj = 0;
            fila_anterior.evento = new Evento() { nombre = "Inicial" };
            fila_anterior.servidor_mantenimiento = crearServidores((int)mecanicos,0);
            fila_anterior.servidor_lavado = crearServidores((int)lavadores,1);
            fila_anterior.t_fin_mantenimiento = new List<decimal>(new decimal[(int)mecanicos]);
            fila_anterior.t_fin_lavado = new List<decimal>(new decimal[(int)lavadores]);
            fila_anterior.cola_lavado = new List<Camion>();
            fila_anterior.cola_mantenimiento = new List<Camion>();
            fila_anterior.cola_llegada = new List<Camion>();
            fila_anterior.camiones = new List<Camion>();
            fila_anterior.ataque = "--";
            fila_anterior.porc_ocupacion_lavador = new List<decimal>(new decimal[(int)lavadores]);
            fila_anterior.porc_ocupacion_mecanico = new List<decimal>(new decimal[(int)mecanicos]);
            var resultados = generarRNDExponencial(genLlegada, (double)this.exp_llegada);
            fila_anterior.rnd1 = resultados[0];
            fila_anterior.t_llegada = (decimal)resultados[1];
            fila_anterior.t_prox_llegada = fila_anterior.reloj + fila_anterior.t_llegada;
            cant_camiones_actual = imprimirFila(fila_anterior, cant_camiones_actual);
            fila_anterior.t_prox_ataque = 0;
            fila_anterior.t_fin_ataque_cliente = 0;
            fila_anterior.t_fin_ataque_servidor = 0;


            // Se crea las siguientes filas
            var fila_actual = new VectorEstado();

            for (int i = 0; i < this.iteraciones; i++)
            {
                reloj_anterior = fila_anterior.reloj;

                //var fila_actual = new VectorEstado();

                // Se calcula segun la fila anterior, el proximo evento (el mas cercano)

                var prox_reloj = calcularProximoReloj(fila_anterior.t_fin_mantenimiento, fila_anterior.t_fin_lavado, fila_anterior.t_prox_llegada, fila_anterior.t_prox_ataque, fila_anterior.t_fin_ataque_cliente, fila_anterior.t_fin_ataque_servidor);
                fila_actual.reloj = prox_reloj[0];
                fila_actual.evento = eventos_posibles[(int)prox_reloj[1]];
                diferencia_horaria = fila_actual.reloj - reloj_anterior;

                // Se arrastran los valores anteriores para modificarlos

                fila_actual.servidor_mantenimiento = fila_anterior.servidor_mantenimiento;
                fila_actual.servidor_lavado = fila_anterior.servidor_lavado;
                fila_actual.camiones = fila_anterior.camiones;
                fila_actual.cola_mantenimiento = fila_anterior.cola_mantenimiento;
                fila_actual.cola_lavado = fila_anterior.cola_lavado;
                fila_actual.cola_llegada = fila_anterior.cola_llegada;
                fila_actual.t_fin_mantenimiento = fila_anterior.t_fin_mantenimiento;
                fila_actual.t_fin_lavado = fila_anterior.t_fin_lavado;
                fila_actual.porc_ocupacion_lavador = fila_anterior.porc_ocupacion_lavador;
                fila_actual.porc_ocupacion_mecanico = fila_anterior.porc_ocupacion_mecanico;
                fila_actual.t_prox_ataque = fila_anterior.t_prox_ataque;
                fila_actual.t_fin_ataque_cliente = fila_anterior.t_fin_ataque_cliente;
                fila_actual.t_fin_ataque_servidor = fila_anterior.t_fin_ataque_servidor;
                fila_actual.t_remanente_mantenimiento = fila_anterior.t_remanente_mantenimiento;

                // Si el evento es una llegada, se calcula la proxima. Caso contrario, arrastra el valor anterior

                if (fila_actual.evento.id == 0)
                {
                    // Se crea el camion que llega
                    var camion = new Camion
                    {
                        id = contador_id,
                        servidor_atencion = null
                    };
                    contador_id += 1;

                    // Se calcula la proxima llegada
                    var proxLlegada = generarRNDExponencial(genLlegada, (double)this.exp_llegada);
                    fila_actual.rnd1 = proxLlegada[0];
                    fila_actual.t_llegada = (decimal)proxLlegada[1];
                    fila_actual.t_prox_llegada = fila_actual.reloj + fila_actual.t_llegada;

                    if (ataque_llegada)
                    {
                        fila_actual.cola_llegada.Add(camion);
                    }
                    else
                    {
                        
                        fila_actual.camiones.Add(camion);

                        // Se calculan metricas

                        cant_camiones_entran++;

                        // El camion chequea si hay servidores libres, si el id es distinto de 0, hay uno libre
                        int servidorEstaLibre = servidorLibre(fila_anterior.servidor_mantenimiento);
                        if (servidorEstaLibre != 0)
                        {
                            cant_camiones_atendidos_directo++;
                            // Se cambia el estado del camion a SM, y el estado del servidor a ocupado
                            // Se asigna el servidor al camion
                            camion.estado = estados_posibles[1];
                            camion.servidor_atencion = fila_actual.servidor_mantenimiento[servidorEstaLibre - 1];

                            fila_actual.servidor_mantenimiento[servidorEstaLibre - 1].estado = estados_posibles[5];
                            fila_actual.servidor_mantenimiento[servidorEstaLibre - 1].inicioTiempoCupacion = fila_actual.reloj;
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
                            camion.estado = estados_posibles[0];
                            camion.diaEntradaMantenimiento = fila_actual.reloj;
                        }

                        // ATAQUES - TP6

                        if (cant_camiones_entran == 80 && primer_ataque == false)
                        {
                            this.A = fila_actual.reloj;
                            this.primer_ataque = true;
                            fila_actual.t_prox_ataque = fila_actual.reloj + calcularAtaque(genBeta, this.A, (double)fila_actual.reloj);

                        }
                    }
                
                }
                else if (fila_actual.evento.id == 1)
                {
                    // Se suma 1 a camiones matenidos

                    cant_camiones_mantenidos++;
                    var idServidorFinMantenimiento = 1;

                    // Si el evento no es una llegada, arrasta la anterior para calcular.
                    fila_actual.t_prox_llegada = fila_anterior.t_prox_llegada;

                    if (mecanicos > 1)
                        idServidorFinMantenimiento = obtenerServidorFinAtencion(fila_actual.reloj, fila_anterior.t_fin_mantenimiento);

                    fila_actual.t_fin_mantenimiento[idServidorFinMantenimiento - 1] = 0;

                    // Se acumula el camiona atendido pro el servidor

                    fila_actual.servidor_mantenimiento[idServidorFinMantenimiento - 1].contadorAtendidos++;

                    Camion camion_a_lavar = obtenerCamion(fila_actual.camiones, idServidorFinMantenimiento, 0);
                    camion_a_lavar.servidor_atencion = null;

                    if (fila_actual.cola_mantenimiento.Count != 0)
                    {
                        Camion camion_a_mantener = fila_actual.cola_mantenimiento[0];
                        // Se procesa el proximo camion
                        // Se cambia el estado del camion a SM, y el estado del servidor sigue ocupado
                        // Se asigna el servidor al camion
                        camion_a_mantener.estado = estados_posibles[1];
                        camion_a_mantener.servidor_atencion = fila_actual.servidor_mantenimiento[idServidorFinMantenimiento - 1];

                        // Se calculan Metricas

                        acum_permanencia_mantenimiento += fila_actual.reloj - camion_a_mantener.diaEntradaMantenimiento;

                        // Se calcula el tiempo de mantenimiento, y el proximo fin de mantenimiento (hay un tiempo por cada servidor)

                        var finMantenimiento = generarRNDExponencial(genMantenimiento, (double)this.exp_media_mantenimiento);
                        fila_actual.rnd2 = (decimal)finMantenimiento[0];
                        fila_actual.t_mantenimiento = (decimal)finMantenimiento[1];
                        fila_actual.t_fin_mantenimiento[idServidorFinMantenimiento - 1] = fila_actual.reloj + fila_actual.t_mantenimiento;
                        fila_actual.cola_mantenimiento.RemoveAt(0);

                        
                    }
                    else
                    {
                        fila_actual.servidor_mantenimiento[idServidorFinMantenimiento - 1].estado = estados_posibles[4];
                        

                    }
                    
                    int servidorEstaLibre = servidorLibre(fila_anterior.servidor_lavado);
                    if (servidorEstaLibre != 0)
                    {
                        // Se cambia el estado del camion a SL, y el estado del servidor a ocupado
                        // Se asigna el servidor al camion
                        camion_a_lavar.estado = estados_posibles[3];
                        camion_a_lavar.servidor_atencion = fila_actual.servidor_lavado[servidorEstaLibre - 1];
                        fila_actual.servidor_lavado[servidorEstaLibre - 1].estado = estados_posibles[5];
                        fila_actual.servidor_lavado[servidorEstaLibre - 1].inicioTiempoCupacion = fila_actual.reloj;
                        // Se calcula el tiempo de lavado, y el proximo fin de lavado (hay un tiempo por cada servidor)

                        var finLavado = generarRNDExponencial(genLavado, (double)this.exp_media_lavado);
                        fila_actual.rnd3 = (decimal)finLavado[0];
                        fila_actual.t_lavado = (decimal)finLavado[1];
                        fila_actual.t_fin_lavado[servidorEstaLibre - 1] = fila_actual.reloj + fila_actual.t_lavado;
                    }
                    else
                    {
                        // Si no hay servidores libres, los añade a la cola
                        fila_actual.cola_lavado.Add(camion_a_lavar);
                        camion_a_lavar.estado = estados_posibles[2];
                        camion_a_lavar.servidor_atencion = null;
                        camion_a_lavar.diaEntradaLavado = fila_actual.reloj;


                    }

                }
                else if (fila_actual.evento.id == 2)
                {
                    // Se suma 1 a cantidad de camiones lavados

                    cant_camiones_lavados++;
                    var idServidorFinLavado = 1;
                    // Si el evento no es una llegada, arrasta la anterior para calcular.
                    fila_actual.t_prox_llegada = fila_anterior.t_prox_llegada;
                    if(lavadores > 1)
                        idServidorFinLavado = obtenerServidorFinAtencion(fila_actual.reloj, fila_anterior.t_fin_lavado);
                    
                    var camion_a_destruir = obtenerCamion(fila_actual.camiones, idServidorFinLavado, 1);
                    fila_actual.servidor_lavado[idServidorFinLavado - 1].contadorAtendidos++;

                    cant_camiones_salen++;

                    for(int j=0; j< fila_actual.camiones.Count; j++) { 
                        if(fila_actual.camiones[j].id == camion_a_destruir.id)
                        {
                            fila_actual.camiones[j].estado = estados_posibles[6];
                            fila_actual.camiones[j].servidor_atencion = null;
                        }
                    }
                    
                    fila_actual.t_fin_lavado[idServidorFinLavado - 1] = 0;

                    if (fila_actual.cola_lavado.Count != 0)
                    {
                        Camion camion_a_lavar = fila_actual.cola_lavado[0];
                        // Se procesa el proximo camion
                        // Se cambia el estado del camion a SL, y el estado del servidor sigue ocupado
                        // Se asigna el servidor al camion
                        camion_a_lavar.estado = estados_posibles[3];
                        camion_a_lavar.servidor_atencion = fila_actual.servidor_lavado[idServidorFinLavado - 1];

                        // Se calculan metricas

                        acum_permanencia_lavado += fila_actual.reloj - camion_a_lavar.diaEntradaLavado;

                        // Se calcula el tiempo de lavado, y el proximo fin de lavado (hay un tiempo por cada servidor)

                        var finLavado = generarRNDExponencial(genLavado, (double)this.exp_media_lavado);
                        fila_actual.rnd3 = (decimal)finLavado[0];
                        fila_actual.t_lavado = (decimal)finLavado[1];
                        fila_actual.t_fin_lavado[idServidorFinLavado - 1] = fila_actual.reloj + fila_actual.t_lavado;
                        fila_actual.cola_lavado.RemoveAt(0);

                    }
                    else
                    {
                        fila_actual.servidor_lavado[idServidorFinLavado - 1].estado = estados_posibles[4];
                        
                    }

                    

                }
                else if(fila_actual.evento.id == 3)
                {
                    fila_actual.t_prox_ataque = 0;
                    fila_actual.rnd4 = genAtaque.NextDouble();
                    fila_actual.ataque = fila_actual.rnd4 < 0.7 ? "Clientes" : "Servidor";
                    if (fila_actual.ataque == "Clientes")
                    {
                        fila_actual.t_fin_ataque_cliente = calcularTiempoAtaqueLlegada(fila_actual.reloj, 0) + fila_actual.reloj;
                        this.ataque_llegada = true;

                        // Se pausan las llegadas, en fin ataque cliente se reanudan

                        

                    }
                    else {
                        fila_actual.t_fin_ataque_servidor = calcularTiempoAtaqueServidor(fila_actual.reloj, 0) + fila_actual.reloj;
                        if(!(fila_actual.servidor_mantenimiento[0].estado == estados_posibles[4]))
                        {
                            this.estaba_ocupado = true;
                            fila_actual.t_remanente_mantenimiento = fila_actual.t_fin_mantenimiento[0] - fila_actual.reloj;
                            camion_a_suspender = obtenerCamion(fila_actual.camiones, 1, 0);
                            camion_a_suspender.estado = estados_posibles[8];
                            fila_actual.t_fin_mantenimiento[0] = 0;
                        }
                        else
                        {
                            fila_actual.t_remanente_mantenimiento = 0;
                        }
                        fila_actual.servidor_mantenimiento[0].estado = estados_posibles[7];
                        
                    }

                }
                else if(fila_actual.evento.id == 4)
                {
                    // Se calcula el proximo ataque
                    fila_actual.t_prox_ataque = fila_actual.reloj + calcularAtaque(genBeta, this.A, (double)fila_actual.reloj);
                    fila_actual.t_fin_ataque_cliente = 0;
                    fila_actual.rnd4 = 0;
                    fila_actual.ataque = "--";
                    // Se reanudan las llegadas
                    this.ataque_llegada = false;
                    // Pasar camiones a cola mantenimiento
                    cant_camiones_entran += fila_actual.cola_llegada.Count;
                    foreach(Camion camion in fila_actual.cola_llegada)
                    {
                        fila_actual.camiones.Add(camion);

                        // El camion chequea si hay servidores libres, si el id es distinto de 0, hay uno libre
                        int servidorEstaLibre = servidorLibre(fila_anterior.servidor_mantenimiento);
                        if (servidorEstaLibre != 0)
                        {
                            cant_camiones_atendidos_directo++;
                            // Se cambia el estado del camion a SM, y el estado del servidor a ocupado
                            // Se asigna el servidor al camion
                            camion.estado = estados_posibles[1];
                            camion.servidor_atencion = fila_actual.servidor_mantenimiento[servidorEstaLibre - 1];

                            fila_actual.servidor_mantenimiento[servidorEstaLibre - 1].estado = estados_posibles[5];
                            fila_actual.servidor_mantenimiento[servidorEstaLibre - 1].inicioTiempoCupacion = fila_actual.reloj;
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
                            camion.estado = estados_posibles[0];
                            camion.diaEntradaMantenimiento = fila_actual.reloj;
                        }
                    }
                    fila_actual.cola_llegada = new List<Camion>();
                }
                else if (fila_actual.evento.id == 5)
                {
                    // Se calcula el proximo ataque
                    fila_actual.t_prox_ataque = fila_actual.reloj + calcularAtaque(genBeta, this.A, (double)fila_actual.reloj);
                    fila_actual.t_fin_ataque_servidor = 0;
                    fila_actual.rnd4 = 0;
                    fila_actual.ataque = "--";
                    if (estaba_ocupado)
                    {
                        fila_actual.t_fin_mantenimiento[0] = fila_actual.reloj + fila_actual.t_remanente_mantenimiento;
                        camion_a_suspender.estado = estados_posibles[1];
                        fila_actual.servidor_mantenimiento[0].estado = estados_posibles[5];
                    }
                    else
                    {
                        if (fila_actual.cola_mantenimiento.Count != 0)
                        {
                            Camion camion_a_mantener = fila_actual.cola_mantenimiento[0];
                            // Se procesa el proximo camion
                            // Se cambia el estado del camion a SM, y el estado del servidor sigue ocupado
                            // Se asigna el servidor al camion
                            camion_a_mantener.estado = estados_posibles[1];
                            camion_a_mantener.servidor_atencion = fila_actual.servidor_mantenimiento[0];

                            // Se calculan Metricas

                            acum_permanencia_mantenimiento += fila_actual.reloj - camion_a_mantener.diaEntradaMantenimiento;

                            // Se calcula el tiempo de mantenimiento, y el proximo fin de mantenimiento (hay un tiempo por cada servidor)

                            var finMantenimiento = generarRNDExponencial(genMantenimiento, (double)this.exp_media_mantenimiento);
                            fila_actual.rnd2 = (decimal)finMantenimiento[0];
                            fila_actual.t_mantenimiento = (decimal)finMantenimiento[1];
                            fila_actual.t_fin_mantenimiento[0] = fila_actual.reloj + fila_actual.t_mantenimiento;
                            fila_actual.cola_mantenimiento.RemoveAt(0);

                        }
                        else
                        {
                            fila_actual.servidor_mantenimiento[0].estado = estados_posibles[4];


                        }
                    }
                    fila_actual.t_remanente_mantenimiento = 0;


                }

                // Se acumula el tiempo ocupado

                for(int k = 0; k < fila_actual.servidor_mantenimiento.Count; k++)
                {
                    if(fila_anterior.servidor_mantenimiento[k].estado == estados_posibles[5])
                    {
                        var sumar = diferencia_horaria;
                        fila_actual.servidor_mantenimiento[k].tiempoOcupado += sumar;
                    }
                }

                for (int k = 0; k < fila_actual.servidor_lavado.Count; k++)
                {
                    if (fila_anterior.servidor_lavado[k].estado == estados_posibles[5])
                    {
                        var sumar = diferencia_horaria;
                        fila_actual.servidor_lavado[k].tiempoOcupado += sumar;
                    }
                }

                //Se calculan metricas
                var calculo_parcial = (double)cant_camiones_atendidos_directo / cant_camiones_entran;
                fila_actual.porc_camiones_atendidos_sin_esperar = (decimal)calculo_parcial * 100;

                fila_actual.tasa_entrada = cant_camiones_entran / fila_actual.reloj;
                fila_actual.tasa_salida = cant_camiones_salen / fila_actual.reloj;

                fila_actual.cantPromCamionesEnColaMantenimiento = acum_permanencia_mantenimiento / fila_actual.reloj;
                fila_actual.cantPromCamionesEnColaLavado = acum_permanencia_lavado / fila_actual.reloj;

                // Se calcula cant de camionesa atendidos por dia por servidor
                
                for (int k = 0; k < fila_actual.servidor_mantenimiento.Count; k++)
                {
                    fila_actual.servidor_mantenimiento[k].prom_atendidos_x_dia = fila_actual.servidor_mantenimiento[k].contadorAtendidos / fila_actual.reloj;
                }
                // Se calcula % de ocupacion por servidor
                for (int k = 0; k < fila_actual.porc_ocupacion_mecanico.Count; k++)
                {
                    fila_actual.porc_ocupacion_mecanico[k] = (fila_actual.servidor_mantenimiento[k].tiempoOcupado / fila_actual.reloj) * 100;
                }

                for (int k = 0; k < fila_actual.servidor_lavado.Count; k++)
                {
                    fila_actual.servidor_lavado[k].prom_atendidos_x_dia = fila_actual.servidor_lavado[k].contadorAtendidos / fila_actual.reloj;
                }
                // Se calcula % de ocupacion por servidor
                for (int k = 0; k < fila_actual.porc_ocupacion_lavador.Count; k++)
                {
                    fila_actual.porc_ocupacion_lavador[k] = (fila_actual.servidor_lavado[k].tiempoOcupado / fila_actual.reloj) * 100;
                }
             

                if (cant_camiones_mantenidos != 0)
                    fila_actual.tiempoPermanenciaColaMantenimiento = acum_permanencia_mantenimiento / cant_camiones_mantenidos;

                else
                    fila_actual.tiempoPermanenciaColaMantenimiento = 0;
                if (cant_camiones_lavados != 0)
                    fila_actual.tiempoPermanenciaColaLavado = acum_permanencia_lavado / cant_camiones_lavados;
                else
                    fila_actual.tiempoPermanenciaColaLavado = 0;

                //Se cambia el orden de las filas
                if ((i >= this.fila_desde - 1 && i < this.fila_desde + this.filas_a_mostrar - 1) || (i == this.iteraciones - 1 && this.iteraciones != this.fila_desde + this.filas_a_mostrar - 1))
                    cant_camiones_actual = imprimirFila(fila_actual, cant_camiones_actual);
                fila_anterior = fila_actual;


            }
        }

        private decimal calcularAtaque(Random genBeta, decimal A, double reloj)
        {
            var beta = generarRNDUniforme(genBeta);
            var rk_ataque = new rk_llegada_ataque(beta, (double)A, reloj,this.pathFile);
            //rk_ataque.Show();
            var proximo_ataque = rk_ataque.valorBuscado;
            return (decimal)proximo_ataque;

        }

        private decimal calcularTiempoAtaqueLlegada(decimal reloj, decimal t0) {
            var rk_tiempo_ataque_llegada = new rk_tiempo_ataque_llegada(reloj, t0, this.pathFile);
            //rk_tiempo_ataque_llegada.Show();
            var tiempo_ataque_llegada = rk_tiempo_ataque_llegada.valorBuscado;
            return (decimal)tiempo_ataque_llegada;
        }

        private decimal calcularTiempoAtaqueServidor(decimal reloj, decimal t0)
        {
            var rk_tiempo_ataque_servidor = new rk_tiempo_ataque_servidor(reloj, t0, this.pathFile);
            //rk_tiempo_ataque_servidor.Show();
            var tiempo_ataque_servidor = rk_tiempo_ataque_servidor.valorBuscado;
            return (decimal)tiempo_ataque_servidor;
        }

        private int imprimirFila(VectorEstado filaImprimir, int cant_camiones_actual)
        {
            int cant_columnas = 26 + filaImprimir.t_fin_mantenimiento.Count + filaImprimir.servidor_mantenimiento.Count * 3 + filaImprimir.t_fin_lavado.Count + filaImprimir.servidor_lavado.Count * 3 + filaImprimir.camiones.Count;
            var fila = new string[cant_columnas];
            int puntero = 14;

            fila[0] = filaImprimir.reloj.ToString("0.00");
            fila[1] = filaImprimir.evento.nombre;
            fila[2] = filaImprimir.rnd1.ToString("0.00");
            fila[3] = filaImprimir.t_llegada.ToString("0.00");
            fila[4] = filaImprimir.t_prox_llegada.ToString("0.00");
            fila[5] = filaImprimir.cola_llegada.Count.ToString();
            fila[6] = filaImprimir.t_prox_ataque.ToString("0.00");
            fila[7] = filaImprimir.rnd4.ToString("0.00");
            fila[8] = filaImprimir.ataque.ToString();
            fila[9] = filaImprimir.t_fin_ataque_cliente.ToString("0.00");
            fila[10] = filaImprimir.t_fin_ataque_servidor.ToString("0.00");
            fila[11] = filaImprimir.rnd2.ToString("0.00");
            fila[12] = filaImprimir.t_mantenimiento.ToString("0.00");
            fila[13] = filaImprimir.t_remanente_mantenimiento.ToString("0.00");
            int contador = 0;
            for (int i = 14; i <= filaImprimir.t_fin_mantenimiento.Count + 13; i++)
            {
                fila[i] = filaImprimir.t_fin_mantenimiento[contador].ToString("0.00");
                contador += 1;
            };
            puntero += filaImprimir.t_fin_mantenimiento.Count;
            contador = 0;
            fila[puntero] = filaImprimir.cola_mantenimiento.Count.ToString();
            puntero++;
            for (int i = puntero; i <= 3*(filaImprimir.servidor_mantenimiento.Count) + puntero-1; i+=3)
            {
                fila[i] = filaImprimir.servidor_mantenimiento[contador].estado.nombre;
                fila[i+1] = filaImprimir.porc_ocupacion_mecanico[contador].ToString("0.00");
                fila[i+2] = filaImprimir.servidor_mantenimiento[contador].prom_atendidos_x_dia.ToString("0.00") + " x dia";
                contador += 1;
            };
            puntero += filaImprimir.servidor_mantenimiento.Count * 3;
            contador = 0;
            fila[puntero] = filaImprimir.rnd3.ToString("0.00");
            puntero++;
            fila[puntero] = filaImprimir.t_lavado.ToString("0.00");
            puntero++;
            for (int i = puntero; i <= filaImprimir.t_fin_lavado.Count + puntero - 1; i++)
            {
                fila[i] = filaImprimir.t_fin_lavado[contador].ToString("0.00");
                contador += 1;
            };
            puntero += filaImprimir.t_fin_lavado.Count;
            contador = 0;
            fila[puntero] = filaImprimir.cola_lavado.Count.ToString();
            puntero++;
            for (int i = puntero; i <= 3*(filaImprimir.servidor_lavado.Count) + puntero - 1; i+=3)
            {
                fila[i] = filaImprimir.servidor_lavado[contador].estado.nombre;
                fila[i + 1] = filaImprimir.porc_ocupacion_lavador[contador].ToString("0.00");
                fila[i + 2] = filaImprimir.servidor_lavado[contador].prom_atendidos_x_dia.ToString("0.00") + " x dia";
                contador += 1;
            };
            contador = 0;
            puntero += filaImprimir.servidor_lavado.Count * 3;
            for (int i = puntero; i <= filaImprimir.camiones.Count + puntero - 1; i++)
            {
                fila[i] = filaImprimir.camiones[contador].estado.nombre;
                contador += 1;
            };
            contador = 0;
            fila[puntero] = filaImprimir.tasa_entrada.ToString("0.00")+ " por dia";
            puntero++;
            fila[puntero] = filaImprimir.tasa_salida.ToString("0.00") + " por dia";
            puntero++;
            fila[puntero] = filaImprimir.tiempoPermanenciaColaMantenimiento.ToString("0.00") + " dias";
            puntero++;
            fila[puntero] = filaImprimir.tiempoPermanenciaColaLavado.ToString("0.00") + " dias";
            puntero++;
            fila[puntero] = filaImprimir.cantPromCamionesEnColaMantenimiento.ToString("0.00") + " camiones";
            puntero++;
            fila[puntero] = filaImprimir.cantPromCamionesEnColaLavado.ToString("0.00") + " camiones";
            puntero++;
            fila[puntero] = filaImprimir.porc_camiones_atendidos_sin_esperar.ToString("0.00") + " %";
            puntero++;
            int columnas_a_agregar = filaImprimir.camiones.Count - cant_camiones_actual;
            for(int i = columnas_a_agregar; i > 0; i--)
            {
                if(filaImprimir.camiones[filaImprimir.camiones.Count - i].estado != estados_posibles[6])
                {
                    dgv_colas.Columns.Add($"Camion{filaImprimir.camiones[filaImprimir.camiones.Count - i].id}", $"Camion {filaImprimir.camiones[filaImprimir.camiones.Count - i].id}");
                    columas_a_agregar_AC++;
                    lista_ids.Add(filaImprimir.camiones[filaImprimir.camiones.Count - i].id);
                }
            }

            for(int i = puntero; i <= columas_a_agregar_AC + puntero - 1; i++)
            {
                fila[i] = filaImprimir.camiones[lista_ids[contador] - 1].estado.nombre;
                contador++;
            }
            dgv_colas.Rows.Add(fila);

            return filaImprimir.camiones.Count;


        }

        private Camion obtenerCamion(List<Camion> camiones, int idServidor, int tipo)
        {
            Camion camion = new Camion();
            for (int i = 0; i < camiones.Count; i++)
            {
                if (camiones[i].servidor_atencion != null && camiones[i].servidor_atencion.tipoServidor == tipo && camiones[i].servidor_atencion.id == idServidor)
                {
                    camion = camiones[i];
                }
            }
            return camion;
        }

        private int obtenerServidorFinAtencion(decimal reloj, List<decimal> t_fin_servidor)
        {
            int id = -1;
            for(int i=0; i < t_fin_servidor.Count; i++)
            {
                if(t_fin_servidor[i] == reloj)
                {
                    id = i;
                }
            }
            return id + 1;
        }

        private int servidorLibre(List<Servidor> servidores)
        {
           for(int i= 0; i < servidores.Count; i++)
            {
                if (servidores[i].estado.Equals(estados_posibles[4]))
                {
                    return i + 1;
                }
            }
            return 0;
        }

        private List<decimal> calcularProximoReloj(List<decimal> t_fin_mantenimiento, List<decimal> t_fin_lavado, decimal t_prox_llegada, decimal proximo_ataque, decimal fin_ataque_cliente, decimal fin_ataque_servidor)
        {
            var lista = new List<decimal>(); 
            decimal min_lavado = 1000000000000000000;
            decimal min_mantenimiento = 10000000000000000000;

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

            var diccionario = new Dictionary<int, decimal>();
            if(min_lavado != 0)
                diccionario.Add(2, min_lavado);
            if (min_mantenimiento != 0)
                diccionario.Add(1, min_mantenimiento);
            if (proximo_ataque != 0)
                diccionario.Add(3, proximo_ataque);
            if (fin_ataque_cliente != 0)
                diccionario.Add(4, fin_ataque_cliente);
            if (fin_ataque_servidor != 0)
                diccionario.Add(5, fin_ataque_servidor);
            if (t_prox_llegada != 0)
                diccionario.Add(0, t_prox_llegada);
            
            var sortedDict = from entry in diccionario orderby entry.Value ascending select entry;

            var resultado = sortedDict.ElementAt(0);
            lista.Add(resultado.Value);
            lista.Add(resultado.Key);
            return lista;

        }

        private List<Servidor> crearServidores(int num_servidor, int tipo)
        {
            var lista = new List<Servidor>();
            for(int i = 1; i <= num_servidor; i++)
            {
                var obj = new Servidor()
                {
                    id = i,
                    estado = estados_posibles[4],
                    tipoServidor = tipo,
                    tiempoOcupado = 0
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
                dgv_colas.Columns.Add($"e_lavador_ocupacion{i}", $"% T ocupacion de L{i}");
                dgv_colas.Columns.Add($"e_lavador_cant_atendios_dia{i}", $"Prom camiones lavados x dia x L{i}");
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
                dgv_colas.Columns.Add($"e_mecanico_ocupacion{i}", $"% T ocupacion de M{i}");
                dgv_colas.Columns.Add($"e_mecanico_ocupacion{i}", $"Prom camiones mantenidos x dia x M{i}");
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

        public double generarRNDUniforme(Random generador)
        {
            var rnd = generador.NextDouble();
            double valor = 0 + rnd * (1);
            return valor;
        }

        private void dgv_colas_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.FillWeight = 1;   
        }
    }
}
