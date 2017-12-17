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
    public partial class frmNguyenLieu : Form
    {
        public ResultMessage_DTO result;
        public static NguyenLieu_BUS BUS = new NguyenLieu_BUS();
        public static NguyenLieu_DTO DTO = new NguyenLieu_DTO();
        public frmNguyenLieu()
        {
            InitializeComponent();
            //Thực hiện việc lựa chọn DVT thông qua ComboBox
            List<clsGioiTinh> GioiTinh = new List<clsGioiTinh>();
            GioiTinh.Add(new clsGioiTinh() { Name = "" });
            GioiTinh.Add(new clsGioiTinh() { Name = "Gói" });
            GioiTinh.Add(new clsGioiTinh() { Name = "Kg" });
            cbDVT.DataSource = GioiTinh;
            cbDVT.DisplayMember = "Name";
            Load();
        }
        public void Load()
        {
            List<NguyenLieu_DTO> danhsachNL = NguyenLieu_BUS.GetListNL();
            dataGridView1.DataSource = danhsachNL;
        }
        public void Clear()
        {
            tbMaNL.Clear();
            tbTenNL.Clear();
            tbSoLuong.Text = "0";
            cbDVT.Text = "";
            ckMaNL.Checked = false;
            tbSearch.Text = "Nhập Mã hoặc Tên Nguyên Liệu để tìm kiếm...";
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Thực hiện khi click vào 1 dòng trên DataGridView sẽ gán các giá trị vào các textbox tương ứng
            DataGridViewRow dgrv = dataGridView1.CurrentRow;
            tbMaNL.Text = dgrv.Cells["MaNL"].Value.ToString();
            tbTenNL.Text = dgrv.Cells["TenNL"].Value.ToString();
            tbSoLuong.Text = dgrv.Cells["SoLuongNhap"].Value.ToString();
            cbDVT.Text = dgrv.Cells["DVT"].Value.ToString(); ;
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            List<NguyenLieu_DTO> DanhSachNL = NguyenLieu_BUS.GetListNL();
            if (ckMaNL.Checked == false)
            {
                MessageBox.Show("Vui lòng check vào trong ô gần MaNL để thêm mới Nguyên Liệu!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (tbMaNL.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập dữ liệu để thêm Nguyên Liệu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            NguyenLieu_DTO NL = new NguyenLieu_DTO();
            NL.MaNL = tbMaNL.Text;
            NL.TenNL = tbTenNL.Text;
            NL.SoLuongNhap = Int32.Parse(tbSoLuong.Text);
            NL.DVT = cbDVT.Text;
            for (int i = 0; i < DanhSachNL.Count; i++)
            {
                if (//DanhSachNL[i].MaNL == NL.MaNL&& 
                    DanhSachNL[i].TenNL == NL.TenNL
                    && DanhSachNL[i].SoLuongNhap == NL.SoLuongNhap
                    && DanhSachNL[i].DVT == NL.DVT
                    )
                {
                    MessageBox.Show("Dữ liệu đã tồn tại! Vui lòng thay đổi lại để thêm mới!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            if (NguyenLieu_BUS.New_NL(NL) == true)
            {
                MessageBox.Show("Thêm thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nguyên Liệu đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Clear();
            Load();
        }
        private void ckMaNL_CheckedChanged(object sender, EventArgs e)
        {
            if (ckMaNL.Checked == true)
            {
                tbMaNL.Enabled = true;
            }
            else
            {
                tbMaNL.Enabled = false;
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            List<NguyenLieu_DTO> DanhSachNL = NguyenLieu_BUS.GetListNL();
            if (tbMaNL.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin Nguyên Liệu để sửa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            NguyenLieu_DTO NL = new NguyenLieu_DTO();
            NL.MaNL = tbMaNL.Text;
            NL.TenNL = tbTenNL.Text;
            NL.SoLuongNhap = Int32.Parse(tbSoLuong.Text);
            NL.DVT = cbDVT.Text;

            for (int i = 0; i < DanhSachNL.Count; i++)
            {
                if (DanhSachNL[i].MaNL == NL.MaNL
                    && DanhSachNL[i].TenNL == NL.TenNL
                    && DanhSachNL[i].SoLuongNhap == NL.SoLuongNhap
                    && DanhSachNL[i].DVT == NL.DVT
                    )
                {
                    MessageBox.Show("Bạn chưa thay đổi dữ liệu cũ! Vui lòng thay đổi dữ liệu mới trước khi Update", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            result = NguyenLieu_BUS.Update_NL(NL);
            if (result.ResultCode_NL == 1)
            {
                MessageBox.Show(result.ResultMessage_NL, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.ResultMessage_NL, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Clear();
            Load();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (tbMaNL.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Nguyên Liệu để xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            NguyenLieu_DTO NL = new NguyenLieu_DTO();
            NL.MaNL = tbMaNL.Text;
            NL.TenNL = tbTenNL.Text;
            NL.SoLuongNhap = Int32.Parse(tbSoLuong.Text);
            NL.DVT = cbDVT.Text;
            result = NguyenLieu_BUS.Delete_NL(NL);
            if (result.ResultCode_NL == 1)
            {
                MessageBox.Show(result.ResultMessage_NL, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.ResultMessage_NL, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Clear();
            Load();
            
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            NguyenLieu_DTO NL = new NguyenLieu_DTO();
            NL.MaNL = tbSearch.Text;
            List<NguyenLieu_DTO> Search = NguyenLieu_BUS.Search_NL(NL);
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

        private void frmNguyenLieu_Click(object sender, EventArgs e)
        {
            dataGridView1.Focus();
            tbSearch.Text = "Nhập Mã hoặc Tên Nguyên Liệu để tìm kiếm...";
            Load();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Clear();
            Load();
        }
    }
}
