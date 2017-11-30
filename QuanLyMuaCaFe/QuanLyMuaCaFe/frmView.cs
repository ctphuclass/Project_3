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
    public partial class frmView : Form
    {
        private List<Login_DTO> listPermission;
        public int UserID;
        Login_BUS BUS;
        public frmView()
        {
            InitializeComponent();
        }
        private void frmView_Load(object sender, EventArgs e)
        {
            listPermission = BUS.GetPermission(piUserID, "admin");
            CheckQuyen();
        }
        private void CheckQuyen()
        {
            Login_DTO result = listPermission.Find(item => item.Quyen == "Nhà Cung Cấp");
            if(result != null)
            {
                nhàCungCấpToolStripMenuItem.Enabled = true;
            }
            else
            {
                nhàCungCấpToolStripMenuItem.Enabled = false;
            }
        }

        
    }
}
