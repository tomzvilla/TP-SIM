using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TP_SIM.Clases;
using TP_SIM.Clases.Distribuciones;

namespace TP_SIM.Interfaz
{
    public partial class TestChi : Form
    {
        public List<DatoHistograma> lista_datos { get; set; }
        public List<DatosChi> lista_chi_cuadrado { get; set; }
        public GeneradorDistribuciones gen { get; set; }
        public int grados { get; set; }
        public TestChi(List<DatoHistograma> _lista_datos)
        {
            lista_datos = _lista_datos;
            InitializeComponent();
        }

        public TestChi(List<DatoHistograma> _lista_datos, GeneradorDistribuciones _gen)
        {
            lista_datos = _lista_datos;
            gen = _gen;
            InitializeComponent();
        }

        private void TestChi_Load(object sender, EventArgs e)
        {
            cargarTestChi();
            grados = calcularGradosLibertad(gen);
            if (validarGrados(grados))
            {
                cargarTablaChi();

            }
            else
            {
                this.Dispose();
            }


        }

        private int calcularGradosLibertad(GeneradorDistribuciones gen)
        {
            var k = lista_chi_cuadrado.Count;
            int m = 0;
            switch (gen.tipo)
            {
                case "Normal BM":
                    m = 2;
                    break;
                case "Normal Convolucional":
                    m = 2;
                    break;
                case "Uniforme":
                    m = 0;
                    break;
                default:
                    m = 1;
                    break;
            }

            var v = k - m - 1;
            return v;

        }

        private bool validarGrados(int grados)
        {
            if (grados < 2)
            {
                MessageBox.Show("El tamaño de la muestra es demasiado pequeño como para realizar " +
                    "la prueba de chi cuadrado, (v < 2)", "Alerta", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void comprobarHipotesis()
        {
            var chi_tabulado = new List<Double>()
            {
                3.8415,
                5.9915,
                7.8147,
                9.4877,
                11.0705,
                12.5916,
                14.0671,
                15.5073,
                16.9190,
                18.3070,
                19.6752,
                21.0261,
                22.3620,
                23.6848,
                24.9958,
                26.2962,
                27.5871,
                28.8693,
                30.1435,
                31.4104,
                32.6706,
                33.9245,
                35.1725,
                36.4150,
                37.6525,
                38.8851,
                40.1133,
                41.3378,
                42.5569,
                43.78
            };
            double chiAcumulado = Convert.ToDouble(dgv_chi_cuadrado.Rows[dgv_chi_cuadrado.RowCount - 1].Cells[4].Value);

            double chiTabulado = 0;
            if(grados <= 30)
                chiTabulado = chi_tabulado[grados - 1];
            else if (grados > 30 && grados <= 35)
            {
                chiTabulado = 49.81;
            }
            else if (grados > 35 && grados <= 40)
                chiTabulado = 55.75;
            else if (grados > 40 && grados <= 45)
                chiTabulado = 61.65;
            else if (grados > 45 && grados <= 50)
                chiTabulado = 67.5;
            else if (grados > 50 && grados <= 60)
                chiTabulado = 79.08;
            else if (grados > 60 && grados <= 70)
                chiTabulado = 90.53;
            else if (grados > 70 && grados <= 80)
                chiTabulado = 101.88;
            else if (grados > 80 && grados <= 90)
                chiTabulado = 113.14;
            else
                chiTabulado = 124.34;

            txt_chi_ac.Text = chiTabulado.ToString();

            if (chiAcumulado <= chiTabulado)
            {
                MessageBox.Show("La hipotesis no se rechaza", "Información", MessageBoxButtons.OKCancel);
            }
            else
            {
                MessageBox.Show("La hipotesis se rechaza", "Información", MessageBoxButtons.OKCancel);
            }

        }

        private void cargarTablaChi()
        {
            double chiAcumulada = 0;

            foreach (var dato in lista_chi_cuadrado)
            {
                double chi = Math.Pow((dato.fo - dato.fe), 2) / dato.fe;
                chiAcumulada += chi;
                var fila = new string[]

                {
                    dato.inicioIntervalo.ToString("0.0000") + " - " + dato.finIntervalo.ToString("0.0000"),
                    Convert.ToString(dato.fe),
                    Convert.ToString(dato.fo),
                    chi.ToString("0.0000"),
                    chiAcumulada.ToString("0.0000")

                };
                dgv_chi_cuadrado.Rows.Add(fila);
                txt_chi.Text = Convert.ToString(dgv_chi_cuadrado.Rows[dgv_chi_cuadrado.RowCount - 1].Cells[4].Value);
            }
        }

        private void cargarTestChi()
        {
            var lista_chi = new List<DatosChi>();
            double sumaFe = 0;
            int sumaFo = 0;
            double inicio_inter = 0;
            bool first = true;

            for (var i = 0; i < lista_datos.Count; i++)
            {
                if (lista_datos[i].fe >= 5 && first == true)
                {
                    var obj = new DatosChi()
                    {
                        inicioIntervalo = lista_datos[i].inicioIntervalo,
                        finIntervalo = lista_datos[i].finIntervalo,
                        fe = lista_datos[i].fe,
                        fo = lista_datos[i].fo
                    };
                    lista_chi.Add(obj);

                }

                else
                {
                    if (first)
                    {
                        inicio_inter = lista_datos[i].inicioIntervalo;
                        first = false;
                    }
                    sumaFe += lista_datos[i].fe;
                    sumaFo += lista_datos[i].fo;

                    if (sumaFe >= 5)
                    {
                        var obj = new DatosChi()
                        {
                            inicioIntervalo = inicio_inter,
                            finIntervalo = lista_datos[i].finIntervalo,
                            fe = sumaFe,
                            fo = sumaFo
                        };
                        sumaFe = 0;
                        sumaFo = 0;
                        first = true;
                        lista_chi.Add(obj);
                    }

                    if ((i == lista_datos.Count - 1) && (sumaFe < 5))
                    {
                        var index = lista_chi.Count - 1;
                        lista_chi[index].finIntervalo = lista_datos[i].finIntervalo;
                        lista_chi[index].fo += sumaFo;
                        lista_chi[index].fe += sumaFe;

                    }

                }
            }
            lista_chi_cuadrado = lista_chi;
        }

        private void btn_hipotesis_Click(object sender, EventArgs e)
        {
            comprobarHipotesis();
        }
    }
}
