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
        //private List<Login_DTO> GetListPermission;
        public int UserID;
        public DataGridView dgrv;
        public Login_BUS BUS;
        
        public frmView()
        {
            InitializeComponent();
        }
        private void frmView_Load(object sender, EventArgs e)
        {
            
        }
        private void CheckQuyen()
        {
            
        }

        
    }
}
