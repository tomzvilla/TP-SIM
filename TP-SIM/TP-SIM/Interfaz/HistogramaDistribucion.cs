using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TP_SIM.Clases;
using System.Linq;
using TP_SIM.Clases.Distribuciones;

namespace TP_SIM.Interfaz
{
    public partial class HistogramaDistribucion : Form
    {
        public int intervalos;
        public int cant_numeros;
        public List<double> listaVariablesAleatorias;
        public List<DatoHistograma> lista_datos;
        GeneradorDistribuciones gen;

        public HistogramaDistribucion(List<double> _lista_resultados, GeneradorDistribuciones _gen)
        {
            listaVariablesAleatorias = _lista_resultados;
            intervalos = _gen.intervalos;
            cant_numeros = _gen.numero;
            gen = _gen;
            InitializeComponent();
        }

        private void Histograma_Load(object sender, EventArgs e)
        {
            if(gen.tipo == "Poisson")
            {
                btn_ks.Enabled = false;
            }
            cargarFilas(gen);
            cargarDatos(gen);
            cargarTabla(gen);
            cargarHistograma(gen);
            cargarFrecuenciaUniforme01();
        }


        private void cargarFrecuenciaUniforme01()
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
            if(gen.tipo != "Poisson")
            {
                ax.Interval = Math.Round(((double)lista_datos[0].finIntervalo - lista_datos[0].inicioIntervalo), 4);
                //ax.Interval = Math.Round((double)1 / intervalos, 4);
            }
            else
            {
                ax.Interval = 1;
                
            }
            ax.IntervalOffset = 0;
            ax.Minimum = Math.Round(lista_datos[0].inicioIntervalo, 4);
            ax.Maximum = Math.Round(lista_datos[lista_datos.Count - 1].finIntervalo, 4);
            //ax.Minimum = 0;
            //ax.Maximum = 1;

            for (int i = 0; i < lista_datos.Count; i++)
            {
                dataPointSeries.Points.AddXY(lista_datos[i].inicioIntervalo, lista_datos[i].fe);
            };

            foreach (DataPoint dp in dataPointSeries.Points)
                dp.XValue += Math.Round(ax.Interval / 2, 4);


            ch_frecuenciaEsperada.Series.Add(dataPointSeries);
            ch_frecuenciaEsperada.Series[1]["PointWidth"] = "1";
        }

        private void cargarHistograma(GeneradorDistribuciones gen)
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
            if (gen.tipo != "Poisson")
            {
                ax.Interval = Math.Round(((double)lista_datos[0].finIntervalo - lista_datos[0].inicioIntervalo),4);
                //ax.Interval = Math.Round((double)1 / intervalos, 4);
            }
            else
            {
                ax.Interval = 1;

            }
            ax.IntervalOffset = 0;
            ax.Minimum = Math.Round(lista_datos[0].inicioIntervalo,4);
            ax.Maximum = Math.Round(lista_datos[lista_datos.Count - 1].finIntervalo,4);
            //ax.Minimum = 0;
            //ax.Maximum = 1;

            for (int i = 0; i < lista_datos.Count; i++)
            {
                dataPointSeries.Points.AddXY(lista_datos[i].inicioIntervalo, lista_datos[i].fo);
            };

            foreach (DataPoint dp in dataPointSeries.Points)
                dp.XValue += Math.Round(ax.Interval / 2,4);


