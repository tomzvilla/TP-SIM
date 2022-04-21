using System;
using System.Windows.Forms;

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
    }
}
