namespace BanHang2017.Forms
{
    partial class frmHoaDon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.txtDiaChiKhach = new System.Windows.Forms.TextBox();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.mtxtNgayBan = new System.Windows.Forms.MaskedTextBox();
            this.cboMaKhach = new System.Windows.Forms.ComboBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvChiTietHang = new System.Windows.Forms.DataGridView();
            this.cboMaHang = new System.Windows.Forms.ComboBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.btnLuuHD = new System.Windows.Forms.Button();
            this.btnHuyHD = new System.Windows.Forms.Button();
            this.btnInHD = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.cboMaHD = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoDT);
            this.groupBox1.Controls.Add(this.txtDiaChiKhach);
            this.groupBox1.Controls.Add(this.txtTenKhach);
            this.groupBox1.Controls.Add(this.mtxtNgayBan);
            this.groupBox1.Controls.Add(this.cboMaKhach);
            this.groupBox1.Controls.Add(this.cboMaNV);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(389, 147);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(165, 20);
            this.txtSoDT.TabIndex = 15;
            // 
            // txtDiaChiKhach
            // 
            this.txtDiaChiKhach.Location = new System.Drawing.Point(387, 89);
            this.txtDiaChiKhach.Multiline = true;
            this.txtDiaChiKhach.Name = "txtDiaChiKhach";
            this.txtDiaChiKhach.Size = new System.Drawing.Size(167, 50);
            this.txtDiaChiKhach.TabIndex = 14;
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(387, 57);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(167, 20);
            this.txtTenKhach.TabIndex = 13;
            // 
            // mtxtNgayBan
            // 
            this.mtxtNgayBan.Location = new System.Drawing.Point(81, 49);
            this.mtxtNgayBan.Mask = "00/00/0000";
            this.mtxtNgayBan.Name = "mtxtNgayBan";
            this.mtxtNgayBan.Size = new System.Drawing.Size(184, 20);
            this.mtxtNgayBan.TabIndex = 12;
            this.mtxtNgayBan.ValidatingType = typeof(System.DateTime);
            // 
            // cboMaKhach
            // 
            this.cboMaKhach.FormattingEnabled = true;
            this.cboMaKhach.Location = new System.Drawing.Point(384, 16);
            this.cboMaKhach.Name = "cboMaKhach";
            this.cboMaKhach.Size = new System.Drawing.Size(171, 21);
            this.cboMaKhach.TabIndex = 11;
            this.cboMaKhach.SelectedValueChanged += new System.EventHandler(this.cboMaKhach_SelectedValueChanged);
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(76, 81);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(190, 21);
            this.cboMaNV.TabIndex = 10;
            this.cboMaNV.SelectedValueChanged += new System.EventHandler(this.cboMaNV_SelectedValueChanged);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(74, 121);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(193, 20);
            this.txtTenNV.TabIndex = 9;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(84, 16);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(184, 20);
            this.txtMaHD.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(317, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Điện thoại:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên khách:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã khách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên NV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã NV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày bán:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvChiTietHang);
            this.groupBox2.Controls.Add(this.cboMaHang);
            this.groupBox2.Controls.Add(this.txtDonGia);
            this.groupBox2.Controls.Add(this.txtTenHang);
            this.groupBox2.Controls.Add(this.txtThanhTien);
            this.groupBox2.Controls.Add(this.txtGiamGia);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(15, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(569, 265);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin các mặt hàng";
            // 
            // dgvChiTietHang
            // 
            this.dgvChiTietHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHang.Location = new System.Drawing.Point(27, 96);
            this.dgvChiTietHang.Name = "dgvChiTietHang";
            this.dgvChiTietHang.Size = new System.Drawing.Size(526, 146);
            this.dgvChiTietHang.TabIndex = 12;
            this.dgvChiTietHang.DoubleClick += new System.EventHandler(this.dgvChiTietHang_DoubleClick);
            // 
            // cboMaHang
            // 
            this.cboMaHang.FormattingEnabled = true;
            this.cboMaHang.Location = new System.Drawing.Point(66, 26);
            this.cboMaHang.Name = "cboMaHang";
            this.cboMaHang.Size = new System.Drawing.Size(117, 21);
            this.cboMaHang.TabIndex = 11;
            this.cboMaHang.SelectedValueChanged += new System.EventHandler(this.cboMaHang_SelectedValueChanged);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(454, 17);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(108, 20);
            this.txtDonGia.TabIndex = 10;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(245, 20);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(134, 20);
            this.txtTenHang.TabIndex = 9;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(464, 56);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(99, 20);
            this.txtThanhTien.TabIndex = 8;
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(238, 62);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(148, 20);
            this.txtGiamGia.TabIndex = 7;
            this.txtGiamGia.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(67, 61);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(103, 20);
            this.txtSoLuong.TabIndex = 6;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(402, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Thành tiền";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(182, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Giảm giá:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Số lượng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(401, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Đơn giá";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(179, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tên hàng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã hàng";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(81, 510);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(274, 20);
            this.txtTongTien.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 515);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Tổng tiền:";
            // 
            // btnThemHD
            // 
            this.btnThemHD.Location = new System.Drawing.Point(29, 549);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(109, 39);
            this.btnThemHD.TabIndex = 15;
            this.btnThemHD.Text = "Thêm HĐ";
            this.btnThemHD.UseVisualStyleBackColor = true;
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // btnLuuHD
            // 
            this.btnLuuHD.Location = new System.Drawing.Point(149, 549);
            this.btnLuuHD.Name = "btnLuuHD";
            this.btnLuuHD.Size = new System.Drawing.Size(101, 39);
            this.btnLuuHD.TabIndex = 16;
            this.btnLuuHD.Text = "Lưu hóa đơn";
            this.btnLuuHD.UseVisualStyleBackColor = true;
            this.btnLuuHD.Click += new System.EventHandler(this.btnLuuHD_Click);
            // 
            // btnHuyHD
            // 
            this.btnHuyHD.Location = new System.Drawing.Point(267, 548);
            this.btnHuyHD.Name = "btnHuyHD";
            this.btnHuyHD.Size = new System.Drawing.Size(88, 40);
            this.btnHuyHD.TabIndex = 17;
            this.btnHuyHD.Text = "Hủy HĐ";
            this.btnHuyHD.UseVisualStyleBackColor = true;
            this.btnHuyHD.Click += new System.EventHandler(this.btnHuyHD_Click);
            // 
            // btnInHD
            // 
            this.btnInHD.Location = new System.Drawing.Point(397, 546);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(99, 41);
            this.btnInHD.TabIndex = 18;
            this.btnInHD.Text = "In hóa đơn";
            this.btnInHD.UseVisualStyleBackColor = true;
            this.btnInHD.Click += new System.EventHandler(this.btnInHD_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(255, 600);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(119, 33);
            this.btnTim.TabIndex = 19;
            this.btnTim.Text = "Tìm HĐ";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // cboMaHD
            // 
            this.cboMaHD.FormattingEnabled = true;
            this.cboMaHD.Location = new System.Drawing.Point(29, 607);
            this.cboMaHD.Name = "cboMaHD";
            this.cboMaHD.Size = new System.Drawing.Size(203, 21);
            this.cboMaHD.TabIndex = 20;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 638);
            this.Controls.Add(this.cboMaHD);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnInHD);
            this.Controls.Add(this.btnHuyHD);
            this.Controls.Add(this.btnLuuHD);
            this.Controls.Add(this.btnThemHD);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.TextBox txtDiaChiKhach;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.MaskedTextBox mtxtNgayBan;
        private System.Windows.Forms.ComboBox cboMaKhach;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvChiTietHang;
        private System.Windows.Forms.ComboBox cboMaHang;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.Button btnLuuHD;
        private System.Windows.Forms.Button btnHuyHD;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ComboBox cboMaHD;
    }
}