using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TP_SIM.Clases.Distribuciones;

namespace TP_SIM.Interfaz
{
    public partial class tp3_window : Form
    {
        public int num;
        public int intervalos;
        public tp3_window()
        {
            InitializeComponent();
        }

        private void tp3_window_Load(object sender, EventArgs e)
        {
            cargarDistribuciones();
            cargarIntervalos();
        }

        private void cargarIntervalos()
        {
            var lista = new List<int>()
            {
                8,10,15,20
            };
            var conector = new BindingSource();
            conector.DataSource = lista;

            cmb_intervalo.DataSource = conector;

        }

        private void cargarDistribuciones()
        {
            var lista = new List<String>()
            {
                "Uniforme", "Normal", "Exponencial", "Poisson"
            };

            var conector = new BindingSource();
            conector.DataSource = lista;
            cmb_distribucion.DataSource = conector;

        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                num = Convert.ToInt32(cantidad.Value);
                intervalos = Convert.ToInt32(cmb_intervalo.SelectedItem);
                var genSeleccionado = new GeneradorDistribuciones(Convert.ToString(cmb_distribucion.SelectedItem), num, intervalos, (double)param_a.Value, (double)param_b.Value, (double)param_m.Value, (double)param_d.Value);
                generarNumeros(genSeleccionado);
            };
            
        }

        private void generarNumeros(GeneradorDistribuciones genSeleccionado)
        {
            var generador = new Random();

            var listaRND = new List<double>();
            for(int i = 0; i < genSeleccionado.numero; i++)
            {            
                var valorRND = genSeleccionado.generarRND(generador);
                listaRND.Add(valorRND);
            }

            var form = new TablaRNDistribucion(listaRND, genSeleccionado);
            form.ShowDialog();

        }



        private bool validar()
        {
            if (param_m.Value <= 0)
            {
                MessageBox.Show("La media no puede ser negativa", "Alerta", MessageBoxButtons.OK);
                return false;
            }
            if (param_a.Value < param_b.Value || cmb_distribucion.SelectedItem != "Uniforme")
            {
                return true;
            }
            else
            {
                MessageBox.Show("A debe ser menor que B", "Alerta", MessageBoxButtons.OK);
                return false;
            }

        }

        private void cmb_distribucion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_distribucion.SelectedItem == "Uniforme")
            {
                param_a.Enabled = true;
                param_b.Enabled = true;
                param_m.Enabled = false;
                param_d.Enabled = false;
            }
            else if (cmb_distribucion.SelectedItem == "Normal")
            {
                param_a.Enabled = false;
                param_b.Enabled = false;
                param_m.Enabled = true;
                param_d.Enabled = true;
            }
            else if (cmb_distribucion.SelectedItem == "Exponencial")
            {
                param_a.Enabled = false;
                param_b.Enabled = false;
                param_m.Enabled = true;
                param_d.Enabled = false;
            }
            else
            {
                param_a.Enabled = false;
                param_b.Enabled = false;
                param_m.Enabled = true;
                param_d.Enabled = false;
            }
        }
    }
}
