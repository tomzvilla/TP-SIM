using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_SIM.Runge_Kutta
{
    public partial class rk_tiempo_ataque_llegada : Form
    {
        public double reloj;
        public double x0;
        public double y0;
        public double h;
        public double valorBuscado;
        public rk_tiempo_ataque_llegada(decimal reloj , decimal t0)
        {
            InitializeComponent();
            this.y0 = (double)reloj;
            this.x0 = (double)t0;
            this.reloj = (double)reloj;
            this.h = 0.01;
            calcularRK();
        }

        private void calcularRK()
        {

            txt_iteracion.Text = this.reloj.ToString("0.00");

            var fila_anterior = new fila_rk();
            fila_anterior.xi1 = this.x0;
            fila_anterior.yi1 = this.y0;

            imprimirFila(fila_anterior);

            var fila_actual = new fila_rk();
            do
            {
                fila_actual.x = fila_anterior.xi1;
                fila_actual.y = fila_anterior.yi1;
                fila_actual.dy_dx = -((fila_actual.y / (double)(0.8)) * Math.Pow(fila_actual.x, 2)) - fila_actual.y;

                fila_actual.a = fila_actual.x * (double)(this.h / 2);
                fila_actual.b = fila_actual.y + ((double)(this.h / 2) * fila_actual.dy_dx);
                fila_actual.K2 = -((fila_actual.b / (double)(0.8)) * Math.Pow(fila_actual.a, 2)) - fila_actual.b;

                fila_actual.c = fila_actual.x * (double)(this.h / 2);
                fila_actual.d = fila_actual.y + ((double)(this.h / 2) * fila_actual.K2);
                fila_actual.K3 = -((fila_actual.d / (double)(0.8)) * Math.Pow(fila_actual.c, 2)) - fila_actual.d;

                fila_actual.e = fila_actual.x + this.h;
                fila_actual.f = fila_actual.y + (this.h * fila_actual.K3);
                fila_actual.K4 = -((fila_actual.f / (double)(0.8)) * Math.Pow(fila_actual.e, 2)) - fila_actual.f;

                fila_actual.xi1 = fila_actual.x + this.h;
                fila_actual.yi1 = fila_actual.y + ((double)(this.h / 6) * (fila_actual.dy_dx + 2 * fila_actual.K2 + 2 * fila_actual.K3 + fila_actual.K4));

                imprimirFila(fila_actual);
                fila_anterior = fila_actual;
            } while (Math.Abs(fila_actual.y - fila_anterior.y) >= 1);
            var t = fila_anterior.x;
            this.valorBuscado = t * 5;
        }

        private void imprimirFila(fila_rk fila_imprimir)
        {
            var fila = new string[]

            {
                fila_imprimir.x.ToString(),
                fila_imprimir.y.ToString(),
                fila_imprimir.dy_dx.ToString(),
                fila_imprimir.K2.ToString(),
                fila_imprimir.K3.ToString(),
                fila_imprimir.K4.ToString(),
                fila_imprimir.xi1.ToString(),
                fila_imprimir.yi1.ToString(),

        };
            dgv_rk.Rows.Add(fila);
        }

        private void rk_tiempo_ataque_llegada_Load(object sender, EventArgs e)
        {

        }
    }

}
