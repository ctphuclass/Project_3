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
    public partial class frmCongThuc : Form
    {
        public frmCongThuc()
        {
            InitializeComponent();
            Load();
        }
        public void Load()
        {
            List<CongThuc_DTO> CongThuc = CongThuc_BUS.GetListCongThuc();
            dataGridView1.DataSource = CongThuc; 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CongThuc_DTO CongThuc = new CongThuc_DTO();
            CongThuc.MaNL = tbSearch.Text;
            List<CongThuc_DTO> Search = CongThuc_BUS.Search_CongThuc(CongThuc);
            dataGridView1.DataSource = Search;
            if (tbSearch.Text == "")
            {
                Load();
            }
        }

        private void tbSearch_Click(object sender, EventArgs e)
        {
            tbSearch.Clear();
            Load();
        }

        private void frmCongThuc_Click(object sender, EventArgs e)
        {
            dataGridView1.Focus();
            tbSearch.Text = "Nhập mã NL hoặc tên NL hoặc Mã Món để tìm kiếm...";
            Load();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CongThuc_DTO CongThuc = new CongThuc_DTO();
            frmChiTietCongThuc ct = new frmChiTietCongThuc();
            CongThuc.MaMon = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();

            ct.tbMamon.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            ct.ShowDialog();
        }
    }
}
