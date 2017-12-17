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
    public partial class frmChiTietCongThuc : Form
    {
        public frmChiTietCongThuc()
        {
            InitializeComponent();
            
        }
        public void LoadCongThuc()
        {
            tbMamon.BackColor = Color.White;
            ChiTietCongThuc_DTO ct = new ChiTietCongThuc_DTO();
            ct.MaMon = tbMamon.Text;
            List<ChiTietCongThuc_DTO> List = ChiTietCongThuc_BUS.ChiTietCongThuc(ct);
            foreach (var item in List)
            {
                ListViewItem MaMon = new ListViewItem(item.MaNL.ToString());
                MaMon.SubItems.Add(item.TenNL.ToString());
                MaMon.SubItems.Add(item.HamLuong.ToString());
                MaMon.SubItems.Add(item.DVT.ToString());
                listView1.Items.Add(MaMon);
            }
        }

        private void frmChiTietCongThuc_Load(object sender, EventArgs e)
        {
            LoadCongThuc();
        }
    }
}
