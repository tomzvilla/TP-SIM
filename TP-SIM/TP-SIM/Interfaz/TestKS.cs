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
using TP_SIM.Clases.Distribuciones;

namespace TP_SIM.Interfaz
{
    public partial class TestKS : Form
    {

        public List<DatoHistograma> lista_datos;
        public GeneradorDistribuciones gen;

        public TestKS(List<DatoHistograma> _lista_datos, GeneradorDistribuciones _gen)
        {
            lista_datos = _lista_datos;
            gen = _gen;
            InitializeComponent();
        }

        private void TestKS_Load(object sender, EventArgs e)
        {
            cargarTestKS();
        }

        private void cargarTestKS()
        {
            var muestra = gen.numero;
            double max = 0;
            double poac = 0;
            double peac = 0;

            foreach (var dato in lista_datos)
            {
                double po = (double)dato.fo / muestra;
                double pe = (double)dato.fe / muestra;
                poac += po;
                peac += pe;
                var c = Math.Abs(poac - peac);
                string csinNotacion = String.Format("{0:N30}", c);
                if (c > max)
                {
                    max = c;
                }

                var fila = new string[]
                {
                    dato.inicioIntervalo.ToString("0.0000") + " - " + dato.finIntervalo.ToString("0.0000"),
                    dato.fe.ToString("0.0000"),
                    dato.fo.ToString("0.0000"),
                    po.ToString("0.0000"),
                    pe.ToString("0.0000"),
                    poac.ToString("0.0000"),
                    peac.ToString("0.0000"),
                    csinNotacion

                };

                dgv_ks.Rows.Add(fila);
                txt_ks.Text = Convert.ToString(max);
            }
            

        }

        private void btn_hipotesis_Click(object sender, EventArgs e)
        {
            comprobarHipotesis();
        }

        private void comprobarHipotesis()
        {
            var ks_tabulados = new List<double>()
            {
                0.9750,
                0.8418,
                0.7076,
                0.6239,
                0.5632,
                0.5192,
                0.4834,
                0.4542,
                0.4300,
                0.4092,
                0.3912,
                0.3754,
                0.3614,
                0.3489,
                0.3375,
                0.3273,
                0.3179,
                0.3093,
                0.3014,
                0.2940,
                0.2872,
                0.2808,
                0.2749,
                0.2693,
                0.2640,
                0.2590,
                0.2543,
                0.2499,
                0.2457,
                0.2417,
                0.2378,
                0.2342,
                0.2307,
                0.2274,
                0.22425,
                0.22119,
                0.21826,
                0.21544,
                0.21273,
                0.21012,
                0.20760,
                0.20517,
                0.20283,
                0.20056,
                0.19837,
                0.19625,
                0.19420,
                0.19221,
                0.19028,
                0.18841

            };
            double ksCalculado = Convert.ToDouble(txt_ks.Text);

            double ksTabulado = 0;
            if (gen.numero > 50)
                ksTabulado = (double)1.36 / Math.Sqrt(gen.numero);
            else
                ksTabulado = ks_tabulados[gen.numero - 1];

            txt_ks_tab.Text = ksTabulado.ToString();

            if (ksCalculado <= ksTabulado)
            {
                MessageBox.Show("La hipotesis no se rechaza", "Información", MessageBoxButtons.OKCancel);
            }
            else
            {
                MessageBox.Show("La hipotesis se rechaza", "Información", MessageBoxButtons.OKCancel);
            }
        }
    }
}