            ch_histograma.Series.Add(dataPointSeries);
            ch_histograma.Series[1]["PointWidth"] = "1";

        }


        private void cargarTabla(GeneradorDistribuciones gen)
        {
            double fa = 0;
            foreach (var dato in lista_datos)
            {
                string intervalo = "";
                string mc = "-";
                if (gen.tipo == "Poisson")
                {
                    intervalo = dato.finIntervalo.ToString("0.0000");
                }

                else
                {
                    intervalo = dato.inicioIntervalo.ToString("0.0000") + " - " + dato.finIntervalo.ToString("0.0000");
                    mc = Convert.ToString(Math.Round((dato.inicioIntervalo + dato.finIntervalo) / 2, 4));
                }


                double fr = Math.Round((double)dato.fo / cant_numeros, 4);
                fa += fr;
                var fila = new string[]
                {
                    intervalo,
                    mc,
                    dato.fe.ToString("0.0000"),
                    Convert.ToString(dato.fo),
                    Convert.ToString(fr),
                    Convert.ToString(fa)
                };
                dgv_histograma_distribucion.Rows.Add(fila);

            }
        }

        private void cargarDatos(GeneradorDistribuciones gen)
        {
            int acum = 0;
            if(gen.tipo != "Poisson")
            {
                for (int i = 0; i < lista_datos.Count - 1; i++)
                {
                    for (int j = 0; j < listaVariablesAleatorias.Count; j++)
                    {
                        if (listaVariablesAleatorias[j] < lista_datos[i].finIntervalo)
                        {
                            acum += 1;
                            listaVariablesAleatorias.RemoveAt(j);
                            j -= 1;
                        }
                    }
                    lista_datos[i].fo = acum;
                    acum = 0;
                }
                lista_datos[lista_datos.Count - 1].fo = listaVariablesAleatorias.Count;
            }
            else
            {
                for (int i = 0; i < lista_datos.Count - 1; i++)
                {
                    for (int j = 0; j < listaVariablesAleatorias.Count; j++)
                    {
                        if (listaVariablesAleatorias[j] == lista_datos[i].finIntervalo)
                        {
                            acum += 1;
                            listaVariablesAleatorias.RemoveAt(j);
                            j -= 1;
                        }
                    }
                    lista_datos[i].fo = acum;
                    acum = 0;
                }
                lista_datos[lista_datos.Count - 1].fo = listaVariablesAleatorias.Count;
            }


            
        }

        private void cargarFilas(GeneradorDistribuciones gen)
        {
            var lista_d = new List<DatoHistograma>();
            double max = 0;
            double min = 0;
            double step = 0;


            if(gen.tipo != "Uniforme")
            {
                max = listaVariablesAleatorias.Max();
                min = listaVariablesAleatorias.Min();

            }
            else
            {
                max = gen.b;
                min = gen.a;

            }
            step = (double)(max - min) / intervalos;
            double inicio = min;


            if (gen.tipo != "Poisson")
            {
                for (int i = 0; i < intervalos; i++)
                {
                    var ob1 = new DatoHistograma
                    {
                        inicioIntervalo = inicio,
                        finIntervalo = inicio + step,
                        fe = cargarFrecuenciaEsperada(gen, inicio, (inicio + step))

                    };
                    inicio += step;

                    lista_d.Add(ob1);
                };
            }
            else
            {
                for(var i = min; i <= max; i++)
                {
                    var ob1 = new DatoHistograma
                    {
                        inicioIntervalo = i,
                        finIntervalo = i,
                        fe = cargarFrecuenciaEsperada(gen, i, i)

                    };

                    lista_d.Add(ob1);
                }
            }

            lista_datos = lista_d;
        }

        private double cargarFrecuenciaEsperada(GeneradorDistribuciones gen, double inicioIntervalo, double finIntervalo)
        {
            switch (gen.tipo)
            {
                case "Uniforme":
                    var valor1 = (double)gen.numero/gen.intervalos;
                    return valor1;
                case "Poisson":
                    // FIN INTERVALO = INICIO INTERVALO == VALOR PORQUE ES POISSON
                    var valor = finIntervalo;
                    var factorial = factorialOf(valor);
                    var valor4 = (double)(Math.Pow(gen.m, finIntervalo) * Math.Exp(-gen.m)) / factorial;
                    return valor4 * gen.numero;
                case "Exponencial":
                    var lambda = (double)1 / gen.m;
                    var valor3 = (double)(1 - Math.Exp(-lambda * finIntervalo)) - (1 - Math.Exp(-lambda * inicioIntervalo));
                    return valor3 * gen.numero;
                default:
                    var intervalo = finIntervalo - inicioIntervalo;
                    var mc = (double)(finIntervalo + inicioIntervalo) / 2;

                    var valor2 = (double)intervalo * ((1 / (gen.d * (Math.Sqrt(2 * Math.PI)))) * Math.Exp(-0.5 * Math.Pow(((mc - gen.m) / gen.d), 2)));
                    return valor2 * gen.numero;

            }
        }

        private double factorialOf(double valor)
        {
            double factorial = 1;
            for(int i=1; i <= valor; i++)
            {
                factorial *= i;
            }
            string factorialSinNotacion = String.Format("{0:N30}", factorial);
            factorial = Convert.ToDouble(factorialSinNotacion);
            return factorial;

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_varianza_Click(object sender, EventArgs e)
        {

        }

        private void btn_chi_cuadrado_Click(object sender, EventArgs e)
        {
            var form = new TestChi(lista_datos, gen);
            form.Show();
        }

        private void btn_ks_Click(object sender, EventArgs e)
        {
            var form = new TestKS(lista_datos, gen);
            form.Show();
        }
    }
}
