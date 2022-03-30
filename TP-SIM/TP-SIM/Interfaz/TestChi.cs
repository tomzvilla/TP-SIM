using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_SIM.Clases;

namespace TP_SIM.Interfaz
{
    public partial class TestChi : Form
    {
        public List<DatoHistograma> lista_datos { get; set; }
        public List<DatosChi> lista_chi_cuadrado { get; set; }
        public TestChi(List<DatoHistograma> _lista_datos)
        {
            lista_datos = _lista_datos;
            InitializeComponent();
        }

        private void TestChi_Load(object sender, EventArgs e)
        {
            cargarTestChi();
            if (validarGrados())
            {
                cargarTablaChi();

            }
        
            
        }

        private bool validarGrados()
        {
            if (lista_chi_cuadrado.Count < 2)
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
                19.6752
            };
            double chiAcumulado = Convert.ToDouble(dgv_chi_cuadrado.Rows[dgv_chi_cuadrado.RowCount - 1].Cells[4].Value);

            var grados = lista_chi_cuadrado.Count - 1;
            txt_chi_ac.Text = chi_tabulado[grados - 1].ToString();

            if(chiAcumulado <= chi_tabulado[grados - 1])
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
                if (lista_datos[i].fe >= 5)
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
