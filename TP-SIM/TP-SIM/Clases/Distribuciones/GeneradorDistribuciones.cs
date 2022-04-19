using System;
using System.Collections.Generic;
using System.Linq;

namespace TP_SIM.Clases.Distribuciones
{
    public class GeneradorDistribuciones
    {
        public string tipo { get; set; }
        public int numero { get; set; }
        public int intervalos { get; set; }
        public double a { get; set; }
        public double b { get; set; }
        public double m { get; set; }
        public double d { get; set; }

        public double N1 { get; set; }
        public double N2 { get; set; }
        public bool flag { get; set; }

        public GeneradorDistribuciones(string _tipo, int _num, int _intervalo, double _a, double _b, double _m, double _d)
        {
            tipo = _tipo;
            numero = _num;
            intervalos = _intervalo;
            a = _a;
            b = _b;
            m = _m;
            d = _d;
            flag = false;
        }



        public double generarRND(Random generador)
        {
            switch (this.tipo)
            {
                case "Uniforme":
                    var valor = generarRNDUniforme(generador);
                    return valor;
                case "Normal":
                    var valor1 = generarRNDNormal(generador);
                    return valor1;
                case "Exponencial":
                    var valor2 = generarRNDExponencial(generador);
                    return valor2;
                default:
                    var valor3 = generarRNDPoisson(generador);
                    return valor3;
            }
        }


        private double generarRNDExponencial(Random generador)
        {
            var rnd = generador.NextDouble();
            double valor = -(this.m) * Math.Log(1 - rnd);
            return valor;

        }

        private double generarRNDNormal(Random generador)
        {
            var lista = new List<double>();
            for(int i=0; i < 12; i++)
            {
                var rnd = generador.NextDouble();
                lista.Add(rnd);
            }

            double valor = ((lista.Sum()-6) * this.d) + this.m;
            return valor;

        }

        private double generarRNDNormalBM(Random generador)
        {
            if(flag == false)
            {
                var rnd1 = generador.NextDouble();
                var rnd2 = generador.NextDouble();

                this.N1 = ((Math.Sqrt(-2 * Math.Log(rnd1)) * Math.Cos(2 * Math.PI * rnd2)) * this.d) + this.m;
                this.N2 = ((Math.Sqrt(-2 * Math.Log(rnd1)) * Math.Sin(2 * Math.PI * rnd2)) * this.d) + this.m;
                flag = true;
                return N1;

            }
            else
            {
                flag = false;
                return N2;
            }


        }

        private double generarRNDPoisson(Random generador)
        {
            double P = 1;
            var X = -1;
            var A = Math.Exp(-this.m);
            do
            {
                var rnd = generador.NextDouble();
                P = P * rnd;
                X++;
            } while (P >= A);
            return X;
        }

        public double generarRNDUniforme(Random generador)
        {
            var rnd = generador.NextDouble();
            double valor = this.a + rnd * (this.b - this.a);
            return valor;
        }
    }


}
