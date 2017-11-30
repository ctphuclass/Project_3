using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyMuaCaFe
{
    public partial class frmLogin : Form
    {
        public int UserID;
        int iLoginFailed;
        const int cNumberLoginFailed = 3;
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

        private void button1_Click(object sender, EventArgs e)
        {
            ResultMessage_DTO result;
            Login_DTO Login_DTO = new Login_DTO();
            Login_BUS Login_BUS = new Login_BUS();
            Login_DTO.UserName = tbUsername.Text;
            Login_DTO.PassWord = tbPassword.Text;
            result = Login_BUS.SaveUserregisrationBL(Login_DTO);
            if (result.ResultCode > 0)
            {
                UserID = result.ResultCode;
                this.Close();
            }
            else
            {
                MessageBox.Show(result.ResultMessage);
                if (iLoginFailed < cNumberLoginFailed)
                {
                    iLoginFailed += 1;
                    this.DialogResult = DialogResult.None;
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
