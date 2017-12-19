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

namespace QuanLyThanhVien.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load();
        }
        public void Load()
        {
            List<ThanhVien_DTO> TV = ThanhVien_BUS.GetListTV();
            dtgv1.DataSource = TV;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tbMaNhanVien.Text == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu để thêm nhân viên!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ThanhVien_DTO NV_DTO = new ThanhVien_DTO();
            NV_DTO.MaTV = tbMaNhanVien.Text;
            NV_DTO.HoTen = tbHoTenNhanVien.Text;
            NV_DTO.NgaySinh = DateTime.Parse(DTPNgaySinh.Text);
            NV_DTO.GioiTinh = tbGioiTinh.Text;
            NV_DTO.DienThoai = tbSoDienThoai.Text;
            NV_DTO.DiaChi = tbDiaChi.Text;
            NV_DTO.Email = tbEmail.Text;
            NV_DTO.NgayLamThe = DateTime.Parse(DTPNgayLamThe.Text);
            NV_DTO.NgayHetHan = DateTime.Parse(DTPNgayHetHan.Text);

            if (ThanhVien_BUS.New_TV(NV_DTO) == true)
            {
                MessageBox.Show("Thêm thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm Thất bại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Load();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
