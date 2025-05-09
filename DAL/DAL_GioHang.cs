using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_GioHang
    {
        DBKetNoi kn = new DBKetNoi();
        public DataTable HienThiDuLieu()
        {
            string query = @"SELECT 
                            HoaDon.MaGioHang, 
                            KhachHang.TenKH,
                            HoaDon.TrangThai, 
                            HoaDon.ThoiGian, 
                            NhanVien.TenNV, 
                            HoaDon.TongTien
                            FROM HoaDon
                            INNER JOIN KhachHang ON HoaDon.SDT = KhachHang.SDT
                            INNER JOIN NhanVien ON HoaDon.MaNV = NhanVien.MaNV
                            WHERE HoaDon.TongTien > 0 AND HoaDon.TrangThai = N'Chưa thanh toán'";
            return kn.HienThiDuLieu(query);
        }
     
        public int ThemHoaDon(DTO_GioHang gh)
        {
            string query = "INSERT INTO HoaDon (SDT) VALUES(@SDT)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@SDT", gh.SDT)
            };
            return kn.ThaoTacDuLieu(query, parameters);
        }
        // chưa biết
        public string ThemDuLieuGioHangSinhMa(DTO_GioHang gh)
        {
            string maGH = "";

            using (SqlConnection conn = new SqlConnection(DBKetNoi.chuoiketnoi))
            {
                using (SqlCommand cmd = new SqlCommand("TaoHoaDon", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure; // <-- QUAN TRỌNG

                    // Thêm tham số đầu vào
                    cmd.Parameters.AddWithValue("@SDT", gh.SDT);
                    cmd.Parameters.AddWithValue("@MaNV", gh.MaNV);

                    // Tham số đầu ra
                    SqlParameter outputParam = new SqlParameter("@MaGioHang", SqlDbType.NVarChar, 30)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputParam);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    // Lấy giá trị đầu ra
                    maGH = outputParam.Value.ToString();
                }
            }

            return maGH;
        }


        public DataTable LayDuLieuTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            string query = @"SELECT 
                HoaDon.MaGioHang, 
                KhachHang.TenKH,
                HoaDon.TrangThai, 
                HoaDon.ThoiGian, 
                NhanVien.TenNV, 
                HoaDon.TongTien
                FROM HoaDon
                INNER JOIN KhachHang ON HoaDon.SDT = KhachHang.SDT
                INNER JOIN NhanVien ON HoaDon.MaNV = NhanVien.MaNV 
                WHERE CAST(HoaDon.ThoiGian AS DATE) BETWEEN @TuNgay AND @DenNgay";
            SqlParameter[] parameters =
            {
                new SqlParameter("@TuNgay", tuNgay),
                new SqlParameter("@DenNgay", denNgay)
            };
            return kn.HienThiDuLieu(query, parameters);
        }
        public DataTable LayTongTienTheoNhanVien()
        {
            string query = @"
            SELECT 
                nv.TenNV,
                SUM(ghct.SoLuong * ghct.GiaBan) AS TongTien
            FROM HoaDon gh
            INNER JOIN NhanVien nv ON gh.MaNV = nv.MaNV
            INNER JOIN HoaDon_ChiTiet ghct ON gh.MaGioHang = ghct.MaGioHang
            WHERE gh.TrangThai = N'Đã thanh toán'
            GROUP BY nv.TenNV";

            return kn.HienThiDuLieu(query);
        }
        public DataTable LayTongTienTheoNhanVienTrongKhoang(DateTime tuNgay, DateTime denNgay)
        {
            string query = @"
            SELECT 
                nv.TenNV,
                SUM(ghct.SoLuong * ghct.GiaBan) AS TongTien
            FROM HoaDon gh
            INNER JOIN NhanVien nv ON gh.MaNV = nv.MaNV
            INNER JOIN HoaDon_ChiTiet ghct ON gh.MaGioHang = ghct.MaGioHang
            WHERE gh.TrangThai = N'Đã thanh toán'
              AND gh.ThoiGian BETWEEN @TuNgay AND @DenNgay
            GROUP BY nv.TenNV";

            SqlParameter[] parameter =
            {
                new SqlParameter("@TuNgay", tuNgay),
                new SqlParameter("@DenNgay", denNgay)
            };

            return kn.HienThiDuLieu(query, parameter);
        }
        public DataTable LayChiTietHoaDonTrongKhoang(DateTime tuNgay, DateTime denNgay)
        {
            string query = @"
            SELECT 
                gh.MaGioHang, 
                kh.TenKH, 
                gh.TrangThai, 
                gh.ThoiGian, 
                nv.TenNV,
                ISNULL(SUM(ghct.SoLuong * ghct.GiaBan), 0) AS TongTien
                FROM HoaDon gh
                INNER JOIN KhachHang kh ON gh.SDT = kh.SDT
                INNER JOIN NhanVien nv ON gh.MaNV = nv.MaNV
                LEFT JOIN HoaDon_ChiTiet ghct ON gh.MaGioHang = ghct.MaGioHang
                WHERE gh.TrangThai = N'Đã thanh toán'
                  AND gh.ThoiGian BETWEEN @TuNgay AND @DenNgay
                GROUP BY gh.MaGioHang, kh.TenKH, gh.TrangThai, gh.ThoiGian, nv.TenNV";

            SqlParameter[] parameter =
            {
                new SqlParameter("@TuNgay", tuNgay),
                new SqlParameter("@DenNgay", denNgay)
            };


            return kn.HienThiDuLieu(query, parameter);
        }
        public DataTable HienThiDuLieuChoBaoCao()
        {
            string query = @"
                SELECT
                nv.TenNV,
                COUNT(gh.MaGioHang) AS SoLuongHoaDon,
                ISNULL(SUM(ghct.SoLuong * ghct.GiaBan), 0) AS TongTien
            FROM
                HoaDon gh
            INNER JOIN
                KhachHang kh ON gh.SDT = kh.SDT
            INNER JOIN
                NhanVien nv ON gh.MaNV = nv.MaNV
            LEFT JOIN
                HoaDon_ChiTiet ghct ON gh.MaGioHang = ghct.MaGioHang
            WHERE
                gh.TrangThai = N'Đã thanh toán'
            GROUP BY
                nv.TenNV
            ";

            // Gọi phương thức Hienthidulieu để thực thi câu truy vấn và trả về DataTable
            return kn.HienThiDuLieu(query);  // Giả sử bạn không cần parameters, nếu có thì truyền vào
        }
        public int XoaHoaDon(string MaGioHang)
        {
            string query = "DELETE FROM HoaDon_ChiTiet WHERE MaGioHang = @MaGioHang;\r\nDELETE FROM HoaDon WHERE MaGioHang = @MaGioHang;";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaGioHang", MaGioHang),
            };
            return kn.ThaoTacDuLieu(query, parameters);
        }
        public DataTable HienThiDuLieu2()
        {
            string query = "SELECT * FROM HoaDon WHERE TrangThai = N'Chưa Thanh Toán'";
            return kn.HienThiDuLieu(query);
        }
        public DataTable LaySDTKhachHang(string sdt = null)
        {
            if (sdt  == null)
            {
                string q = "SELECT SDT FROM KhachHang";
                return kn.HienThiDuLieu(q);
            }
            // Thêm dấu % vào trước và sau số điện thoại để tìm kiếm theo kiểu LIKE
            string query = "SELECT SDT FROM KhachHang WHERE SDT LIKE @sdt";
            SqlParameter[] parameters =
            {
                new SqlParameter("@sdt", "%" + sdt + "%") // Thêm dấu % vào
            };
            return kn.HienThiDuLieu(query, parameters);
        }

        // lấy tên khách hàng từ số điện thoại
        public string LayTenKhacHangTuSDT(string sdt)
        {
            string query = "SELECT TenKH FROM KhachHang WHERE SDT = @sdt";
            SqlParameter[] parameters =
            {
                new SqlParameter("@sdt", sdt)
            };
            DataTable dt = kn.HienThiDuLieu(query, parameters);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["TenKH"].ToString();
            }
            // nếu không tìm thấy
            return null;
        }

    }
}
