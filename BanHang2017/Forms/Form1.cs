using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BanHang2017.Forms
{
    public partial class Form1 : Form
    {
        Classes.DataProcess dtBase = new Classes.DataProcess();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dtChatlieu = dtBase.SelectTable("Select * from tblChatLieu");
            dtVChatLieu.DataSource = dtChatlieu;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiểm tra mã đã có chưa?
            DataTable dtChatLieuKT = dtBase.SelectTable("Select * from tblChatLieu where MaChatLieu='" + txtMaCL.Text + "'");
            if(dtChatLieuKT.Rows.Count >0)
            {
                MessageBox.Show("Mã cl đã có, bạn nhập mã khác!");
                txtMaCL.Focus();
            }
            else
            {
                string sqlInsert = "insert into tblChatLieu values('" + txtMaCL.Text + "',N'" + txtTenCL.Text + "')";
                dtBase.UpdateData(sqlInsert);
                Form1_Load(sender, e);
            }
           
         }

        private void dtVChatLieu_Click(object sender, EventArgs e)
        {
            txtMaCL.Text = dtVChatLieu.CurrentRow.Cells[0].Value.ToString();
            txtTenCL.Text = dtVChatLieu.CurrentRow.Cells[1].Value.ToString();
            txtMaCL.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int i;
            string keyitem="",nameCL;
            for (i = 0; i < dtVChatLieu.Rows.Count -1;i++ )
            {
                keyitem = dtVChatLieu.Rows[i].Cells[0].Value.ToString();
                nameCL = dtVChatLieu.Rows[i].Cells[1].Value.ToString();
                dtBase.UpdateData("update tblChatLieu set TenChatLieu=N'" + nameCL  + "' where MaChatLieu='" + keyitem + "'");
            
            }
            dtVChatLieu.DataSource=dtBase.SelectTable("Select * from tblChatLieu");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtMaCL.Text=="")
            {
                MessageBox.Show("Bạn phải chọn chất liệu để xóa");
                return;
            }
            if(MessageBox.Show("Bạn có muốn xóa không?","TB",MessageBoxButtons.YesNo,MessageBoxIcon.Question )==DialogResult.Yes )
            {
                dtBase.UpdateData("delete tblChatLieu where MaChatLieu='"+txtMaCL.Text +"'");
                dtVChatLieu.DataSource = dtBase.SelectTable("Select * from tblChatLieu");
                txtMaCL.Text = "";
                txtTenCL.Text = "";
                txtMaCL.Enabled = true;
            }
        }
    }
}
