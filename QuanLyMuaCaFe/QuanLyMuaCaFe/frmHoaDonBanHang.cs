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
    public partial class frmHoaDonBanHang : Form
    {
        public frmHoaDonBanHang()
        {
            InitializeComponent();
            Load();
        }
        public void Load()
        {
            List<HDBanHang_DTO> DanhSachHD = HDBanHang_BUS.GetListHDBH();
            dataGridView1.DataSource = DanhSachHD;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            HDBanHang_DTO HDBH = new HDBanHang_DTO();
            HDBH.MaHoaDon = tbSearch.Text;
            List<HDBanHang_DTO> Search = HDBanHang_BUS.Search_HDBH(HDBH);
            dataGridView1.DataSource = Search;
            if (tbSearch.Text == "")
            {
                Load();
            }
        }

        private void tbSearch_Click(object sender, EventArgs e)
        {
            tbSearch.Clear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            HDBanHang_DTO CTHD_DTO = new HDBanHang_DTO();
            frmChiTietHDBH CTHD = new frmChiTietHDBH();
            CTHD_DTO.MaHoaDon = this.dataGridView1.CurrentRow.Cells[0].ToString();

            CTHD.tbMaHD.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            CTHD.tbTenBan.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            CTHD.tbMaNV.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            CTHD.tbNgayLap.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            
            CTHD.ShowDialog();
        }

        private void frmHoaDonBanHang_Click(object sender, EventArgs e)
        {
            dataGridView1.Focus();
            tbSearch.Text = "Nhập Mã Hóa Đơn để tìm kiếm...";
            Load();
        }
    }
}
