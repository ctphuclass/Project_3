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
    public partial class frmMenu : Form
    {
        public static Menu_BUS BUS = new Menu_BUS();
        public static Menu_DTO DTO = new Menu_DTO();
        public frmMenu()
        {
            InitializeComponent();
            Load();
        }
        public void Load()
        {
            List<Menu_DTO> DanhSachMenu = BUS.GetListMenu();
            dataGridView1.DataSource = DanhSachMenu;
        }
        public void Clear()
        {
            tbMaMon.Text = "";
            tbTenMon.Text = "";
            tbLoai.Text = "";
            tbDonGia.Text = "0";
            tbDVT.Text = "";
            ckMaMon.Checked = false;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {  
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgrv = dataGridView1.CurrentRow;
            tbMaMon.Text = dgrv.Cells["MaMon"].Value.ToString();
            tbTenMon.Text = dgrv.Cells["TenMon"].Value.ToString();
            tbLoai.Text = dgrv.Cells["Loai"].Value.ToString();
            tbDonGia.Text = dgrv.Cells["DonGia"].Value.ToString();
            tbDVT.Text = dgrv.Cells["DVT"].Value.ToString();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            List<Menu_DTO> DanhSachMenu = BUS.GetListMenu();
            if (ckMaMon.Checked == false)
            {
                MessageBox.Show("Vui lòng check vào trong ô gần MaMon để thêm mới Menu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            { 
                if(tbMaMon.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập dữ liệu!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }
            }
            Menu_DTO Menu_DTO = new Menu_DTO();
            Menu_DTO.MaMon = tbMaMon.Text;
            Menu_DTO.TenMon = tbTenMon.Text;
            Menu_DTO.Loai = tbLoai.Text;
            Menu_DTO.DonGia = Int32.Parse(tbDonGia.Text);
            Menu_DTO.DVT = tbDVT.Text;

            for (int i = 0; i < DanhSachMenu.Count; i++)
            {
                if (DanhSachMenu[i].TenMon == Menu_DTO.TenMon
                    && DanhSachMenu[i].Loai == Menu_DTO.Loai
                    && DanhSachMenu[i].DonGia == Menu_DTO.DonGia
                    && DanhSachMenu[i].DVT == Menu_DTO.DVT
                    )
                {
                    MessageBox.Show("Dữ liệu đã tồn tại! Vui lòng thay đổi lại để thêm mới!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            if (Menu_BUS.New_Nenu(Menu_DTO) == true)
            {
                MessageBox.Show("Thêm Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Món Ăn đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Load();
            Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            List<Menu_DTO> DanhSachMenu = BUS.GetListMenu();
            ResultMessage_DTO result;
            if (tbMaMon.Text == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Menu_DTO Menu_DTO = new Menu_DTO();
            Menu_DTO.MaMon = tbMaMon.Text;
            Menu_DTO.TenMon = tbTenMon.Text;
            Menu_DTO.Loai = tbLoai.Text;
            Menu_DTO.DonGia = Int32.Parse(tbDonGia.Text);
            Menu_DTO.DVT = tbDVT.Text;
            for (int i = 0; i < DanhSachMenu.Count; i++)
            {
                if (DanhSachMenu[i].MaMon == Menu_DTO.MaMon
                    && DanhSachMenu[i].TenMon == Menu_DTO.TenMon
                    && DanhSachMenu[i].Loai == Menu_DTO.Loai
                    && DanhSachMenu[i].DonGia == Menu_DTO.DonGia
                    && DanhSachMenu[i].DVT == Menu_DTO.DVT
                    )
                {
                    MessageBox.Show("Bạn chưa thay đổi dữ liệu cũ! Vui lòng thay đổi dữ liệu mới trước khi Update!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            result = BUS.Update_Menu(Menu_DTO);
            if (result.ResultCode_Menu == "1")
            {
                MessageBox.Show(result.ResultMessage_Menu, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.ResultMessage_Menu, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Load();
            Clear();
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            ResultMessage_DTO result;
            if (tbMaMon.Text == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Menu_DTO Menu_DTO = new Menu_DTO();
            Menu_DTO.MaMon = tbMaMon.Text;
            Menu_DTO.TenMon = tbTenMon.Text;
            Menu_DTO.Loai = tbLoai.Text;
            Menu_DTO.DonGia = Int32.Parse(tbDonGia.Text);
            Menu_DTO.DVT = tbDVT.Text;
            result = BUS.Delete_Menu(Menu_DTO);
            if (result.ResultCode_Menu == "1")
            {
                MessageBox.Show(result.ResultMessage_Menu, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.ResultMessage_Menu, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Load();
            Clear();
        }
        private void tbSearch_Click(object sender, EventArgs e)
        {
            tbSearch.Clear();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            Menu_DTO Menu = new Menu_DTO();
            Menu.MaMon = tbSearch.Text;
            List<Menu_DTO> Search = Menu_BUS.Search_Menu(Menu);
            dataGridView1.DataSource = Search;
            if (tbSearch.Text == "")
            {
                Load();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMenu_Click(object sender, EventArgs e)
        {
            dataGridView1.Focus();
            tbSearch.Text = "Nhập Mã hoặc Tên Món để tìm kiếm...";
            Load();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckMaMon.Checked == true)
            {
                tbMaMon.Enabled = true;
            }
            else
            {
                tbMaMon.Enabled = false;
            }
        }
    }
}
