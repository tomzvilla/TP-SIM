using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_SIM.TP4
{
    public partial class tp4_window : Form
    {
        public bool bandera = true;
        public int num_iteraciones;
        public double costo_media;
        public double costo_desv;
        public double costo_noche;
        public double costo_muelle;
        public int fila_desde;
        public bool flag = false;
        public double N1;
        public double N2;
        public tp4_window()
        {
            InitializeComponent();
        }

        private double generarRNDNormalBM(Random generador)
        {
            if (flag == false)
            {
                var rnd1 = generador.NextDouble();
                var rnd2 = generador.NextDouble();

                this.N1 = ((Math.Sqrt(-2 * Math.Log(rnd1)) * Math.Cos(2 * Math.PI * rnd2)) * this.costo_desv) + this.costo_media;
                this.N2 = ((Math.Sqrt(-2 * Math.Log(rnd1)) * Math.Sin(2 * Math.PI * rnd2)) * this.costo_desv) + this.costo_media;
                flag = true;
                return N1;

            }
            else
            {
                flag = false;
                return N2;
            }


        }

        private void btn_cambiar_prob_Click(object sender, EventArgs e)
        {
            if (bandera)
            {
                prob_descarga.Visible = true;
                prob_llegada.Visible = true;
                boton_suma.Visible = true;
                bandera = false;
            }
            else
            {
                prob_descarga.Visible = false;
                prob_llegada.Visible = false;
                boton_suma.Visible = false;
                bandera = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sumaLleg = pl_1.Value + pl_0.Value + pl_2.Value + pl_3.Value + pl_4.Value + pl_5.Value;
            var sumaDesc = pd_1.Value + pd_2.Value + pd_3.Value + pd_4.Value + pd_5.Value;
            suma_prob.Text = Convert.ToString(sumaLleg);
            suma_prob_2.Text = Convert.ToString(sumaDesc);
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                num_iteraciones = (int)num_iteracion.Value;
                costo_media = (double)num_media.Value;
                costo_desv = (double)num_desv.Value;
                costo_noche = (double)num_noche.Value;
                costo_muelle = (double)num_muelle.Value;
                fila_desde = (int)num_fila_desde.Value;
                simular();
            }
        }

        private void simular()
        {
            var generador = new Random();
            var rnd_inicial1 = Convert.ToDouble(generador.NextDouble().ToString("0.00"));
            var rnd_inicial2 = Convert.ToDouble(generador.NextDouble().ToString("0.00"));

            var lista_filas = new List<VectorEstado>();

            var fila_anterior = new VectorEstado()
            {
                reloj = 1,
                RND1 = rnd_inicial1,
                llegada_barcos = obtenerLlegada(rnd_inicial1),
                RND2 = rnd_inicial2,
                barcos_descargados = obtenerDescarga(rnd_inicial2),
                barcos_sin_descargar = obtenerLlegada(rnd_inicial1),
                barcos_total = obtenerLlegada(rnd_inicial1),
                dias_muelle_vacio = obtenerLlegada(rnd_inicial1) == 0 ? 1 : 0,
                contador_barcos_retrasados = 0,
                costo_descarga = 0,
                costo_por_noche = obtenerLlegada(rnd_inicial1) * costo_noche,
                costo_muelle_libre = obtenerLlegada(rnd_inicial1) == 0 ? costo_muelle : 0,
                cant_promedio_barcos_semana = 0,
                porcentaje_dias_vacios = 0,
                porcentaje_ocupacion = 0
            };
            fila_anterior.costo_total = fila_anterior.costo_descarga + fila_anterior.costo_por_noche +fila_anterior.costo_muelle_libre;
            fila_anterior.costo_total_ac = fila_anterior.costo_total;
      
            for (int i=1; i < num_iteraciones; i++)
            {
                var rnd1 = Convert.ToDouble(generador.NextDouble().ToString("0.00"));
                var rnd2 = Convert.ToDouble(generador.NextDouble().ToString("0.00"));
                var fila_actual = new VectorEstado();
                fila_actual.reloj = i + 1;
                fila_actual.RND1 = rnd1;
                fila_actual.llegada_barcos = obtenerLlegada(rnd1);
                fila_actual.RND2 = rnd2;
                fila_actual.barcos_descargados = obtenerDescarga(rnd2);

                var calculo1 = fila_anterior.barcos_sin_descargar - fila_actual.barcos_descargados;
                fila_actual.barcos_sin_descargar = calculo1 > 0 ? calculo1 + fila_actual.llegada_barcos : fila_actual.llegada_barcos;

                fila_actual.barcos_total = fila_anterior.barcos_total + fila_actual.llegada_barcos;

                var calculoVacio = fila_actual.barcos_sin_descargar == 0 ? 1 : 0;

                fila_actual.dias_muelle_vacio = fila_anterior.dias_muelle_vacio + calculoVacio;

                var calculo2 = fila_anterior.llegada_barcos - fila_actual.barcos_descargados + fila_anterior.contador_barcos_retrasados;
                fila_actual.contador_barcos_retrasados += (calculo2) <0 ? 0 : calculo2;

                fila_actual.acumulador_barcos_retrasados = fila_anterior.acumulador_barcos_retrasados + fila_actual.contador_barcos_retrasados;

                fila_actual.costo_descarga = calculo1 > 0 ? calculo1 * generarRNDNormalBM(generador) : fila_anterior.barcos_sin_descargar * generarRNDNormalBM(generador);
                fila_actual.costo_por_noche = fila_actual.barcos_sin_descargar * costo_noche;
                fila_actual.costo_muelle_libre = fila_actual.barcos_sin_descargar == 0 ? costo_muelle : 0;
                fila_actual.costo_total = fila_actual.costo_descarga + fila_actual.costo_por_noche + fila_actual.costo_muelle_libre;
                fila_actual.costo_total_ac = fila_anterior.costo_total_ac + fila_actual.costo_total;
                fila_actual.costo_promedio_diario = (double)fila_actual.costo_total_ac / fila_actual.reloj;
                fila_actual.cant_promedio_barcos_semana = (fila_actual.reloj % 7 == 1) ? (double)fila_actual.barcos_total / (fila_actual.reloj / 7) : fila_anterior.cant_promedio_barcos_semana;
                fila_actual.porcentaje_dias_vacios = ((double)fila_actual.dias_muelle_vacio / fila_actual.reloj)*100;
                fila_actual.porcentaje_ocupacion = ((double)fila_actual.barcos_descargados / 5)*100;

                if(fila_actual.reloj >= fila_desde && fila_actual.reloj <= fila_desde+400 )
                    lista_filas.Add(fila_actual);
                if (i == num_iteraciones - 1)
                    lista_filas.Add(fila_actual);
                fila_anterior = fila_actual;
            }
            flag = false;

            cargarFilas(lista_filas);
        }

        private void cargarFilas(List<VectorEstado> lista_filas)
        {
            var form = new TablaMontecharli(lista_filas);
            form.Show();
        }

        private int obtenerLlegada(double rnd1)
        {
            var lista_valores = new List<double>() { (double)pl_0.Value, (double)pl_1.Value, (double)pl_2.Value,
                (double)pl_3.Value, (double)pl_4.Value, (double)pl_5.Value
            };
            double p_acum = 0;
            for (int i = 0; i < 6; i++)
            {
                p_acum += lista_valores[i];
                if (rnd1 < p_acum)
                {
                    return i;
                }
            }
            return 5;
        }

        private int obtenerDescarga(double rnd2)
        {
            var lista_valores = new List<double>() {(double)pd_1.Value, (double)pd_2.Value,
                (double)pd_3.Value, (double)pd_4.Value, (double)pd_5.Value
            };
            double p_acum = 0;
            for (int i = 0; i < 5; i++)
            {
                p_acum += lista_valores[i];
                if (rnd2 < p_acum)
                {
                    return i+1;
                }
            }
            return 5;
        }



        private bool validar()
        {
            if(!(num_fila_desde.Value <= (num_iteracion.Value - 400)))
            {
                MessageBox.Show("La fila de visualizacion debe ser menor a la cantidad de iteraciones - 400", "Alerta", MessageBoxButtons.OKCancel);
                return false;
            }
            var sumaLleg = pl_1.Value + pl_0.Value + pl_2.Value + pl_3.Value + pl_4.Value + pl_5.Value;
            var sumaDesc = pd_1.Value + pd_2.Value + pd_3.Value + pd_4.Value + pd_5.Value;
            if(sumaLleg != 1 || sumaDesc != 1)
            {
                MessageBox.Show("Las probabilidades acumuladas deben sumar 1", "Alerta", MessageBoxButtons.OKCancel);
                return false;
            }
            return true;
        }

        private void tp4_window_Load(object sender, EventArgs e)
        {

    }
    }
}
