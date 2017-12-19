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
            DoanhThu_DTO DoanhThu = new DoanhThu_DTO();
            DoanhThu.NgayDau = DateTime.Parse(dtNgayDau.Text);
            DoanhThu.NgayCuoi = DateTime.Parse(dtNgayCuoi.Text);
            List<DoanhThu_DTO> DT1 = DoanhThu_BUS.TongDoanhThu(DoanhThu);
            if (DT1.Count == 0)
            {
                MessageBox.Show("Không có báo cáo Doanh Thu để in ra!Vui lòng kiểm tra lại trước khi in!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            string filename = "";
            SaveFileDialog Save = new SaveFileDialog();
            Save.Title = "In Thống Kê Doanh Thu";
            Save.Filter = "Text File (.xlsx)|*.xlsx";
            if (Save.ShowDialog() == DialogResult.OK)
            {
                filename = Save.FileName.ToString();
                if (filename != "")
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(filename))
                    {
                        sw.WriteLine("Thông tin chi tiết doanh thu từ ngày:{0} đến ngày: {1}", dtNgayDau.Text, dtNgayCuoi.Text);
                        sw.Write("\t"+"Mã hóa đơn"+"\t"+"Mã Bàn"+"\t"+"\t"+"Thành Tiền"+"\t");
                        sw.WriteLine("");
                       for(int i = 0;i<dgrv.Rows.Count;i++)
                        {
                            for (int j=3; j < dgrv.Columns.Count-1; j++)
                            {
                                    sw.Write("\t"+ dgrv.Rows[i].Cells[j].Value.ToString() + "\t");
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
            Printfile(dataGridView1);
        }
    }
}
