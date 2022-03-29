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
using TP_SIM.Interfaz;

namespace TP_SIM
{
    public partial class tp1_window : Form
    {
        public tp1_window()
        {
            InitializeComponent();
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            var n = (int)qnt.Value;
            var x0 = (int)seed.Value;
            var k = (int)nud_k.Value;
            var g = (int)nud_g.Value;
            var c = (int)nud_c.Value;
            var intervalos = (Intervalos)cmb_intervalos.SelectedItem;
            if (validarParametros(x0, k, g, c, n)){
                var gen = new Generador(x0, k, g, c, n);
                var f = new TablaRandoms(gen,intervalos, n);
                f.Show();
                gen.generar_random();
            }

        }

        private bool validarParametros(int _seed, int k, int g, int _c, int _n)
        {
            int m = (int)Math.Pow(2, g);
            if (_c != 0)
            {
                if (!MCD(m, _c))
                {
                    MessageBox.Show("El parámetro M y C deben ser primos relativos. Ingrese nuevos valores", "Alerta", MessageBoxButtons.OK);
                    return false;
                }
            }

            if (!validarPrimo(_seed))
            {
                DialogResult var = MessageBox.Show("Se recomienda usar como semilla un numero primo. ¿Desea ingresar un nuevo valor?","Alerta",MessageBoxButtons.YesNo);
                if (var == DialogResult.Yes)
                    return false;
            }
            return true;
        }

        private bool MCD(int m, int c)
        {
            var a = Math.Max(m, c);
            var b = Math.Min(m, c);
            do
            {
                var tmp = b;
                b = a % b;
                a = tmp;
            } while (b != 0);

            if (a == 1)
                return true;
            else
                return false;

        }

        private bool validarPrimo(int seed)
        {
            if (seed <= 1)
                return false;
            if (seed == 2)
                return true;
            if (seed % 2 == 0)
                return false;
            var limite = (int) Math.Floor(Math.Sqrt(seed));

            for(int i = 3; i <= limite; i += 2)
            {
                if(seed % i == 0)
                {
                    return false;
                }
            }
            return true;

        }

        private void tp1_window_Load(object sender, EventArgs e)
        {
            cargarGeneradores();
            cargarIntervalos();

        }

        private void cargarIntervalos()
        {
            Intervalos int5 = new Intervalos
            {
                intervalo = 5,
                nombre = "5",
            };
            Intervalos int8 = new Intervalos
            {
                intervalo = 8,
                nombre = "8",
            };
            Intervalos int10 = new Intervalos
            {
                intervalo = 10,
                nombre = "10",
            };
            Intervalos int12 = new Intervalos
            {
                intervalo = 12,
                nombre = "12",
            };

            var dataSource = new List<Intervalos>();
            dataSource.Add(int5);
            dataSource.Add(int8);
            dataSource.Add(int10);
            dataSource.Add(int12);
            var conector = new BindingSource();
            conector.DataSource = dataSource;

            cmb_intervalos.DataSource = conector;
            cmb_intervalos.DisplayMember = "nombre";
            cmb_intervalos.ValueMember = "intervalo";
            cmb_intervalos.SelectedItem = int5;

        }

        private void cargarGeneradores()
        {
            var lineal = new Generador();
            lineal.id = 1;
            lineal.nombre = "Congruencial Lineal";
            var multiplicativo = new Generador();
            multiplicativo.id = 2;
            multiplicativo.nombre = "Congruencial Multiplicativo";


            var dataSource = new List<Generador>();
            dataSource.Add(lineal);
            dataSource.Add(multiplicativo);
            var conector = new BindingSource();
            conector.DataSource = dataSource;

            cmb_generador.DataSource = conector;
            cmb_generador.DisplayMember = "nombre";
            cmb_generador.ValueMember = "id";
            cmb_generador.SelectedItem = lineal;
        }



        private void cmb_generador_SelectedValueChanged(object sender, EventArgs e)
        {
            Generador gen = (Generador)cmb_generador.SelectedItem;
            if(gen.id == 2)
            {
                nud_c.Value = 0;
                nud_c.ReadOnly = true;
            }
            else
            {
                nud_c.ReadOnly = false;
            }
        }
    }
}
