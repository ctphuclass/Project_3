using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QLCF
{
    public partial class Form1 : Form
    {
        public static NhaCungCap_BUS BUS = new NhaCungCap_BUS();
        public static NhaCungCap_DTO DTO = new NhaCungCap_DTO();
        public Form1()
        {
            InitializeComponent();
            Load();
        }
        public void Load()
        {
            List<NhaCungCap_DTO> DanhSachNCC = BUS.GetNccList();
            dataGridView1.DataSource = DanhSachNCC;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btNew_Click(object sender, EventArgs e)
        {

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btDelete_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
