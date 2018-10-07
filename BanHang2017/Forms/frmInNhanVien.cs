using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace BanHang2017.Forms
{
    public partial class frmInNhanVien : Form
    {
        Classes.DataProcess dtBase = new Classes.DataProcess();
        public frmInNhanVien()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            int namHT = DateTime.Now.Year;
            int tuoibt, tuoikt;
            string sql = "Select * from tblNhanVien where MaNhanVien is not null";
            if(txtTuoi1.Text !="")
            {
                tuoibt = Convert.ToInt16(txtTuoi1.Text);
                sql = sql + " and year(ngaysinh) <= "+ (namHT - tuoibt).ToString() ;

            }
            if (txtTuoi2.Text !="")
            {
                tuoikt = Convert.ToInt16(txtTuoi2.Text);
                sql = sql + " and  year(ngaysinh) >= "+ (tuoikt  - namHT ).ToString();
            }
            if(rdoNam.Checked == true )
            {
                sql = sql + " and GioiTinh='Nam'";
            }
            if (rdoNu.Checked == true)
                sql = sql + " and Gioitinh='Nữ'";
            DataTable dtNV = dtBase.SelectTable(sql);
            dtNhanVien dtsNV = new dtNhanVien();
            DataRow dtNew;
            string nsinh;
            string [] ns;
            for(int i=0; i< dtNV.Rows.Count ;i++)
            {
                dtNew = dtsNV.Tables["dataNhanVien"].NewRow();
                dtNew["STT"] = (i + 1).ToString();
                dtNew["MaNV"] = dtNV.Rows[i]["MaNhanVien"].ToString();
                dtNew["TenNV"] = dtNV.Rows[i]["TenNhanVien"].ToString();
                dtNew["GioiTinh"] = dtNV.Rows[i]["GioiTinh"].ToString();
                nsinh=dtNV.Rows[i]["NgaySinh"].ToString();
                ns=nsinh.Split (' ');
                dtNew["NgaySinh"] = ns[0];
                dtNew["DienThoai"] = dtNV.Rows[i]["DienThoai"].ToString();
                dtsNV.Tables["dataNhanVien"].Rows.Add(dtNew);
            }
            string fileReport = System.IO.Directory.GetCurrentDirectory().ToString() + "//Reports//reportNhanVien.rpt";
            ReportDocument rptDocument = new ReportDocument();
            rptDocument.Load(fileReport);
            rptDocument.SetDataSource(dtsNV);
            crvNhanVien.ReportSource = rptDocument;



        }

        private void frmInNhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
