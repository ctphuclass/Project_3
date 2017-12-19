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
    public partial class frmHoaDonNhapHang : Form
    {
        public frmHoaDonNhapHang()
        {
            InitializeComponent();
            Load();
            List<HoaDonNhapHang_DTO> List = HoaDonNhapHang_BUS.TinhTongTien();
            tbTongTien.Text = List[0].TongTien.ToString();
            dataGridView1.Columns[0].Visible = false;
        }
        public void Load()
        {
            List<HoaDonNhapHang_DTO> Danhsach = HoaDonNhapHang_BUS.GetListHDNH();
            dataGridView1.DataSource = Danhsach;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            HoaDonNhapHang_DTO HDNH = new HoaDonNhapHang_DTO();
            HDNH.MaHoaDonNhap = tbSearch.Text;
            List<HoaDonNhapHang_DTO> Search = HoaDonNhapHang_BUS.Search_HDBH(HDNH);
            dataGridView1.DataSource = Search;
            if (tbSearch.Text == "")
            {
                Load();
            }
        }

        private void tbSearch_Click(object sender, EventArgs e)
        {
            tbSearch.Clear();
            Load();
        }

        private void frmHoaDonNhapHang_Click(object sender, EventArgs e)
        {
            dataGridView1.Focus();
            tbSearch.Text = "Nhập Mã Hóa Đơn Hoặc Nhập Mã Nhà Cung Cấp Để tìm Kiếm...";
            Load();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            HoaDonNhapHang_DTO HDNH = new HoaDonNhapHang_DTO();
            HDNH.MaHoaDonNhap = this.dataGridView1.CurrentRow.Cells[0].ToString();

            CTHD_NhapHang frmCTHD = new CTHD_NhapHang();
            //frmCTHD.tbMaHDNhap.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmCTHD.tbMaNCC.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmCTHD.tbNgayLap.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmCTHD.ShowDialog();
        }

        private void frmHoaDonNhapHang_Load(object sender, EventArgs e)
        {

            
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
                    ws.Cells[3, 1] = string.Format("Hóa Đơn Nhập Hàng");
                    ws.Cells[4, 2] = "Ngày Nhập";
                    ws.Cells[4, 3] = "Mã Nhà Cung Cấp";
                    ws.Cells[4, 4] = "Mã Hóa Đơn Nhập";
                    ws.Cells[10, 1] = string.Format("Tổng doanh thu là: {0} VND", tbTongTien.Text);
                    //foreach (ListViewItem item in .Items)
                    //{
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 1; j < dataGridView1.Columns.Count; j++)
                        {
                            for (int k = 5; k == 5; k--)
                            {
                                ws.Cells[i + 5, k - j] = dataGridView1.Rows[i].Cells[j].Value.ToString();
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
