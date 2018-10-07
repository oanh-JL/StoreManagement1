using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BanHang2017.Forms
{
    public partial class frmHangHoa : Form
    {
        Classes.DataProcess dtBase = new Classes.DataProcess();
        string strAnh = "";
        public frmHangHoa()
        {
            InitializeComponent();
            cboChatLieu.DataSource = dtBase.SelectTable("Select * from tblChatLieu");
            cboChatLieu.DisplayMember = "Tenchatlieu";
            cboChatLieu.ValueMember = "MaChatLieu";
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            dgvHang.DataSource = dtBase.SelectTable("Select * from tblHang");
        }

        private void dgvHang_Click(object sender, EventArgs e)
        {
            txtMaHang.Text = dgvHang.CurrentRow.Cells[0].Value.ToString();
            txtTenHang.Text = dgvHang.CurrentRow.Cells[1].Value.ToString();
            picAnh.Image = Image.FromFile("Image\\Hang\\" + dgvHang.CurrentRow.Cells["Anh"].Value.ToString());
            cboChatLieu.SelectedValue = dgvHang.CurrentRow.Cells["MaChatLieu"].Value.ToString();
        }

        private void btnAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog opAnh = new OpenFileDialog();
            opAnh.ShowDialog();
            strAnh = opAnh.FileName;
            picAnh.Image = Image.FromFile(strAnh);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            string []bufferA=strAnh.Split('\\');
            strAnh = bufferA[bufferA.Length - 1];
            dtBase.UpdateData("insert into tblHang values('"+txtMaHang.Text +
                "',N'"+txtTenHang.Text +"','"+cboChatLieu.SelectedValue.ToString()+
                "',"+ Convert.ToInt16( txtSoLuong.Text) +","+Convert.ToDouble(txtDonGiaNhap.Text)+","+txtDonGiaBan.Text +",'"+strAnh +"','"+txtGhiChu.Text +"')");
            frmHangHoa_Load(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
