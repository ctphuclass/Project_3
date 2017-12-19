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

namespace QuanLyThuVien
{
    public partial class frmListPersonel : Form
    {
        //List<NhanVien_BO> ls;
        //BindingSource BS;
        //DataGridViewRow dgvrCurrent;
        public frmListPersonel()
        {
            InitializeComponent();
            Load();
            //dtgv1.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
            //dtgv1.Columns["HoTen"].HeaderText = "Họ Tên";
            //dtgv1.Columns["GioiTinh"].HeaderText = "Giới Tính";
            //dtgv1.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            //dtgv1.Columns["DienThoai"].HeaderText = "Số Điện Thoại";
            //dtgv1.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            //dtgv1.Columns["NgayVaoLam"].HeaderText = "Ngày Vào Làm";
        }

        
        private void frmListPersonel_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    NhanVien_BO NhanVien = new NhanVien_BO();
            //    NhanVien_BL BL = new NhanVien_BL();
            //    NhanVien.MaNV = "";
            //    NhanVien.HoTen = "";
            //    NhanVien.GioiTinh = "";
            //    NhanVien.NgaySinh = DateTime.Now;
            //    NhanVien.DienThoai = "";
            //    NhanVien.DiaChi = "";
            //    NhanVien.Email = "";
            //    NhanVien.NgayVaoLam = DateTime.Now;
            //    List<NhanVien_BO> ls = (List<NhanVien_BO>)BS.DataSource;
            //    ls.Add(NhanVien);
            //    BS = new BindingSource { DataSource = ls };
            //    dtgv1.DataSource = BS;
            //    if (dgvrCurrent.IsNewRow == false)
            //    {
            //        MessageBox.Show("Thêm Thành Công!");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Thêm Thất Bại!");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        public void Load()
        {
            List<ThanhVien_DTO> TV = ThanhVien_BUS.GetListTV();
            dtgv1.DataSource = TV;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //NhanVien_BO NhanVien = new NhanVien_BO();
            //NhanVien_BL BL = new NhanVien_BL();
            //NhanVien.MaNV = tbMaNhanVien.Text;
            //NhanVien.HoTen = tbHoTenNhanVien.Text;
            //NhanVien.GioiTinh = tbGioiTinh.Text;
            //NhanVien.NgaySinh = DTPNgaySinh.Value;
            //NhanVien.DienThoai = tbSoDienThoai.Text;
            //NhanVien.DiaChi = tbDiaChi.Text;
            //NhanVien.Email = tbEmail.Text;
            //NhanVien.NgayVaoLam = DTPNgayVaoLam.Value;
            //BL.Sua(NhanVien);
            //Load();
            //if (BL.Sua(NhanVien) == true)
            //{
            //    MessageBox.Show("Sửa Thành Công!");
            //}
            //else
            //{
            //    MessageBox.Show("Sửa Thất Bại!");
            //}
        }

        private void dtgv1_CurrentCellChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    dgvrCurrent = dtgv1.CurrentRow;
            //    if (dgvrCurrent != null)
            //    {
            //        tbMaNhanVien.Text = dgvrCurrent.Cells["MaNV"].Value.ToString();
            //        tbHoTenNhanVien.Text= dgvrCurrent.Cells["HoTen"].Value.ToString();
            //        tbGioiTinh.Text= dgvrCurrent.Cells["GioiTinh"].Value.ToString();
            //        DTPNgaySinh.Text=dgvrCurrent.Cells["NgaySinh"].Value.ToString();
            //        tbGioiTinh.Text= dgvrCurrent.Cells["GioiTinh"].Value.ToString();
            //        tbSoDienThoai.Text = dgvrCurrent.Cells["DienThoai"].Value.ToString();
            //        tbDiaChi.Text= dgvrCurrent.Cells["DiaChi"].Value.ToString();
            //        tbEmail.Text= dgvrCurrent.Cells["Email"].Value.ToString();
            //        DTPNgayVaoLam.Text= dgvrCurrent.Cells["NgayVaoLam"].Value.ToString();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //NhanVien_BO NhanVien = new NhanVien_BO();
            //NhanVien_BL BL = new NhanVien_BL();
            //NhanVien.MaNV = tbMaNhanVien.Text;
            //BL.Xoa(NhanVien);
            //Load();
            //if (BL.Xoa(NhanVien) == true)
            //{
            //    MessageBox.Show("Xóa Thành Công!");
            //}
            //else
            //{
            //    MessageBox.Show("Xóa Thất Bại!");

            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //NhanVien_BO NhanVien = new NhanVien_BO();
            //NhanVien_BL BL = new NhanVien_BL();
            //NhanVien.MaNV = tbTimKiemNV.Text;
            //List<NhanVien_BO> ls = BL.TimNV(NhanVien);
            //dtgv1.DataSource = ls;
        }
    }
     
}
