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
        public void Clear()
        {
            tbMaNCC.Clear();
            tbTenNCC.Clear();
            tbDiaChi.Clear();
            tbSDT.Clear();
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
            List<NhaCungCap_DTO> DanhSachNCC = BUS.GetNccList();
            if (ckMaNCC.Checked == false)
            {
                MessageBox.Show("Vui lòng check vào trong ô gần MaNL để thêm mới Nhà Cung Cấp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            { 
                if (tbMaNCC.Text == "" || tbTenNCC.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập dữ liệu!");
                    return;
                }
            }
            NhaCungCap_DTO NCC_DTO = new NhaCungCap_DTO();
            NCC_DTO.MaNCC = tbMaNCC.Text;
            NCC_DTO.TenNCC = tbTenNCC.Text;
            NCC_DTO.DiaChi = tbDiaChi.Text;
            NCC_DTO.SoDienThoai = tbSDT.Text;
            for (int i = 0; i < DanhSachNCC.Count; i++)
            {
                if (DanhSachNCC[i].MaNCC == NCC_DTO.MaNCC
                    && DanhSachNCC[i].TenNCC == NCC_DTO.TenNCC
                    && DanhSachNCC[i].DiaChi == NCC_DTO.DiaChi
                    && DanhSachNCC[i].SoDienThoai == NCC_DTO.SoDienThoai
                    )
                {
                    MessageBox.Show("Dữ liệu đã tồn tại! Vui lòng thay đổi lại để thêm mới!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            if (NhaCungCap_BUS.New_NCC(NCC_DTO) == true)
            {
                MessageBox.Show("Thêm Thành Công!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nhà Cung Cấp đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Clear();
            Load();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            List<NhaCungCap_DTO> DanhSachNCC = BUS.GetNccList();
            ResultMessage_DTO result;
            if (tbMaNCC.Text == "" || tbTenNCC.Text == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu để sửa thông tin Nhà Cung Cấp!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            NhaCungCap_DTO NCC_DTO = new NhaCungCap_DTO();
            NCC_DTO.MaNCC = tbMaNCC.Text;
            NCC_DTO.TenNCC = tbTenNCC.Text;
            NCC_DTO.DiaChi = tbDiaChi.Text;
            NCC_DTO.SoDienThoai = tbSDT.Text;
            for (int i = 0; i < DanhSachNCC.Count; i++)
            {
                if (DanhSachNCC[i].MaNCC == NCC_DTO.MaNCC
                    && DanhSachNCC[i].TenNCC == NCC_DTO.TenNCC
                    && DanhSachNCC[i].DiaChi == NCC_DTO.DiaChi
                    && DanhSachNCC[i].SoDienThoai == NCC_DTO.SoDienThoai
                    )
                {
                    MessageBox.Show("Bạn chưa thay đổi dữ liệu cũ! Vui lòng thay đổi dữ liệu mới trước khi Update!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            result = BUS.Update_NCC(NCC_DTO);
            if (result.ResultCode_NCC == "1")
            {
                MessageBox.Show(result.ResultMessage_NCC, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.ResultMessage_NCC, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Clear();
            Load();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            ResultMessage_DTO result;
            if (tbMaNCC.Text == "")
            {
                MessageBox.Show("Hãy chọn Nhà Cung Cấp cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            NhaCungCap_DTO NCC_DTO = new NhaCungCap_DTO();
            NCC_DTO.MaNCC = tbMaNCC.Text;
            NCC_DTO.TenNCC = tbTenNCC.Text;
            NCC_DTO.DiaChi = tbDiaChi.Text;
            NCC_DTO.SoDienThoai = tbSDT.Text;

            result = BUS.Delete_NCC(NCC_DTO);
            if (result.ResultCode_NCC == "1")
            {
                MessageBox.Show(result.ResultMessage_NCC, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.ResultMessage_NCC, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Clear();
            Load();
            
        }
        
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            NhaCungCap_DTO NCC = new NhaCungCap_DTO();
            NCC.MaNCC = tbSearch.Text;
            List<NhaCungCap_DTO> Search = NhaCungCap_BUS.Search_NCC(NCC);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void ckMaNCC_CheckedChanged(object sender, EventArgs e)
        {
            if(ckMaNCC.Checked == false)
            {
                tbMaNCC.Enabled = false;
            }
            else
            {
                tbMaNCC.Enabled = true;
            }
        }
    }
}
