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
    public partial class Histograma : Form
    {
        public List<Randoms> lista_resultados;
        public Intervalos intervalos;
        public int cant_numeros;
        public List<DatoHistograma> lista_datos;
        public Histograma(List<Randoms> _lista_resultados, Intervalos _intervalos, int n)
        {
            lista_resultados = _lista_resultados;
            intervalos = _intervalos;
            cant_numeros = n;
            InitializeComponent();
        }

        private void Histograma_Load(object sender, EventArgs e)
        {
            cargarFilas();
            cargarDatos();
            cargarTabla();
        }

        private void cargarTabla()
        {
            double fe = (double)cant_numeros / intervalos.intervalo;
            double fa = 0;
            foreach (var dato in lista_datos)
            {
                double mc = (dato.inicioIntervalo + dato.finIntervalo) / 2;
                double fr = (double)dato.fo / cant_numeros;
                fa += fr;
                var fila = new string[]
                {
                    Convert.ToString(dato.inicioIntervalo) + " - " + Convert.ToString(dato.finIntervalo),
                    Convert.ToString(mc),
                    Convert.ToString(fe),
                    Convert.ToString(dato.fo),
                    Convert.ToString(fr),
                    Convert.ToString(fa)
                };
                dgv_histograma.Rows.Add(fila);

            }
        }

        private void cargarDatos()
        {
            int acum = 0;
            
            for(int i= 0; i < lista_datos.Count-1; i++)
            {
                for(int j = 0; j < lista_resultados.Count; j++)
                {
                    if(lista_resultados[j].valorRND < lista_datos[i].finIntervalo)
                    {
                        acum += 1;
                        lista_resultados.RemoveAt(j);
                        j -= 1;
                    }
                }
                lista_datos[i].fo = acum;
                acum = 0;
            }
            lista_datos[lista_datos.Count-1].fo = lista_resultados.Count;
        }

        private void cargarFilas()
        {
            var lista_d = new List<DatoHistograma>();
            for (int i = 0; i < intervalos.intervalo; i++) {
                var ob1 = new DatoHistograma
                {
                    inicioIntervalo = (double)i / intervalos.intervalo,
                    finIntervalo = (double)(i + 1) / intervalos.intervalo,
                };
                lista_d.Add(ob1);
            } ;
            lista_datos = lista_d;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
