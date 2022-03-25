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
    public partial class TablaRandoms : Form
    {
        public Generador gen;
        public List<Randoms> lista_resultados;
        public TablaRandoms(Generador _gen)
        {
            gen = _gen;
            InitializeComponent();
        }

        private void Randoms_Load(object sender, EventArgs e)
        {
            lista_resultados = gen.generar_random();
            cargarResultados();
        }

        private void cargarResultados()
        {
            int i = 0;
            foreach (var resultado in lista_resultados)
            {
                
                var fila = new string[]
                {
                    Convert.ToString(i),
                    Convert.ToString(resultado.valorIntermedio),
                    Convert.ToString(resultado.valorXi),
                    Convert.ToString(resultado.valorRND)
                };
                dgv_random.Rows.Add(fila);
                i += 1;

            }

        }
    }
}
