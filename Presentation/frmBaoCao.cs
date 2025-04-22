using BLL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Presentation
{
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }

        BLL_GioHang gh = new BLL_GioHang();

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            dgBaoCao.AutoGenerateColumns = false;

            DataTable dt = gh.HienThiDuLieuChoBaoCao();

            // Thêm cột STT vào DataTable nếu chưa có
            if (!dt.Columns.Contains("STT"))
                dt.Columns.Add("STT", typeof(int));

            // Gán số thứ tự cho từng dòng
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["STT"] = i + 1;
            }

            dgBaoCao.DataSource = dt;

            // Gán DataPropertyName cho từng cột
            dgBaoCao.Columns["dgcSoTT"].DataPropertyName = "STT";
            dgBaoCao.Columns["dgcMaGH"].DataPropertyName = "MaGioHang";
            dgBaoCao.Columns["dgcTenKH"].DataPropertyName = "TenKH";
            dgBaoCao.Columns["dgcTrangT"].DataPropertyName = "TrangThai";
            dgBaoCao.Columns["dgcThoiG"].DataPropertyName = "ThoiGian";
            dgBaoCao.Columns["dgcTenNV"].DataPropertyName = "TenNV";
            dgBaoCao.Columns["dgcTongT"].DataPropertyName = "TongTien";

            // Gán giá trị mặc định cho button
            btnThanhToan.Text = "Tổng tiền: 0 VND";
            btnSoLuongGioHang.Text = "Số đơn: 0";
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1); // Lấy hết ngày đó

            // Hiển thị biểu đồ
            DataTable dt = gh.LayTongTienTheoNhanVienTrongKhoang(tuNgay, denNgay);
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu cho biểu đồ trong khoảng thời gian được chọn.");
                return;
            }

            chartBaoCao.Series.Clear();
            Series series = new Series("Doanh thu");
            series.ChartType = SeriesChartType.Column;

            foreach (DataRow row in dt.Rows)
            {
                string tenNhanVien = row["TenNV"].ToString();
                decimal tongTien = row["TongTien"] == DBNull.Value ? 0 : Convert.ToDecimal(row["TongTien"]);
                series.Points.AddXY(tenNhanVien, tongTien);
            }

            chartBaoCao.Series.Add(series);

            // Hiển thị thông tin trên các button
            DataTable dtChiTiet = gh.LayChiTietHoaDonTrongKhoang(tuNgay, denNgay);
            if (dtChiTiet == null || dtChiTiet.Rows.Count == 0)
            {
                MessageBox.Show("Không có chi tiết hóa đơn nào trong khoảng thời gian được chọn.");
                return;
            }

            int soDonThanhToan = dtChiTiet.Rows.Count;
            decimal tongTienn = 0;

            foreach (DataRow row in dtChiTiet.Rows)
            {
                tongTienn += row["TongTien"] == DBNull.Value ? 0 : Convert.ToDecimal(row["TongTien"]);
            }

            btnSoLuongGioHang.Text = $"Số đơn: {soDonThanhToan}";
            btnThanhToan.Text = $"Tổng tiền: {tongTienn:C}";
        }
    }
}