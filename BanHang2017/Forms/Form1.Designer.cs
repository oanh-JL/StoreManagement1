namespace BanHang2017.Forms
{
    partial class Form1
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
            this.dtVChatLieu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaCL = new System.Windows.Forms.TextBox();
            this.txtTenCL = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtVChatLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // dtVChatLieu
            // 
            this.dtVChatLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtVChatLieu.Location = new System.Drawing.Point(28, 175);
            this.dtVChatLieu.Name = "dtVChatLieu";
            this.dtVChatLieu.Size = new System.Drawing.Size(461, 193);
            this.dtVChatLieu.TabIndex = 0;
            this.dtVChatLieu.Click += new System.EventHandler(this.dtVChatLieu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã chất liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên CL:";
            // 
            // txtMaCL
            // 
            this.txtMaCL.Location = new System.Drawing.Point(89, 12);
            this.txtMaCL.Name = "txtMaCL";
            this.txtMaCL.Size = new System.Drawing.Size(213, 20);
            this.txtMaCL.TabIndex = 3;
            // 
            // txtTenCL
            // 
            this.txtTenCL.Location = new System.Drawing.Point(89, 57);
            this.txtTenCL.Name = "txtTenCL";
            this.txtTenCL.Size = new System.Drawing.Size(212, 20);
            this.txtTenCL.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(26, 105);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 41);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(179, 104);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 41);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(342, 101);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 44);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 380);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenCL);
            this.Controls.Add(this.txtMaCL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtVChatLieu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtVChatLieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtVChatLieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaCL;
        private System.Windows.Forms.TextBox txtTenCL;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
    }
}

