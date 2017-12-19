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
        private void NhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien frmNV = new frmQuanLyNhanVien();
            frmNV.ShowDialog();
        }

        private void nhàCungCấpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 frmNCC = new Form1();
            frmNCC.ShowDialog();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.ShowDialog();
        }

        private void quảnLíToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hóaĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void nguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNguyenLieu NL = new frmNguyenLieu();
            NL.ShowDialog();
        }

        private void côngThứcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCongThuc CongThuc = new frmCongThuc();
            CongThuc.ShowDialog();
        }

        private void hóaĐơnBánHàngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmHoaDonBanHang HDBH = new frmHoaDonBanHang();
            HDBH.ShowDialog();
        }

        private void tínhTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeTonKho TK = new frmThongKeTonKho();
            TK.ShowDialog();
        }

        private void xemDoanhThuTrong1KhoảngThờiGianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoanhThu DT = new frmDoanhThu();
            DT.ShowDialog();
        }

        private void hóaĐơnNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonNhapHang NH = new frmHoaDonNhapHang();
            NH.ShowDialog();
        }
    }
}
