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
        public static NhanVien_BUS BUS = new NhanVien_BUS();
        public static NhanVien_DTO DTO = new NhanVien_DTO();
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
            
            //Thực hiện việc lựa chọn Giới Tính thông qua ComboBox
            //List<clsGioiTinh> GioiTinh = new List<clsGioiTinh>();
            //GioiTinh.Add(new clsGioiTinh() { Name = "Nam" });
            //GioiTinh.Add(new clsGioiTinh() { Name = "Nữ" });
            //cbGioiTinh.DataSource = GioiTinh;
            //cbGioiTinh.DisplayMember = "Name";
            Load();
        }
        public void Load()
        {
            List<NhanVien_DTO> DanhSachNV = BUS.GetListNV();
            dataGridView1.DataSource = DanhSachNV;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //Thực hiện khi click vào 1 dòng trên DataGridView sẽ gán các giá trị vào các textbox tương ứng

            //DataGridViewRow dgrv = dataGridView1.CurrentRow;
            //tbMaNV.Text = dgrv.Cells["Ma_NV"].Value.ToString();
            //tbHoTenNV.Text = dgrv.Cells["HoTen_NV"].Value.ToString();

            //tbDiaChi.Text = dgrv.Cells["DiaChi"].Value.ToString();

            //tbSDT.Text = dgrv.Cells["SoDienThoai"].Value.ToString();
        }
    }
}
