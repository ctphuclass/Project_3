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
        public frmView fView = new frmView();
        public int UserID;
        int iLoginFailed;
        const int cNumberLoginFailed = 3;
        private int i = 10;
        public frmLogin()
        {
            InitializeComponent();
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
                frmView fView = new frmView();
                UserID = result.ResultCode;
                fView.UserID = UserID;
                MessageBox.Show(result.ResultMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                if (Login_BUS.CheckPermission(Login_DTO) == true)
                {

                    if (Login_DTO.Quyen == "nhanvien")
                    {
                        fView.doanhThuToolStripMenuItem.Enabled = false;
                        fView.quảnLíToolStripMenuItem.Enabled = false;
                    }
                    else
                    {
                        fView.NhanVienToolStripMenuItem.Enabled = true;
                        fView.nhàCungCấpToolStripMenuItem1.Enabled = true;
                        fView.doanhThuToolStripMenuItem.Enabled = true;
                    }
                }
                fView.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show(result.ResultMessage, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbUsername.Text = "";
                tbPassword.Text = "";
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
