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
        public Intervalos intervalos;
        public int cant_numeros; 
        public TablaRandoms(Generador _gen, Intervalos _intervalos, int n)
        {
            gen = _gen;
            intervalos = _intervalos;
            cant_numeros = n;
            InitializeComponent();
        }

        private void Randoms_Load(object sender, EventArgs e)
        {
            if(gen.seed == 0)
                lista_resultados = gen.generar_random_c();
            else
                lista_resultados = gen.generar_random();
            cargarResultados();
        }

        private void cargarResultados()
        {
            int i = 0;
            foreach (var resultado in lista_resultados)
            {
                string RNDsinNotacion = String.Format("{0:N30}", resultado.valorRND);


                var fila = new string[]
                {
                    Convert.ToString(i),
                    Convert.ToString(resultado.valorIntermedio),
                    Convert.ToString(resultado.valorXi),
                    /*RNDsinNotacion.TrimEnd('0')*/
                    RNDsinNotacion,
                };
                dgv_random.Rows.Add(fila);
                i += 1;

            }

        }

        private void btn_histograma_Click(object sender, EventArgs e)
        {
            var form = new Histograma(lista_resultados, intervalos, cant_numeros);
            form.Show();
        }
    }
}
