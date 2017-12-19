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
    public partial class frmDoanhThu : Form
    {
        public frmDoanhThu()
        {
            InitializeComponent();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if(DateTime.Parse(dtNgayDau.Text) > DateTime.Parse(dtNgayCuoi.Text))
            {
                MessageBox.Show("Thời gian không hợp lệ! Xin vui lòng kiểm tra lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DoanhThu_DTO DoanhThu = new DoanhThu_DTO();
            DoanhThu.NgayDau =DateTime.Parse(dtNgayDau.Text);
            DoanhThu.NgayCuoi = DateTime.Parse(dtNgayCuoi.Text);
            DoanhThu.Error = "Không có Doanh Thu trong khoảng thời gian này";

            List<DoanhThu_DTO> DT = DoanhThu_BUS.List_DoanhThu(DoanhThu);
            dataGridView1.DataSource = DT;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            if (DT.Count == 0)
            {
                MessageBox.Show(DoanhThu.Error,"Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            List<DoanhThu_DTO> DT1 = DoanhThu_BUS.TongDoanhThu(DoanhThu);
            if(DT1.Count == 0)
            {
                tbTongDoanhThu.Text = "0";
            }
            else
            { 
                tbTongDoanhThu.Text = DT1[0].TongDoanhThu.ToString();
            }
        }
        private void Printfile(DataGridView dgrv)
        {

            string filename = "";
            SaveFileDialog Save = new SaveFileDialog();
            Save.Title = "In Thống Kê Doanh Thu";
            Save.Filter = "Text File (.txt)|*.txt";
            if (Save.ShowDialog() == DialogResult.OK)
            {
                filename = Save.FileName.ToString();
                if (filename != "")
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(filename))
                    {
                        sw.WriteLine("Thông tin chi tiết doanh thu từ ngày:{0} đến ngày: {1}", dtNgayDau.Text, dtNgayCuoi.Text);
                        sw.Write("\t" + "Mã hóa đơn" + "\t" + "Mã Bàn" + "\t" + "\t" + "Thành Tiền" + "\t");
                        sw.WriteLine("");
                        for (int i = 0; i < dgrv.Rows.Count; i++)
                        {
                            for (int j = 3; j < dgrv.Columns.Count - 1; j++)
                            {
                                sw.Write("\t" + dgrv.Rows[i].Cells[j].Value.ToString() + "\t");
                            }
                            sw.WriteLine("");
                        }
                        sw.WriteLine("Tong tien la: {0}", tbTongDoanhThu.Text);
                    }
                }
            }
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            DoanhThu_DTO DoanhThu = new DoanhThu_DTO();
            DoanhThu.NgayDau = DateTime.Parse(dtNgayDau.Text);
            DoanhThu.NgayCuoi = DateTime.Parse(dtNgayCuoi.Text);
            List<DoanhThu_DTO> DT1 = DoanhThu_BUS.TongDoanhThu(DoanhThu);
            if (DT1.Count == 0)
            {
                MessageBox.Show("Không có báo cáo Doanh Thu để in ra!Vui lòng kiểm tra lại trước khi in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
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
                    ws.Cells[3, 1] = string.Format("Tổng doanh thu là: {0} VND", tbTongDoanhThu.Text);
                    ws.Cells[4, 3] = "Mã Hóa Đơn";
                    ws.Cells[4, 4] = "Mã Bàn";
                    ws.Cells[4, 5] = "Thành Tiền";

                    int z = 5;
                    //foreach (ListViewItem item in .Items)
                    //{
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 5; j < dataGridView1.Columns.Count-1; j++)
                        {
                            for(int k = 2; k >= 0; k--)
                            {
                                ws.Cells[i + 5, j-k] = dataGridView1.Rows[i].Cells[j].Value.ToString();
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
