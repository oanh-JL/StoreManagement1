using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BanHang2017.Forms
{
    public partial class frmHoaDon : Form
    {
        Classes.DataProcess dtBase = new Classes.DataProcess();
        Classes.CommonClass dtClass = new Classes.CommonClass();
        public frmHoaDon()
        {
            InitializeComponent();
            cboMaNV.DataSource = dtBase.SelectTable("Select * from tblNhanVien");
            cboMaNV.DisplayMember = "Manhanvien";
            cboMaNV.ValueMember = "Manhanvien";

            cboMaKhach.DataSource = dtBase.SelectTable("Select * from tblKhach");
            cboMaKhach.DisplayMember = "Makhach";
            cboMaKhach.ValueMember = "Makhach";

            cboMaHang.DataSource = dtBase.SelectTable("Select * from tblHang");
            cboMaHang.DisplayMember = "maHang";
            cboMaHang.ValueMember = "mahang";

            cboMaHD.DataSource = dtBase.SelectTable("Select * from tblHDBan");
            cboMaHD.DisplayMember = "maHDBan";
            cboMaHD.ValueMember = "maHDBan";
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void cboMaHang_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtHang = dtBase.SelectTable("Select * from tblHang where MaHang='" + cboMaHang.SelectedValue.ToString() + "'");
                txtTenHang.Text = dtHang.Rows[0]["TenHang"].ToString();
                txtDonGia.Text = dtHang.Rows[0]["DonGiaBan"].ToString();
            }
            catch { }
           
        }

        private void cboMaNV_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtNhanVien = dtBase.SelectTable("Select * from tblNhanVien where MaNhanVien='" + cboMaNV.SelectedValue.ToString() + "'");
                txtTenNV.Text = dtNhanVien.Rows[0]["tennhanvien"].ToString();
            }
            catch { }
        }

        private void cboMaKhach_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtKhach=dtBase.SelectTable("Select * from tblKhach where Makhach='"+cboMaKhach.SelectedValue.ToString()+"'");
                txtTenKhach.Text = dtKhach.Rows[0]["tenkhach"].ToString();
                txtDiaChiKhach.Text = dtKhach.Rows[0]["Diachi"].ToString();
                txtSoDT.Text = dtKhach.Rows[0]["Dienthoai"].ToString();

            }
            catch { }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DataTable dtHoaDon=dtBase.SelectTable("Select * from tblHDBan where MaHDBan='"+ 
                cboMaHD.SelectedValue.ToString()+"'");
            txtMaHD.Text = dtHoaDon.Rows[0]["maHDBan"].ToString();
            mtxtNgayBan.Text = dtHoaDon.Rows[0]["ngayban"].ToString();
            cboMaNV.SelectedValue = dtHoaDon.Rows[0]["NhanVien"].ToString();
            cboMaKhach.SelectedValue = dtHoaDon.Rows[0]["makhach"].ToString();
            txtTongTien.Text = dtHoaDon.Rows[0]["TongTien"].ToString();
            DataTable dtChiTietHD = dtBase.SelectTable("Select tblChiTietHDBan.MaHang," +
                "TenHang,tblChiTietHDBan.SoLuong, DonGiaBan,GiamGia,ThanhTien " +
                " from tblChiTietHDBan inner join tblHang on tblChiTietHDBan.MaHang=" +
                " tblHang.MaHang where MaHDBan='" + cboMaHD.SelectedValue.ToString() +
                "'");
                dgvChiTietHang.DataSource = dtChiTietHD;
            
            
        }

        private void btnHuyHD_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có thực sự muốn hủy hóa đơn này không?","Hủy HĐ",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question )==DialogResult.Yes )
            {
                int i, sluongcu, soluongmoi;
                DataTable dtHang;
                DataTable dtChiTietHDBan = dtBase.SelectTable("Select * from tblChiTietHDBan"+
                    " where MaHDBan='" + txtMaHD.Text + "'");
                if(dtChiTietHDBan.Rows.Count>0)
                {
                    for(i=0;i<dtChiTietHDBan.Rows.Count;i++)
                    {
                        dtHang = dtBase.SelectTable("Select SoLuong from tblHang where MaHang='" + 
                            dtChiTietHDBan.Rows[i]["maHang"].ToString() + "'");
                        sluongcu = Convert.ToInt32(dtHang.Rows[0]["SoLuong"].ToString());
                        soluongmoi = sluongcu + Convert.ToInt32(dtChiTietHDBan.Rows[i]["soluong"]);
                        dtBase.UpdateData("update tblHang set SoLuong=" + soluongmoi + 
                            " where MaHang='" + dtChiTietHDBan.Rows[i]["maHang"] .ToString()+ "'");
                    }
                }
                dtBase.UpdateData("Delete tblHDBan where MaHDBan='"+txtMaHD.Text +"'");
                cboMaHD.DataSource = null;
                cboMaHD.DataSource = dtBase.SelectTable("Select MaHDBan from tblHDBan");
                cboMaHD.DisplayMember = "MaHDBan";
                cboMaHD.ValueMember = "MaHDBan";
            }
        }

        private void dgvChiTietHang_DoubleClick(object sender, EventArgs e)
        {
            if(MessageBox.Show ("Bạn có muốn xóa hàng khỏi đơn hàng không?","TB",MessageBoxButtons.YesNo,MessageBoxIcon.Question )==
                DialogResult.Yes )
            { //Cập nhật số lượng hàng
                DataTable dtHang = dtBase.SelectTable("Select SoLuong from tblHang where MaHang='" +
                            dgvChiTietHang.CurrentRow.Cells[0].Value.ToString() + "'");
                int sluongcu = Convert.ToInt32(dtHang.Rows[0]["SoLuong"].ToString());
                int soluongmoi = sluongcu + Convert.ToInt32(dgvChiTietHang.CurrentRow.Cells[2].Value.ToString());
                dtBase.UpdateData("update tblHang set SoLuong=" + soluongmoi +
                    " where MaHang='" + dgvChiTietHang.CurrentRow.Cells[0].Value.ToString() + "'");
                //Cập nhật lại tổng tiền của HĐ
                DataTable dtHDBan = dtBase.SelectTable("Select TongTien from tblHDBan where MaHDBan='" + 
                    txtMaHD.Text + "'");
                int Tongtien = Convert.ToInt32(dtHDBan.Rows[0]["TongTien"].ToString()) - 
                    Convert.ToInt32(dgvChiTietHang.CurrentRow.Cells[5].Value.ToString());
                dtBase.UpdateData("update tblHDBan set TongTien=" + Tongtien + " where MaHDBan='" +
                    txtMaHD.Text + "'");
                txtTongTien.Text = Tongtien.ToString();
      
                dtBase.UpdateData("Delete tblChiTietHDBan where MaHDBan='"+txtMaHD.Text +"' and MaHang='"+
                    dgvChiTietHang.CurrentRow.Cells[0].Value.ToString()+"'");
                DataTable dtChiTietHD = dtBase.SelectTable("Select tblChiTietHDBan.MaHang," +
                "TenHang,tblChiTietHDBan.SoLuong, DonGiaBan,GiamGia,ThanhTien " +
                " from tblChiTietHDBan inner join tblHang on tblChiTietHDBan.MaHang=" +
                " tblHang.MaHang where MaHDBan='" + cboMaHD.SelectedValue.ToString() +
                "'");
                dgvChiTietHang.DataSource = dtChiTietHD;
              
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            int soluong,dongia;
            double  thanhtien,giamgia;
            if (txtSoLuong.Text.Trim() == "")
                soluong = 0;
            else
                soluong = Convert.ToInt16(txtSoLuong.Text.Trim());
            if (txtGiamGia.Text.Trim() == "")
                giamgia = 0;
            else
                giamgia = Convert.ToDouble(txtGiamGia.Text.Trim())/100;
            dongia = Convert.ToInt32(txtDonGia.Text.Trim());
            thanhtien = soluong * dongia * (1 - giamgia);
            txtThanhTien.Text = thanhtien.ToString();


                
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
             DataTable dtHD=new DataTable();
            string maHD;
            do{
               maHD = dtClass.SinhMa("HDB" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString());
               dtHD=dtBase.SelectTable("Select * from tblHDBan where MaHDBan='"+maHD +"'");
                
            }
            while(dtHD.Rows.Count>0);
            txtMaHD.Text=maHD;           
            mtxtNgayBan.Text = DateTime.Now.Date.ToString();
        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            int tongtien,soluongcu,soluongmoi;
            DateTime dtNgayBan = Convert.ToDateTime( mtxtNgayBan.Text);
            DataTable dtHDBan = dtBase.SelectTable("Select * from tblHDBan where MaHDBan='" + txtMaHD.Text + "'");
            //Kiểm tra trường hợp hóa đơn chưa có
            if(dtHDBan.Rows.Count ==0)
            {
                tongtien = Convert.ToInt32(txtThanhTien.Text);
                dtBase.UpdateData("insert into tblHDBan values('"+txtMaHD.Text +"','"+cboMaNV.SelectedValue.ToString ()+"','"+ String.Format("{0:MM/dd/yyyy}", dtNgayBan) +"','"+cboMaKhach.SelectedValue.ToString()+"',"+tongtien +")");
            }
            else //Đã có HD
            {
                //Kiểm tra số lượng còn không
                DataTable dtHang = dtBase.SelectTable("Select SoLuong from tblHang where MaHang='" +
                    cboMaHang.SelectedValue.ToString() + "'");
                soluongcu = Convert.ToInt32(dtHang.Rows[0]["SoLuong"]);
                if (soluongcu < Convert.ToInt32(txtSoLuong.Text))
                {
                    MessageBox.Show("Hàng " + txtTenHang.Text + " chỉ còn " + soluongcu.ToString());
                }
                else
                {
                    soluongmoi = soluongcu - Convert.ToInt32(txtSoLuong.Text);
                    //Kiểm tra đã có chi tiết chưa?
                    DataTable dtChiTietHD = dtBase.SelectTable("Select * from tblChiTietHDBan where MaHDBan='" +
                        txtMaHD.Text + "' and MaHang ='" + cboMaHang.SelectedValue.ToString() + "'");
                    if (dtChiTietHD.Rows.Count == 0)
                    //Thêm chi tiết HD
                    {
                        dtBase.UpdateData("insert into tblChiTietHDBan values('" + txtMaHD.Text + "','" + 
                            cboMaHang.SelectedValue.ToString() + "'," + Convert.ToInt32(txtSoLuong.Text) + "," +
                            Convert.ToInt32(txtGiamGia.Text) + "," + Convert.ToInt32(txtThanhTien.Text) + ")");

                    }
                    else
                    {
                        int slChiTiet = Convert.ToInt32(dtChiTietHD.Rows[0]["Soluong"]) + Convert.ToInt32(txtSoLuong.Text);
                        dtBase.UpdateData("Update tblChiTietHDBan set Soluong=" + Convert.ToInt32(slChiTiet) + ", Thanhtien=" + 
                            (Convert.ToInt32(dtChiTietHD.Rows[0]["ThanhTien"]) + Convert.ToInt32(txtThanhTien.Text)) + 
                            " where MaHDBan='" + txtMaHD.Text + "' and MaHang='" + cboMaHang.SelectedValue.ToString() + "'");
                    }
                    //Cap nhat so luong hang
                    dtBase.UpdateData("update tblHang set SoLuong=" + soluongmoi + " where MaHang='" + 
                        cboMaHang.SelectedValue.ToString() + "'");
                }
                tongtien = Convert.ToInt32(dtHDBan.Rows[0]["Tongtien"]) + Convert.ToInt32(txtThanhTien.Text);
                txtTongTien.Text = tongtien.ToString();
                dtBase.UpdateData("update tblHDBan set TongTien=" + tongtien + " where MaHDBan='" + txtMaHD.Text + "'");

            }
            
            DataTable dtCT = dtBase.SelectTable("Select tblChiTietHDBan.MaHang," +
                 "TenHang,tblChiTietHDBan.SoLuong, DonGiaBan,GiamGia,ThanhTien " +
                 " from tblChiTietHDBan inner join tblHang on tblChiTietHDBan.MaHang=" +
                 " tblHang.MaHang where MaHDBan='" + txtMaHD.Text  +
                 "'");
            dgvChiTietHang.DataSource = dtCT ;
             
            
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            Excel.Range exRang = (Excel.Range)exSheet.Cells[1, 1];
            exRang.Range["A1:A2"].Font.Bold = true;
            exRang.Range["A1:A2"].Font.Size = 14;
            exRang.Range["A1"].Value = "Địa chỉ: Ngõ 22 Cầu Giấy Hà Nội";
            exRang.Range["A2"].Value = "Điện thoại: 098786765";

            exRang.Range["C4"].Font.Bold = true;
            exRang.Range["C4"].Font.Size = 20;
            exRang.Range["C4"].Font.Color = Color.Red;
            exRang.Range["c4"].Value = "HÓA ĐƠN BÁN";

          
            exRang.Range["A6"].Font.Size = 14;
            exRang.Range["A6"].Value = "Khách hàng:" + txtTenKhach.Text ;

            exRang.Range["A8:G8"].Font.Bold = true;
            exRang.Range["A8"].Value = "STT";
            exRang.Range["B8"].Value = "Mã hàng";

            exRang.Range["C8"].Value = "Tên hàng";

            exRang.Range["D8"].Value = "Số lượng";

            exRang.Range["E8"].Value = "Đơn giá";

            exRang.Range["F8"].Value = "Giảm giá";
            exRang.Range["G8"].Value = "Thành tiền";

            int row = 8;
            for(int i=0;i<dgvChiTietHang.Rows.Count-1 ;i++)
            {
                row=row+1;
                exRang.Range["A" + row.ToString()].Value = (i+1).ToString();
                exRang.Range["B" + row.ToString()].Value = dgvChiTietHang.Rows[i].Cells[0].Value.ToString();
                exRang.Range["C" + row.ToString()].Value = dgvChiTietHang.Rows[i].Cells[1].Value.ToString();
                exRang.Range["D" + row.ToString()].Value = dgvChiTietHang.Rows[i].Cells[2].Value.ToString();
                exRang.Range["E" + row.ToString()].Value = dgvChiTietHang.Rows[i].Cells[3].Value.ToString();
                exRang.Range["F" + row.ToString()].Value = dgvChiTietHang.Rows[i].Cells[4].Value.ToString();
                exRang.Range["G" + row.ToString()].Value = dgvChiTietHang.Rows[i].Cells[5].Value.ToString();

            }

            exRang.Range["E"+(row+2).ToString()].Value = "Tổng tiền: " + txtTongTien.Text ;
            exSheet.Name = "HDBan";
            exBook.Activate();
            SaveFileDialog svFile = new SaveFileDialog();
            if(svFile.ShowDialog()==DialogResult.OK )
            {
                exBook.SaveAs(svFile.FileName );
            }
            exApp.Quit();


        }
    }
}
