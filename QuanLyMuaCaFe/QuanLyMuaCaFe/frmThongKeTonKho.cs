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
    public partial class frmThongKeTonKho : Form
    {
        public ThongKeTonKho_BUS BUS = new ThongKeTonKho_BUS();
        public frmThongKeTonKho()
        {
            InitializeComponent();
            Load();
            
        }
        public void Load()
        {
            List<ThongKeTonKho_DTO> TK = BUS.LoadTonKho();
            dataGridView1.DataSource = TK;
            dataGridView1.Columns[4].Visible = false;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgrv = dataGridView1.CurrentRow;
            tbTenNL.Text = dgrv.Cells["TenNL"].Value.ToString();
            List<ThongKeTonKho_DTO> TK = BUS.LoadTonKho();
            for (int i = 0; i < TK.Count; i++)
            {
                if (tbTenNL.Text != TK[i].TenNL)
                {
                    tbTonKho.Text = "";
                }
            }
        }

        private void btTonKho_Click(object sender, EventArgs e)
        {
            if(tbTenNL.Text =="")
            {
                MessageBox.Show("Vui lòng chọn Nguyên Liệu cần tính tồn kho!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ThongKeTonKho_DTO TK = new ThongKeTonKho_DTO();
            TK.TenNL = tbTenNL.Text;
            List<ThongKeTonKho_DTO> List = ThongKeTonKho_BUS.TinhTonKho(TK);
            tbTonKho.Text = List[0].SoLuongTon.ToString();
        }

        private void frmThongKeTonKho_Click(object sender, EventArgs e)
        {
            dataGridView1.Focus();
            tbTenNL.Text = "";
        }
    }
}
