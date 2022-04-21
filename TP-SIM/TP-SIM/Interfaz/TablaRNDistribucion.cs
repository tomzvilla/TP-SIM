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

namespace TP_SIM.Interfaz
{
    public partial class TablaRNDistribucion : Form {

        public List<double> listaRND;
        GeneradorDistribuciones gen;

        public TablaRNDistribucion(List<double> _listaRND, GeneradorDistribuciones _gen)
        {
            InitializeComponent();
            listaRND = _listaRND;
            gen = _gen;
        }

        private void TablaRNDistribucion_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cargarDatos()
        {
            int i = 0;
            foreach (var resultado in listaRND)
            {
                
                var fila = new string[]
                {
                    Convert.ToString(i),
                    Convert.ToString(resultado)
                };
                dgv_rnd_distribucion.Rows.Add(fila);
                i += 1;

            }
        }

        private void btn_histograma_Click(object sender, EventArgs e)
        {
            var form = new HistogramaDistribucion(listaRND, gen);
            this.Hide();
            form.ShowDialog();
        }
    }
}
