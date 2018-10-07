namespace BanHang2017.Forms
{
    partial class frmInNhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTuoi1 = new System.Windows.Forms.TextBox();
            this.txtTuoi2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.btnIn = new System.Windows.Forms.Button();
            this.crvNhanVien = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIn);
            this.groupBox1.Controls.Add(this.rdoNu);
            this.groupBox1.Controls.Add(this.rdoNam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTuoi2);
            this.groupBox1.Controls.Add(this.txtTuoi1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(97, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tuổi từ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến:";
            // 
            // txtTuoi1
            // 
            this.txtTuoi1.Location = new System.Drawing.Point(79, 20);
            this.txtTuoi1.Name = "txtTuoi1";
            this.txtTuoi1.Size = new System.Drawing.Size(101, 20);
            this.txtTuoi1.TabIndex = 2;
            // 
            // txtTuoi2
            // 
            this.txtTuoi2.Location = new System.Drawing.Point(275, 21);
            this.txtTuoi2.Name = "txtTuoi2";
            this.txtTuoi2.Size = new System.Drawing.Size(101, 20);
            this.txtTuoi2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giới tính";
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(103, 110);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(47, 17);
            this.rdoNam.TabIndex = 5;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(261, 110);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(39, 17);
            this.rdoNu.TabIndex = 6;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(403, 121);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(64, 27);
            this.btnIn.TabIndex = 7;
            this.btnIn.Text = "In ds";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // crvNhanVien
            // 
            this.crvNhanVien.ActiveViewIndex = -1;
            this.crvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvNhanVien.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvNhanVien.Location = new System.Drawing.Point(22, 192);
            this.crvNhanVien.Name = "crvNhanVien";
            this.crvNhanVien.Size = new System.Drawing.Size(898, 470);
            this.crvNhanVien.TabIndex = 1;
            // 
            // frmInNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 674);
            this.Controls.Add(this.crvNhanVien);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmInNhanVien";
            this.Text = "frmInNhanVien";
            this.Load += new System.EventHandler(this.frmInNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTuoi2;
        private System.Windows.Forms.TextBox txtTuoi1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvNhanVien;
    }
}