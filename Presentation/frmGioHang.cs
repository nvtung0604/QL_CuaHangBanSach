using BLL;
using Presentation.HopThoai;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Web.UI;
namespace Presentation
{
    public partial class frmGioHang : Form
    {
        Hopthoai ht = new Hopthoai();
        BLL_ChiTietGioHang bll_ctgh = new BLL_ChiTietGioHang();
        private frmPOSs fPOS = new frmPOSs();
        // nghi vấn
        public string maGioHang { get; private set; }
        public frmGioHang()
        {
            InitializeComponent();
        }
        PrintDocument printDocument = new PrintDocument();
        Font fontTieuDe = new Font("Arial", 16, FontStyle.Bold);
        Font fontNoiDung = new Font("Arial", 14);

        string hoaDonText = "";

        BLL_GioHang bll_gh = new BLL_GioHang();
        private void frmGioHang_Load(object sender, EventArgs e)
        {
            
            dgGioHang.AutoGenerateColumns = false;
            dgGioHang.DataSource = bll_gh.HienThiDuLieu();
            dgGioHang.Columns["dgcInHD"].Visible = false;
            dgGioHang.Columns["dgcMaGH"].DataPropertyName = "MaGioHang";
            dgGioHang.Columns["dgcTenKH"].DataPropertyName = "TenKH";
            dgGioHang.Columns["dgcTrangT"].DataPropertyName = "TrangThai";
            dgGioHang.Columns["dgcThoiG"].DataPropertyName = "ThoiGian";
            dgGioHang.Columns["dgcTenNV"].DataPropertyName = "TenNV";
            dgGioHang.Columns["dgcTongT"].DataPropertyName = "TongTien";
            
        }
        
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        
      
        private void dgGioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgGioHang.Columns[e.ColumnIndex].Name == "dgcCapNhat")
            {
                maGioHang = dgGioHang.CurrentRow.Cells["dgcMaGH"].Value.ToString();
                this.Close();
                fPOS.BringToFront();
                MessageBox.Show($"Đã cập nhật mã giỏ hàng {maGioHang}");
                

            }
            if (dgGioHang.Columns[e.ColumnIndex].Name == "dgcXoa")
            {
                try
                {
                    maGioHang = dgGioHang.CurrentRow.Cells["dgcMaGH"].Value.ToString();
                    int result = bll_gh.XoaDuLieu(maGioHang);
                    if (result != 0)
                    {
                        ht.ThongBao(this, "Thông báo!", "Xóa thành công", Guna.UI2.WinForms.MessageDialogIcon.Information);
                        //MessageBox.Show("Xóa thành công");
                        dgGioHang.DataSource = bll_gh.HienThiDuLieu();
                    }
                    else
                    {
                        ht.ThongBao(this, "Lỗi!", "Không thể xóa dữ liệu", Guna.UI2.WinForms.MessageDialogIcon.Error);
                        //MessageBox.Show("Xóa thất bại");

                    }
                }
                catch (Exception ex)
                {
                    ht.ThongBao(this, "Lỗi!", "Đã xảy ra lỗi: " + ex.Message, Guna.UI2.WinForms.MessageDialogIcon.Error);
                }
            }

            if (dgGioHang.Columns[e.ColumnIndex].Name == "dgcInHD")
            {
                if (dgGioHang.CurrentRow != null)
                {
                    string maGioHang = dgGioHang.CurrentRow.Cells["dgcMaGH"].Value.ToString();
                    string tenKH = dgGioHang.CurrentRow.Cells["dgcTenKH"].Value.ToString();
                    string thoiGian = dgGioHang.CurrentRow.Cells["dgcThoiG"].Value.ToString();
                    string tenNV = dgGioHang.CurrentRow.Cells["dgcTenNV"].Value.ToString();
                    string tongTien = dgGioHang.CurrentRow.Cells["dgcTongT"].Value.ToString();

                    hoaDonText = $"--- HÓA ĐƠN THANH TOÁN ---\n\n";
                    hoaDonText += $"Mã giỏ hàng: {maGioHang}\n";
                    hoaDonText += $"Khách hàng: {tenKH}\n";
                    hoaDonText += $"Thời gian: {thoiGian}\n";
                    hoaDonText += $"Nhân viên: {tenNV}\n";
                    hoaDonText += $"Tổng tiền: {tongTien} VNĐ\n\n";

                    // Thêm chi tiết món ăn (lấy từ BLL_ChiTietGioHang)
                    hoaDonText += bll_ctgh.LayChiTietGioHangText(maGioHang); // Trả về chuỗi đã format

                    // In hóa đơn
                    printDocument.PrintPage -= printDocument1_PrintPage; // tránh bị trùng nhiều lần
                    printDocument.PrintPage += printDocument1_PrintPage;

                    PrintPreviewDialog previewDialog = new PrintPreviewDialog();
                    previewDialog.Document = printDocument;
                    previewDialog.Width = 800;
                    previewDialog.Height = 600;

                    // Canh giữa màn hình
                    int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
                    int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

                    previewDialog.StartPosition = FormStartPosition.Manual;
                    previewDialog.Location = new Point(
                        (screenWidth - previewDialog.Width) / 2,
                        (screenHeight - previewDialog.Height) / 2
                    );
                    previewDialog.ShowDialog();
                }
            }

        }
        //public string laymagiohang()
        //{
        //    return maGioHang;
        //}
        BLL_POS pos = new BLL_POS();
        private void btnHoaDonThanhToan_Click(object sender, EventArgs e)
        {
           
            dgGioHang.AutoGenerateColumns = false;
            dgGioHang.DataSource = pos.HienThiGioHangDaThanhToan();
            dgGioHang.Columns["dgcInHD"].Visible = true;
            dgGioHang.Columns["dgcXoa"].Visible = false;
            dgGioHang.Columns["dgcCapNhat"].Visible = false;
            dgGioHang.Columns["dgcMaGH"].DataPropertyName = "MaGioHang";
            dgGioHang.Columns["dgcTenKH"].DataPropertyName = "TenKH";
            dgGioHang.Columns["dgcTrangT"].DataPropertyName = "TrangThai";
            dgGioHang.Columns["dgcThoiG"].DataPropertyName = "ThoiGian";
            dgGioHang.Columns["dgcTenNV"].DataPropertyName = "TenNV";
            dgGioHang.Columns["dgcTongT"].DataPropertyName = "TongTien";
            
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int x = 100;
            int y = 100;
            int lineHeight = 30;

            Font fontTieuDe = new Font("Arial", 16, FontStyle.Bold);
            Font fontNoiDung = new Font("Arial", 14);

            // In tiêu đề
            e.Graphics.DrawString("HÓA ĐƠN THANH TOÁN", fontTieuDe, Brushes.Black, x, y);
            y += lineHeight * 2;

            // In từng dòng nội dung
            foreach (var line in hoaDonText.Split('\n'))
            {
                e.Graphics.DrawString(line, fontNoiDung, Brushes.Black, x, y);
                y += lineHeight;
            }
        }

        private void dgGioHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
    }
}
