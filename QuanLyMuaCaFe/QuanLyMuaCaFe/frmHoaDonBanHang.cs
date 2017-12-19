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
using Microsoft.Office.Interop.Excel;

namespace QuanLyMuaCaFe
{
    public partial class frmHoaDonBanHang : Form
    {
        public frmHoaDonBanHang()
        {
            InitializeComponent();
            Load();
        }
        public void Load()
        {
            List<HDBanHang_DTO> DanhSachHD = HDBanHang_BUS.GetListHDBH();
            dataGridView1.DataSource = DanhSachHD;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            HDBanHang_DTO HDBH = new HDBanHang_DTO();
            HDBH.MaHoaDon = tbSearch.Text;
            List<HDBanHang_DTO> Search = HDBanHang_BUS.Search_HDBH(HDBH);
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            HDBanHang_DTO CTHD_DTO = new HDBanHang_DTO();
            CTHD_DTO.MaHoaDon = this.dataGridView1.CurrentRow.Cells[0].ToString();
            frmChiTietHDBH CTHD = new frmChiTietHDBH();
            CTHD.tbMaHD.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            CTHD.tbTenBan.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            CTHD.tbMaNV.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            CTHD.tbNgayLap.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            
            CTHD.ShowDialog();
        }

        private void frmHoaDonBanHang_Click(object sender, EventArgs e)
        {
            dataGridView1.Focus();
            tbSearch.Text = "Nhập Mã Hóa Đơn để tìm kiếm...";
            Load();
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            DataGridView drgv = new DataGridView();
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Wordnook|*.xls", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {

                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "Cà phê The Cold House";
                    ws.Cells[2, 1] = "Editor: Trần Đức Sơn";
                    //ws.Cells[3, 1] = string.Format("Doanh thu theo bàn số {0}", comboBox1.Text);
                    ws.Cells[3, 1] = string.Format("Hóa Đơn Bán Hàng");
                    ws.Cells[4, 1] = "Ngày Lập";
                    ws.Cells[4, 2] = "Mã Nhân Viên";
                    ws.Cells[4, 3] = "Tên Bàn";
                    ws.Cells[4, 4] = "Mã Bàn";
                    ws.Cells[4, 5] = "Mã Hóa Đơn";
                    //foreach (ListViewItem item in .Items)
                    //{
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            for (int k = 5; k ==5; k--)
                            {
                                ws.Cells[i + 5, k-j] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    }
                    wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                    MessageBox.Show("Impot Success!");
                }
            }
        }
    }
}
