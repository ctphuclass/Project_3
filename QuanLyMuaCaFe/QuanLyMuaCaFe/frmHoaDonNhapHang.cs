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
    public partial class frmHoaDonNhapHang : Form
    {
        public frmHoaDonNhapHang()
        {
            InitializeComponent();
            Load();
        }
        public void Load()
        {
            List<HoaDonNhapHang_DTO> Danhsach = HoaDonNhapHang_BUS.GetListHDNH();
            dataGridView1.DataSource = Danhsach;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            HoaDonNhapHang_DTO HDNH = new HoaDonNhapHang_DTO();
            HDNH.MaHoaDonNhap = tbSearch.Text;
            List<HoaDonNhapHang_DTO> Search = HoaDonNhapHang_BUS.Search_HDBH(HDNH);
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

        private void frmHoaDonNhapHang_Click(object sender, EventArgs e)
        {
            dataGridView1.Focus();
            tbSearch.Text = "Nhập Mã Hóa Đơn Hoặc Nhập Mã Nhà Cung Cấp Để tìm Kiếm...";
            Load();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            HoaDonNhapHang_DTO HDNH = new HoaDonNhapHang_DTO();
            HDNH.MaHoaDonNhap = this.dataGridView1.CurrentRow.Cells[0].ToString();

            CTHD_NhapHang frmCTHD = new CTHD_NhapHang();
            frmCTHD.tbMaHDNhap.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmCTHD.tbMaNCC.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmCTHD.tbNgayLap.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();

            frmCTHD.ShowDialog();
        }
    }
}
