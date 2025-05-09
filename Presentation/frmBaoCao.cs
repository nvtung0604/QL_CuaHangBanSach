using BLL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ClosedXML.Excel;
using System.IO;
using System.Linq;
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
            dgBaoCao.Columns["dgcTenNV"].DataPropertyName = "TenNV";
            dgBaoCao.Columns["dgcSoLHD"].DataPropertyName = "SoLuongHoaDon";
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



        private void btnXuatRaExcel_Click_1(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Excel Workbook|*.xlsx",
                Title = "Chọn nơi lưu file Excel"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("BaoCao");

                            worksheet.Cell(1, 1).Value = "STT";
                            worksheet.Cell(1, 2).Value = "Tên Nhân Viên";
                            worksheet.Cell(1, 3).Value = "Số Lượng Hóa Đơn";
                            worksheet.Cell(1, 4).Value = "Tổng Tiền";

                            worksheet.Range("A1:D1").Style.Font.Bold = true;
                            worksheet.Range("A1:D1").Style.Fill.BackgroundColor = XLColor.LightBlue;
                            worksheet.Range("A1:D1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                            // Sắp xếp dữ liệu theo Số Lượng Hóa Đơn giảm dần
                            var rows = dgBaoCao.Rows
                                .Cast<DataGridViewRow>()
                                .Where(r => !r.IsNewRow)
                                .OrderByDescending(r => Convert.ToInt32(r.Cells["dgcTongT"].Value ?? 0))
                                .ToList();

                            int row = 2;
                            foreach (var dgvRow in rows)
                            {
                                worksheet.Cell(row, 1).Value = (row - 1); // STT
                                worksheet.Cell(row, 2).Value = dgvRow.Cells["dgcTenNV"].Value?.ToString();
                                worksheet.Cell(row, 3).Value = dgvRow.Cells["dgcSoLHD"].Value != null ? Convert.ToInt32(dgvRow.Cells["dgcSoLHD"].Value) : 0;
                                worksheet.Cell(row, 4).Value = dgvRow.Cells["dgcTongT"].Value != null ? Convert.ToDecimal(dgvRow.Cells["dgcTongT"].Value) : 0;
                                worksheet.Cell(row, 4).Style.NumberFormat.Format = "#,##0.00"; // format tiền
                                row++;
                            }

                            worksheet.Columns().AdjustToContents();
                            workbook.SaveAs(sfd.FileName);
                        }

                        MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message);
                    }
                }
            }
        }
    }
}