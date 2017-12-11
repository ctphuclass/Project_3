using System;
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
    public partial class frmQuanLyNhanVien : Form
    {
        public ResultMessage_DTO result;
        public static NhanVien_BUS BUS = new NhanVien_BUS();
        public static NhanVien_DTO DTO = new NhanVien_DTO();
        public frmQuanLyNhanVien()
        {
            InitializeComponent();

            //Thực hiện việc lựa chọn Giới Tính thông qua ComboBox
            List<clsGioiTinh> GioiTinh = new List<clsGioiTinh>();
            GioiTinh.Add(new clsGioiTinh() { Name = "" });
            GioiTinh.Add(new clsGioiTinh() { Name = "Nam" });
            GioiTinh.Add(new clsGioiTinh() { Name = "Nữ" });
            cbGioiTinh.DataSource = GioiTinh;
            cbGioiTinh.DisplayMember = "Name";
            Load();
        }
        public void Load()
        {
            List<NhanVien_DTO> DanhSachNV = BUS.GetListNV();
            datagrid123.DataSource = DanhSachNV;
        }
        public void Clear()
        {
            tbMaNV.Clear();
            tbHoTenNV.Clear();
            dtPickerNgaySinh.Text = "";
            cbGioiTinh.Text = "";
            tbQueQuan.Clear();
            tbDiaChi.Clear();
            tbEmail.Clear();
            tbSDT.Clear();
            tbSearch.Text = "Nhập Mã hoặc Họ Tên Nhân Viên để tìm kiếm...";
            Load();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void btSearch_Click(object sender, EventArgs e)
        {

        }
        private void datagrid123_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Thực hiện khi click vào 1 dòng trên DataGridView sẽ gán các giá trị vào các textbox tương ứng

            DataGridViewRow dgrv = datagrid123.CurrentRow;
            tbMaNV.Text = dgrv.Cells["MaNV"].Value.ToString();
            tbHoTenNV.Text = dgrv.Cells["HoTenNV"].Value.ToString();
            dtPickerNgaySinh.Text = dgrv.Cells["NgaySinh"].Value.ToString();
            cbGioiTinh.Text = dgrv.Cells["GioiTinh"].Value.ToString();
            tbQueQuan.Text = dgrv.Cells["QueQuan"].Value.ToString();
            tbDiaChi.Text = dgrv.Cells["DiaChi"].Value.ToString();
            tbEmail.Text = dgrv.Cells["Email"].Value.ToString();
            tbSDT.Text = dgrv.Cells["SDT"].Value.ToString();
        }

        private void btNewNV_Click(object sender, EventArgs e)
        {
            if (tbMaNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu để thêm nhân viên!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            NhanVien_DTO NV_DTO = new NhanVien_DTO();
            NV_DTO.MaNV = tbMaNV.Text;
            NV_DTO.HoTenNV = tbHoTenNV.Text;
            NV_DTO.NgaySinh = dtPickerNgaySinh.Text;
            NV_DTO.GioiTinh = cbGioiTinh.Text;
            NV_DTO.QueQuan = tbQueQuan.Text;
            NV_DTO.DiaChi = tbDiaChi.Text;
            NV_DTO.Email = tbEmail.Text;
            NV_DTO.SDT = tbSDT.Text;
            if (NhanVien_BUS.New_NV(NV_DTO) == true)
            {
                MessageBox.Show("Thêm thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm Thất bại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Load();
            Clear();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            NhanVien_DTO NV_DTO = new NhanVien_DTO();
            NhanVien_BUS NV_BUS = new NhanVien_BUS();
            if (tbMaNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu để sửa thông tin nhân viên!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            NV_DTO.MaNV = tbMaNV.Text;
            NV_DTO.HoTenNV = tbHoTenNV.Text;
            NV_DTO.NgaySinh = dtPickerNgaySinh.Text;
            NV_DTO.GioiTinh = cbGioiTinh.Text;
            NV_DTO.QueQuan = tbQueQuan.Text;
            NV_DTO.DiaChi = tbDiaChi.Text;
            NV_DTO.Email = tbEmail.Text;
            NV_DTO.SDT = tbSDT.Text;

            result = BUS.Update_NV(NV_DTO);
            if (result.ResultCode_NV == "1")
            {
                MessageBox.Show(result.ResultMessage_NV, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.ResultMessage_NV, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Load();
            Clear();
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (tbMaNV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            NhanVien_DTO NV_DTO = new NhanVien_DTO();
            NV_DTO.MaNV = tbMaNV.Text;
            NV_DTO.HoTenNV = tbHoTenNV.Text;
            NV_DTO.NgaySinh = dtPickerNgaySinh.Text;
            NV_DTO.GioiTinh = cbGioiTinh.Text;
            NV_DTO.QueQuan = tbQueQuan.Text;
            NV_DTO.DiaChi = tbDiaChi.Text;
            NV_DTO.Email = tbEmail.Text;
            NV_DTO.SDT = tbSDT.Text;


            result = BUS.Delete_NV(NV_DTO);
            if (result.ResultCode_NV == "1")
            {
                MessageBox.Show(result.ResultMessage_NV, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.ResultMessage_NV, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Load();
            Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            NhanVien_DTO NV = new NhanVien_DTO();
            NV.MaNV = tbSearch.Text;
            List<NhanVien_DTO> Search = NhanVien_BUS.Search_NV(NV);
            datagrid123.DataSource = Search;
            if(tbSearch.Text == "")
            { 
            Load();
            }
        }

        private void tbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbSearch_Click(object sender, EventArgs e)
        {
            tbSearch.Clear();
        }
    }
}