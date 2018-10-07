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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void mnuChatLieu_Click(object sender, EventArgs e)
        {
            Forms.Form1 frmCL = new Form1();
            frmCL.ShowDialog();
        }

        private void mnuHang_Click(object sender, EventArgs e)
        {
            Forms.frmHangHoa frmHang = new frmHangHoa();
            frmHang.ShowDialog();
        }

        private void mnuHoaDonBan_Click(object sender, EventArgs e)
        {
            Forms.frmHoaDon  HoaDon = new frmHoaDon();
            HoaDon.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmInNhanVien frmNV = new frmInNhanVien();
            frmNV.ShowDialog();
        }
    }
}
