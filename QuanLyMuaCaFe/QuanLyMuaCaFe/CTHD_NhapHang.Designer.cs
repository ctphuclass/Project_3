namespace QuanLyMuaCaFe
{
    partial class CTHD_NhapHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTongTien = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.MaNL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenNL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DVT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.tbNgayLap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMaNCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaHDNhap = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbTongTien);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbNgayLap);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbMaNCC);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbMaHDNhap);
            this.groupBox2.Location = new System.Drawing.Point(12, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(659, 229);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(435, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "TongTien:";
            // 
            // tbTongTien
            // 
            this.tbTongTien.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbTongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTongTien.Enabled = false;
            this.tbTongTien.ForeColor = System.Drawing.Color.Red;
            this.tbTongTien.Location = new System.Drawing.Point(529, 43);
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.Size = new System.Drawing.Size(124, 13);
            this.tbTongTien.TabIndex = 32;
            this.tbTongTien.Text = "TT";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaNL,
            this.TenNL,
            this.SoLuong,
            this.DonGia,
            this.DVT});
            this.listView1.Location = new System.Drawing.Point(6, 81);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(648, 142);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // MaNL
            // 
            this.MaNL.Text = "Mã Nguyên Liệu";
            this.MaNL.Width = 100;
            // 
            // TenNL
            // 
            this.TenNL.Text = "Tên Nguyên Liệu";
            this.TenNL.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.Text = "Số Lượng";
            this.SoLuong.Width = 100;
            // 
            // DonGia
            // 
            this.DonGia.Text = "Đơn Giá";
            this.DonGia.Width = 144;
            // 
            // DVT
            // 
            this.DVT.Tag = "";
            this.DVT.Text = "Đơn Vị Tính";
            this.DVT.Width = 150;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Ngày Lập:";
            // 
            // tbNgayLap
            // 
            this.tbNgayLap.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbNgayLap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNgayLap.Enabled = false;
            this.tbNgayLap.ForeColor = System.Drawing.Color.Black;
            this.tbNgayLap.Location = new System.Drawing.Point(77, 42);
            this.tbNgayLap.Name = "tbNgayLap";
            this.tbNgayLap.Size = new System.Drawing.Size(147, 13);
            this.tbNgayLap.TabIndex = 30;
            this.tbNgayLap.Text = "NL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(224, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Mã Nhà Cung Cấp:";
            // 
            // tbMaNCC
            // 
            this.tbMaNCC.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbMaNCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMaNCC.Enabled = false;
            this.tbMaNCC.ForeColor = System.Drawing.Color.Black;
            this.tbMaNCC.Location = new System.Drawing.Point(344, 16);
            this.tbMaNCC.Name = "tbMaNCC";
            this.tbMaNCC.Size = new System.Drawing.Size(124, 13);
            this.tbMaNCC.TabIndex = 28;
            this.tbMaNCC.Text = "NV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mã Hóa Đơn Nhập:";
            // 
            // tbMaHDNhap
            // 
            this.tbMaHDNhap.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbMaHDNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMaHDNhap.Enabled = false;
            this.tbMaHDNhap.ForeColor = System.Drawing.Color.Black;
            this.tbMaHDNhap.Location = new System.Drawing.Point(128, 16);
            this.tbMaHDNhap.Multiline = true;
            this.tbMaHDNhap.Name = "tbMaHDNhap";
            this.tbMaHDNhap.Size = new System.Drawing.Size(96, 20);
            this.tbMaHDNhap.TabIndex = 24;
            this.tbMaHDNhap.Text = "HD";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 112);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(293, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "SĐT: 0934243332";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(98, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(500, 5);
            this.label4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(224, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "245 Đường Bùi Văn Ngữ,Q.12,Phường Hiệp Thành";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(209, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Tiết Nhập Hàng\r\n";
            // 
            // CTHD_NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(680, 378);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CTHD_NhapHang";
            this.Text = "CTHD_NhapHang";
            this.Load += new System.EventHandler(this.CTHD_NhapHang_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox tbTongTien;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader MaNL;
        private System.Windows.Forms.ColumnHeader TenNL;
        private System.Windows.Forms.ColumnHeader SoLuong;
        private System.Windows.Forms.ColumnHeader DonGia;
        private System.Windows.Forms.ColumnHeader DVT;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox tbNgayLap;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tbMaNCC;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbMaHDNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}