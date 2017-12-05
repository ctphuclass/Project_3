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
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //Thực hiện khi click vào 1 dòng trên DataGridView sẽ gán các giá trị vào các textbox tương ứng

            DataGridViewRow dgrv = dataGridView1.CurrentRow;
            tbMaNCC.Text = dgrv.Cells["MaNCC"].Value.ToString();
            tbTenNCC.Text = dgrv.Cells["TenNCC"].Value.ToString();
            tbDiaChi.Text = dgrv.Cells["DiaChi"].Value.ToString();
            tbSDT.Text = dgrv.Cells["SoDienThoai"].Value.ToString();
        }

        private void btNew_Click_1(object sender, EventArgs e)
        {
            // Thực hiện Tạo mới Nhà cung cấp
            if (tbMaNCC.Text == "" || tbTenNCC.Text == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!");
                return;
            }
            NhaCungCap_DTO NCC_DTO = new NhaCungCap_DTO();
            NCC_DTO.MaNCC = tbMaNCC.Text;
            NCC_DTO.TenNCC = tbTenNCC.Text;
            NCC_DTO.DiaChi = tbDiaChi.Text;
            NCC_DTO.SoDienThoai = tbSDT.Text;


            if (NhaCungCap_BUS.New_NCC(NCC_DTO) == true)
            {
                MessageBox.Show("Thêm Thành Công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm Thất bại!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            Load();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (tbMaNCC.Text == "" || tbTenNCC.Text == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!");
                return;
            }
            NhaCungCap_DTO NCC_DTO = new NhaCungCap_DTO();
            NCC_DTO.MaNCC = tbMaNCC.Text;
            NCC_DTO.TenNCC = tbTenNCC.Text;
            NCC_DTO.DiaChi = tbDiaChi.Text;
            NCC_DTO.SoDienThoai = tbSDT.Text;

            if (NhaCungCap_BUS.Update_NCC(NCC_DTO) == true)
            {
                MessageBox.Show("Sửa Thành Công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sửa Thất bại!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            Load();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (tbMaNCC.Text == "")
            {
                MessageBox.Show("Hãy chọn Nhà Cung Cấp cần xóa!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }
            NhaCungCap_DTO NCC_DTO = new NhaCungCap_DTO();
            NCC_DTO.MaNCC = tbMaNCC.Text;
            NCC_DTO.TenNCC = tbTenNCC.Text;
            NCC_DTO.DiaChi = tbDiaChi.Text;
            NCC_DTO.SoDienThoai = tbSDT.Text;
            if (NhaCungCap_BUS.Delete_NCC(NCC_DTO) == true)
            {
                MessageBox.Show("Xóa Thành Công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa Thất bại!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            Load();
        }

        private void tbDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
