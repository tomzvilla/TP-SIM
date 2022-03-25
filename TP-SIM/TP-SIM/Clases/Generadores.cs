using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_SIM.Clases
{
    public class Generador
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public int seed { get; set; }
        public int a { get; set; }
        public int m { get; set; }
        public int c { get; set; }
        public int n { get; set; }

        public List<int> valoresIntermedios { get; set; }
        public List<int> valoresXsubI { get; set; }
        public List<Double> valoresRND { get; set; }

        public Generador()
        {

        }
        public Generador(int _seed, int k, int g, int _c, int _n)
        {
            a = 1 + (4 * k);
            m = (int)Math.Pow(2,g);
            c = _c;
            seed = _seed;
            n = _n;
        }

        public List<Randoms> generar_random()
        {
            var lista_resultados = new List<Randoms>(); 

            var x0 = seed;
            for(int i = 0; i < n; i++)
            {
                var tmp = (a * x0 + c);
                var xi = tmp % m; 

                x0 = xi;
                var RND = (double)xi / m;

                var datos = new Randoms()
                {
                    valorIntermedio = tmp,
                    valorXi = xi,
                    valorRND = RND,
                };

                lista_resultados.Add(datos);
            }
            return lista_resultados;


        }
    }

    
}
