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
    public partial class frmChiTietHDBH : Form
    {
        public frmChiTietHDBH()
        {
            InitializeComponent();
            
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void labelDonGia_Click(object sender, EventArgs e)
        {

        }

        private void frmChiTietHDBH_Load(object sender, EventArgs e)
        {
            LoadCT();
            ChiTietHDBH_DTO ct = new ChiTietHDBH_DTO();
            ct.MaHoaDon = tbMaHD.Text;
            List<ChiTietHDBH_DTO> List = ChiTietHDBH_BUS.TinhTongTien(ct);
            tbTongTien.Text = List[0].TongTien.ToString();
        }
        public void LoadCT()
        {
            ChiTietHDBH_DTO ct = new ChiTietHDBH_DTO();
            ct.MaHoaDon = tbMaHD.Text;
            List<ChiTietHDBH_DTO> List = ChiTietHDBH_BUS.Show_HDBH(ct);
            foreach(var item in List)
            {
                ListViewItem Temon = new ListViewItem(item.TenMon.ToString());
                Temon.SubItems.Add(item.SoLuong.ToString());
                Temon.SubItems.Add(item.DonGia.ToString());
                Temon.SubItems.Add(item.ThanhTien.ToString());
                listView1.Items.Add(Temon);
            }
        }
    }
}
