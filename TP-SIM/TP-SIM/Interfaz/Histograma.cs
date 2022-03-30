using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TP_SIM.Clases;

namespace TP_SIM.Interfaz
{
    public partial class Histograma : Form
    {
        public List<Randoms> lista_resultados;
        public Intervalos intervalos;
        public int cant_numeros;
        public List<DatoHistograma> lista_datos;
        public Histograma(List<Randoms> _lista_resultados, Intervalos _intervalos, int n)
        {
            lista_resultados = _lista_resultados;
            intervalos = _intervalos;
            cant_numeros = n;
            InitializeComponent();
        }

        private void Histograma_Load(object sender, EventArgs e)
        {
            var media = cargarMedia();
            var varianza = cargarVarianza(media);
            cargarDesviacion(varianza);
            cargarFilas();
            cargarDatos();
            cargarTabla();
            cargarHistograma();
            cargarFrecuenciaEsperada();
        }

        private void cargarDesviacion(double varianza)
        {

            var ds = Math.Sqrt(varianza);
            txt_desviacion.Text = ds.ToString("0.00000000");
            
        }

        private void cargarFrecuenciaEsperada()
        {
            var dataPointSeries = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "SerieHistogramaEsperada",
                IsVisibleInLegend = false,
                Color = Color.Goldenrod,
                ChartType = SeriesChartType.Column,
                MarkerStyle = MarkerStyle.None,
                BorderWidth = 1,
                BorderColor = Color.Black,


            };


            Axis ax = ch_frecuenciaEsperada.ChartAreas[0].AxisX;
            ax.Interval = Math.Round((double)1 / intervalos.intervalo, 4);
            ax.IntervalOffset = 0;
            ax.Minimum = 0;
            ax.Maximum = 1;

            for (int i = 0; i < lista_datos.Count; i++)
            {
                dataPointSeries.Points.AddXY(lista_datos[i].inicioIntervalo, lista_datos[i].fe);
            };

            foreach (DataPoint dp in dataPointSeries.Points)
                dp.XValue += ax.Interval / 2;


            ch_frecuenciaEsperada.Series.Add(dataPointSeries);
            ch_frecuenciaEsperada.Series[1]["PointWidth"] = "1";
        }

        private void cargarHistograma()
        {
            var dataPointSeries = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "SerieHistograma",
                IsVisibleInLegend = false,
                Color = Color.DodgerBlue,
                ChartType = SeriesChartType.Column,
                MarkerStyle = MarkerStyle.None,
                BorderWidth = 1,
                BorderColor = Color.Black,
                

            };

            
            Axis ax = ch_histograma.ChartAreas[0].AxisX;
            ax.Interval = Math.Round((double)1 / intervalos.intervalo, 4);
            ax.IntervalOffset = 0;
            ax.Minimum = 0;
            ax.Maximum = 1;

            for (int i = 0; i < lista_datos.Count; i++)
            {
                dataPointSeries.Points.AddXY(lista_datos[i].inicioIntervalo, lista_datos[i].fo);
            };

            foreach (DataPoint dp in dataPointSeries.Points)
                dp.XValue += ax.Interval / 2;


            ch_histograma.Series.Add(dataPointSeries);
            ch_histograma.Series[1]["PointWidth"] = "1";

        }

        private double cargarVarianza(double media)
        {
            double suma = 0;
            for (var i = 0; i < lista_resultados.Count; i++)
            {
                suma += Math.Pow(lista_resultados[i].valorRND - media, 2);

            }

            double varianza = (double) suma / lista_resultados.Count;
            txt_varianza.Text = varianza.ToString("0.00000000");
            return varianza;
        }

        private double cargarMedia()
        {
            double acum = 0;
            for(var i = 0; i < lista_resultados.Count; i++)
            {
                acum += lista_resultados[i].valorRND;
            }

            var media = (double )acum / lista_resultados.Count;
            txt_media.Text = media.ToString("0.00000000");
            return media;
        }

        private void cargarTabla()
        {
            //double fe = Math.Round((double)cant_numeros / intervalos.intervalo,4);
            double fa = 0;
            foreach (var dato in lista_datos)
            {
                double mc = Math.Round((dato.inicioIntervalo + dato.finIntervalo) / 2,4);
                double fr = Math.Round((double)dato.fo / cant_numeros,4);
                fa += fr;
                var fila = new string[]
                {
                    dato.inicioIntervalo.ToString("0.0000") + " - " + dato.finIntervalo.ToString("0.0000"),
                    Convert.ToString(mc),
                    Convert.ToString(dato.fe),
                    Convert.ToString(dato.fo),
                    Convert.ToString(fr),
                    Convert.ToString(fa)
                };
                dgv_histograma.Rows.Add(fila);

            }
        }

        private void cargarDatos()
        {
            int acum = 0;
            
            for(int i= 0; i < lista_datos.Count-1; i++)
            {
                for(int j = 0; j < lista_resultados.Count; j++)
                {
                    if(lista_resultados[j].valorRND < lista_datos[i].finIntervalo)
                    {
                        acum += 1;
                        lista_resultados.RemoveAt(j);
                        j -= 1;
                    }
                }
                lista_datos[i].fo = acum;
                acum = 0;
            }
            lista_datos[lista_datos.Count-1].fo = lista_resultados.Count;
        }

        private void cargarFilas()
        {
            var lista_d = new List<DatoHistograma>();
            for (int i = 0; i < intervalos.intervalo; i++) {
                var ob1 = new DatoHistograma
                {
                    inicioIntervalo = (double)i / intervalos.intervalo,
                    finIntervalo = (double)(i + 1) / intervalos.intervalo,
                    fe = Math.Round((double)cant_numeros / intervalos.intervalo, 4),
            };


                lista_d.Add(ob1);
            } ;
            lista_datos = lista_d;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_varianza_Click(object sender, EventArgs e)
        {

        }

        private void btn_chi_cuadrado_Click(object sender, EventArgs e)
        {
            var form = new TestChi(lista_datos);
            form.Show();
        }
    }
}
