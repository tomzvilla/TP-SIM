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
    public partial class TablaMontecharli : Form
    {
        public List<VectorEstado> lista_filas;
        public TablaMontecharli(List<VectorEstado> _lista_filas)
        {
            InitializeComponent();
            lista_filas = _lista_filas;
        }

        private void TablaMontecharli_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cargarDatos()
        {
            foreach (var vector in lista_filas) {

                var fila = new string[]

                {
                    Convert.ToString(vector.reloj),
                    Convert.ToString(vector.RND1),
                    Convert.ToString(vector.llegada_barcos),
                    Convert.ToString(vector.RND2),
                    Convert.ToString(vector.barcos_descargados),
                    Convert.ToString(vector.barcos_sin_descargar),
                    Convert.ToString(vector.barcos_total),
                    Convert.ToString(vector.dias_muelle_vacio),
                    Convert.ToString(vector.contador_barcos_retrasados),
                    Convert.ToString(vector.acumulador_barcos_retrasados),
                    "$ "+ vector.costo_descarga.ToString("0.00"),
                    "$ " + vector.costo_por_noche.ToString("0.00"),
                    "$ " + vector.costo_muelle_libre.ToString("0.00"),
                    "$ " + vector.costo_total.ToString("0.00"),
                    "$ " + vector.costo_total_ac.ToString("0.00"),
                    "$ " + vector.costo_promedio_diario.ToString("0.00"),
                    vector.cant_promedio_barcos_semana.ToString("0.00"),
                    vector.porcentaje_dias_vacios.ToString("0.00") +" %",
                    Convert.ToString(vector.porcentaje_ocupacion) +" %",

                };
                dgv_montecarlo.Rows.Add(fila);
            }
        }

        private void dgv_montecarlo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
