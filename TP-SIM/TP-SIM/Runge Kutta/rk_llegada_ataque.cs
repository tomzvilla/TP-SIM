using SpreadsheetLight;
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
    public partial class rk_llegada_ataque : Form
    {
        SLDocument oSLDocument = new SLDocument();
        DataTable dt = new DataTable();
        public string pathFile;
        public string archivo;
        public double reloj;
        public double x0;
        public double y0;
        public double h;
        public double beta;
        public double valorBuscado;
        public rk_llegada_ataque(double _beta, double _y0, double _reloj, string _pathFile)
        {
            InitializeComponent();
            añadirColumnas();
            pathFile = _pathFile;
            this.beta = _beta;
            this.y0 = _y0;
            this.reloj = _reloj;
            archivo = pathFile + $"/excelProximaLllegada-" + reloj.ToString("0.00") + ".xlsx";
            this.h = 0.01;
            calcularRK();
        }

        private void añadirColumnas()
        {
            dt.Columns.Add("Valor X", typeof(string));
            dt.Columns.Add("Valor Y", typeof(decimal));
            dt.Columns.Add("dY/dX (K1)", typeof(decimal));
            dt.Columns.Add("K2", typeof(decimal));
            dt.Columns.Add("K3", typeof(decimal));
            dt.Columns.Add("K4", typeof(decimal));
            dt.Columns.Add("Xi+1", typeof(decimal));
            dt.Columns.Add("Yi+1", typeof(decimal));
            dt.Columns.Add("A inicial", typeof(decimal));
            dt.Columns.Add("Beta", typeof(decimal));
        }

        private void calcularRK()
        {

            txt_iteracion.Text = this.reloj.ToString("0.00");
            txt_a.Text = this.y0.ToString("0.00");
            txt_beta.Text = this.beta.ToString("0.00");

            var fila_anterior = new fila_rk();
            fila_anterior.xi1 = this.x0;
            fila_anterior.yi1 = this.y0;

            //imprimirFila(fila_anterior);

            dt.Rows.Add(fila_anterior.x.ToString(), fila_anterior.y, fila_anterior.dy_dx, fila_anterior.K2, fila_anterior.K3, fila_anterior.K4, fila_anterior.xi1, fila_anterior.yi1, this.y0, this.beta);


            var fila_actual = new fila_rk();
            while (fila_actual.y < (2*this.y0))
            {
                fila_actual.x = fila_anterior.xi1;
                fila_actual.y = fila_anterior.yi1;
                fila_actual.dy_dx = fila_actual.y * this.beta;

                fila_actual.a = fila_actual.x * (double)(this.h / 2);
                fila_actual.b = fila_actual.y + ((double)(this.h / 2) * fila_actual.dy_dx);
                fila_actual.K2 = fila_actual.b * this.beta;

                fila_actual.c = fila_actual.x * (double)(this.h / 2);
                fila_actual.d = fila_actual.y + ((double)(this.h / 2) * fila_actual.K2);
                fila_actual.K3 = fila_actual.d * this.beta;

                fila_actual.e = fila_actual.x + this.h;
                fila_actual.f = fila_actual.y + (this.h * fila_actual.K3);
                fila_actual.K4 = fila_actual.f * this.beta;

                fila_actual.xi1 = fila_actual.x + this.h;
                fila_actual.yi1 = fila_actual.y + ((double)(this.h / 6) * (fila_actual.dy_dx + 2 * fila_actual.K2 + 2 * fila_actual.K3 + fila_actual.K4));

                //imprimirFila(fila_actual);

                dt.Rows.Add(fila_actual.x.ToString(), fila_actual.y, fila_actual.dy_dx, fila_actual.K2, fila_actual.K3, fila_actual.K4, fila_actual.xi1, fila_actual.yi1);


                fila_anterior = fila_actual;
            }
            var t = fila_anterior.x;
            this.valorBuscado = t * 9;
            dt.Rows.Add();
            dt.Rows.Add();
            dt.Rows.Add("Valor Buscado", this.valorBuscado);
            oSLDocument.ImportDataTable(1, 1, dt, true);
            oSLDocument.SaveAs(archivo);
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

        private void rk_llegada_ataque_Load(object sender, EventArgs e)
        {

        }
    }
}
