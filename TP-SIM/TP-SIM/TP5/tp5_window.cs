using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_SIM.TP5
{
    public partial class tp5_window : Form
    {
        public bool bandera = true;
        public tp5_window()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bandera)
            {
                p_probabilidades.Visible = true;
                bandera = false;
            }
            else
            {
                p_probabilidades.Visible = false;
                bandera = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                simular();
            }
        }

        private void simular()
        {
            var form = new tablaSimulacion(this.num_iteraciones.Value, this.n_mecanicos.Value, this.n_lavadores.Value, this.filas_a_mostrar.Value, this.fila_desde.Value, this.exp_media_lavado.Value, this.exp_media_mantenimiento.Value, this.lambda_p.Value);
            form.ShowDialog();
        }

        private bool validar()
        {
            if(fila_desde.Value + filas_a_mostrar.Value <= num_iteraciones.Value)
            {
                return true;
            }
            else
            {
                MessageBox.Show("El numero de filas a mostrar tiene que ser menor a la cantidad de iteraciones", "Alerta", MessageBoxButtons.OK);
                return false;
            }
        }
    }
}
