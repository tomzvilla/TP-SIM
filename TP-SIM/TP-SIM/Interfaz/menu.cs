using System;
using System.Windows.Forms;
using TP_SIM.TP4;

namespace TP_SIM.Interfaz
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btn_tp1_Click(object sender, EventArgs e)
        {
            var form = new tp1_window();
            form.ShowDialog();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            var form = new tp3_window();
            this.Hide();
            form.Show();
        

        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_tp4_Click(object sender, EventArgs e)
        {
            var form = new tp4_window();
            this.Hide();
            form.Show();
        }
    }
}
