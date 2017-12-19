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

namespace QuanLyMuaCaFe
{
    public partial class CTHD_NhapHang : Form
    {
        public CTHD_NhapHang()
        {
            InitializeComponent();
        }
        public void LoadCongThuc()
        {
            CTHD_NhapHang_DTO ct = new CTHD_NhapHang_DTO();
            ct.MaHDNH = tbMaHDNhap.Text;
            List<CTHD_NhapHang_DTO> List = CTHD_NhapHang_BUS.Show_HDNH(ct);
            foreach (var item in List)
            {
                ListViewItem MaMon = new ListViewItem(item.MaNL.ToString());
                MaMon.SubItems.Add(item.TenNL.ToString());
                MaMon.SubItems.Add(item.SoLuong.ToString());
                MaMon.SubItems.Add(item.DonGia.ToString());
                MaMon.SubItems.Add(item.DVT.ToString());
                listView1.Items.Add(MaMon);
            }
            tbTongTien.Text= List[0].TongTien.ToString(); 
        }

        private void CTHD_NhapHang_Load(object sender, EventArgs e)
        {
            LoadCongThuc();
        }
    }
}
