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
                            GioHang.MaGioHang, 
                            KhachHang.TenKH,
                            GioHang.TrangThai, 
                            GioHang.ThoiGian, 
                            NhanVien.TenNV, 
                            GioHang.TongTien
                            FROM GioHang
                            INNER JOIN KhachHang ON GioHang.MaKH = KhachHang.MaKH
                            INNER JOIN NhanVien ON GioHang.MaNV = NhanVien.MaNV
                            WHERE GioHang.TongTien > 0 AND GioHang.TrangThai = N'Chưa thanh toán'";
            return kn.Hienthidulieu(query);
        }
        //public DataTable HienThiDuLieuChoBaoCao()
        //{
        //    string query = @"
        //SELECT 
        //    nv.TenNV,
        //    SUM(ghct.SoLuong * ghct.GiaBan) AS TongTien
        //FROM GioHang gh
        //INNER JOIN NhanVien nv ON gh.MaNV = nv.MaNV
        //INNER JOIN GioHang_ChiTiet ghct ON gh.MaGioHang = ghct.MaGioHang
        //WHERE gh.TrangThai = N'Đã thanh toán'
        //GROUP BY nv.TenNV";
        //    return kn.Hienthidulieu(query);
        //}

        public int ThemGioHang(DTO_GioHang gh)
        {
            string query = "INSERT INTO GioHang (MaKH) VALUES(@MaKH)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaKH", gh.MaKH)
            };
            return kn.Thaotacdulieu(query, parameters);
        }
        public string ThemDuLieuGioHangSinhMa(DTO_GioHang gh)
        {
            string maGH = "";

            using (SqlConnection conn = new SqlConnection(DBKetNoi.chuoiketnoi))
            {
                using (SqlCommand cmd = new SqlCommand("TaoGioHang", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số đầu vào
                    cmd.Parameters.AddWithValue("@MaKH", gh.MaKH);
                    cmd.Parameters.AddWithValue("@MaNV", gh.MaNV);

                    // Thêm tham số đầu ra
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
                GioHang.MaGioHang, 
                KhachHang.TenKH,
                GioHang.TrangThai, 
                GioHang.ThoiGian, 
                NhanVien.TenNV, 
                GioHang.TongTien
                FROM GioHang
                INNER JOIN KhachHang ON GioHang.MaKH = KhachHang.MaKH
                INNER JOIN NhanVien ON GioHang.MaNV = NhanVien.MaNV 
                WHERE CAST(GioHang.ThoiGian AS DATE) BETWEEN @TuNgay AND @DenNgay";
            SqlParameter[] parameters =
            {
                new SqlParameter("@TuNgay", tuNgay),
                new SqlParameter("@DenNgay", denNgay)
            };
            return kn.Hienthidulieu(query, parameters);
        }
        public DataTable LayTongTienTheoNhanVien()
        {
            string query = @"
            SELECT 
                nv.TenNV,
                SUM(ghct.SoLuong * ghct.GiaBan) AS TongTien
            FROM GioHang gh
            INNER JOIN NhanVien nv ON gh.MaNV = nv.MaNV
            INNER JOIN GioHang_ChiTiet ghct ON gh.MaGioHang = ghct.MaGioHang
            WHERE gh.TrangThai = N'Đã thanh toán'
            GROUP BY nv.TenNV";

            return kn.Hienthidulieu(query);
        }
        public DataTable LayTongTienTheoNhanVienTrongKhoang(DateTime tuNgay, DateTime denNgay)
        {
            string query = @"
            SELECT 
                nv.TenNV,
                SUM(ghct.SoLuong * ghct.GiaBan) AS TongTien
            FROM GioHang gh
            INNER JOIN NhanVien nv ON gh.MaNV = nv.MaNV
            INNER JOIN GioHang_ChiTiet ghct ON gh.MaGioHang = ghct.MaGioHang
            WHERE gh.TrangThai = N'Đã thanh toán'
              AND gh.ThoiGian BETWEEN @TuNgay AND @DenNgay
            GROUP BY nv.TenNV";

            SqlParameter[] parameter =
            {
                new SqlParameter("@TuNgay", tuNgay),
                new SqlParameter("@DenNgay", denNgay)
            };

            return kn.Hienthidulieu(query, parameter);
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
                FROM GioHang gh
                INNER JOIN KhachHang kh ON gh.MaKH = kh.MaKH
                INNER JOIN NhanVien nv ON gh.MaNV = nv.MaNV
                LEFT JOIN GioHang_ChiTiet ghct ON gh.MaGioHang = ghct.MaGioHang
                WHERE gh.TrangThai = N'Đã thanh toán'
                  AND gh.ThoiGian BETWEEN @TuNgay AND @DenNgay
                GROUP BY gh.MaGioHang, kh.TenKH, gh.TrangThai, gh.ThoiGian, nv.TenNV";

            SqlParameter[] parameter =
            {
                new SqlParameter("@TuNgay", tuNgay),
                new SqlParameter("@DenNgay", denNgay)
            };


            return kn.Hienthidulieu(query, parameter);
        }
        public DataTable HienThiDuLieuChoBaoCao()
        {
            string query = @"
        SELECT
            gh.MaGioHang, 
            kh.TenKH, 
            gh.TrangThai, 
            gh.ThoiGian, 
            nv.TenNV,
            ISNULL(SUM(ghct.SoLuong * ghct.GiaBan), 0) AS TongTien
        FROM
            GioHang gh
        INNER JOIN
            KhachHang kh ON gh.MaKH = kh.MaKH
        INNER JOIN
            NhanVien nv ON gh.MaNV = nv.MaNV
        LEFT JOIN
            GioHang_ChiTiet ghct ON gh.MaGioHang = ghct.MaGioHang
        WHERE
            gh.TrangThai = N'Đã thanh toán'
        GROUP BY
            gh.MaGioHang, kh.TenKH, gh.TrangThai, gh.ThoiGian, nv.TenNV;
            ";

            // Gọi phương thức Hienthidulieu để thực thi câu truy vấn và trả về DataTable
            return kn.Hienthidulieu(query);  // Giả sử bạn không cần parameters, nếu có thì truyền vào
        }
        public int XoaGioHang(string MaGioHang)
        {
            string query = "DELETE FROM GioHang_ChiTiet WHERE MaGioHang = @MaGioHang;\r\nDELETE FROM GioHang WHERE MaGioHang = @MaGioHang;";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaGioHang", MaGioHang),
            };
            return kn.Thaotacdulieu(query, parameters);
        }
        public DataTable HienThiDuLieu2()
        {
            string query = "SELECT * FROM GioHang WHERE TrangThai = N'Chưa Thanh Toán'";
            return kn.Hienthidulieu(query);
        }

    }
}
