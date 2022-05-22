using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_SIM.TP5
{
    public partial class tp5_window : Form
    {
        public bool bandera = true;
        public tp5_window()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bandera)
            {
                p_probabilidades.Visible = true;
                bandera = false;
            }
            else
            {
                p_probabilidades.Visible = false;
                bandera = true;
            }
        }
    }
}
