using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMuaCaFe
{
    public partial class frmLogin : Form
    {
        private int i = 10;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Left += i;
            if(label4.Left >= 550 || label4.Left <= 0)
            {
                i = -i;
            }
        }
    }
}
