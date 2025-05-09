using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DangNhap
    {
        DBKetNoi kn = new DBKetNoi();
        public DataTable KiemTraDangNhap(DTO_DangNhap dto_dn)
        {
            string query = "SELECT * FROM TaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan AND MatKhau = @MatKhau";
            SqlParameter[] parameters =
            {
                new SqlParameter("@TenTaiKhoan", dto_dn.TenTaiKhoan),
                new SqlParameter("@MatKhau", dto_dn.MatKhau)
            };
            return kn.HienThiDuLieu(query, parameters);
        }
        public DataTable HienThiDuLieu()
        {
            string query = "select tk.MaTaiKhoan, tk.TenTaiKhoan, tk.MatKhau, tk.Role, nv.TenNV, nv.MaNV from TaiKhoan tk join NhanVien nv ON tk.MaNV = nv.MaNV";
            return kn.HienThiDuLieu(query);
        }
        public int ThemTaiKhoan(DTO_DangNhap dn)
        {
            string query = "INSERT INTO TaiKhoan (MaTaiKhoan, TenTaiKhoan, MatKhau, Role, MaNV) VALUES (@MaTaiKhoan, @TenTaiKhoan, @MatKhau, @Role, @MaNV)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaTaiKhoan", dn.MaTaiKhoan),
                new SqlParameter("@TenTaiKhoan", dn.TenTaiKhoan),
                new SqlParameter("@MatKhau", dn.MatKhau),
                new SqlParameter("@Role", dn.Role),
                new SqlParameter("@MaNV", dn.MaNV),
            };
            return kn.ThaoTacDuLieu(query, parameters);
        }
        public int CapNhatTaiKhoan(DTO_DangNhap dn)
        {
            string query = "UPDATE TaiKhoan SET TenTaiKhoan = @TenTaiKhoan, MatKhau = @MatKhau, Role = @Role, MaNV = @MaNV WHERE MaTaiKhoan = @MaTaiKhoan";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaTaiKhoan", dn.MaTaiKhoan),
                new SqlParameter("@TenTaiKhoan", dn.TenTaiKhoan),
                new SqlParameter("@MatKhau", dn.MatKhau),
                new SqlParameter("@Role", dn.Role),
                new SqlParameter("@MaNV", dn.MaNV),
            };
            
            try
            {
                return kn.ThaoTacDuLieu(query, parameters); // Ensure Thaotacdulieu accepts parameters
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database error: " + ex.Message);
                return -1; // Indicate failure
            }
        }
        public int XoaTaiKhoan(string MaTaiKhoan)
        {
            string query = "DELETE FROM TaiKhoan WHERE MaTaiKhoan = @MaTaiKhoan";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaTaiKhoan", MaTaiKhoan)
            };
            return kn.ThaoTacDuLieu(query, parameters);
        }
        public bool KiemTraMaTaiKhoanTonTai(string MaTaiKhoan)
        {
            string query = "SELECT COUNT(*) FROM TaiKhoan WHERE MaTaiKhoan = @MaTaiKhoan";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MaTaiKhoan", MaTaiKhoan)
            };
            int count = kn.ThucThiScalarSoNguyen(query, parameters);
            return count > 0;
        }
        public DataTable LoadMaNV()
        {
            string query = "select * from NhanVien ";
            return kn.HienThiDuLieu(query);
        }

        // chưa biết 15-4-25
        public string LayTenNhanVienTuTenTaiKhoan(string username)
        {
            string query = "SELECT nv.TenNV FROM TaiKhoan tk JOIN NhanVien nv ON tk.MaNV = nv.MaNV WHERE TenTaiKhoan = @TenTaiKhoan";
            SqlParameter[] parameters =
            {
                new SqlParameter("@TenTaiKhoan", username)
            };
            object result = kn.ThucThiExecuteScalar(query, parameters);
            return result != null ? result.ToString() : string.Empty;
        }
        // lấy mã nhân viên từ tên tài khoản
        public string LayMaNhanVienTuTenTaiKhoan(string username)
        {
            string query = "SELECT MaNV FROM TaiKhoan WHERE TenTaiKhoan = @username";
            SqlParameter[] parameters =
            {
                new SqlParameter("@username", username)
            };
            object result = kn.ThucThiExecuteScalar(query, parameters);
            return result != null ? result.ToString() : string.Empty;
        }
        public string LayQuyenTuNhanVien(string username)
        {
            string query = "SELECT Role FROM TaiKhoan WHERE TenTaiKhoan = @username";
            SqlParameter[] parameters =
            {
                new SqlParameter("@username", username),
            };
            object result = kn.ThucThiExecuteScalar(query, parameters);
            return result != null ? result.ToString() : string.Empty;
        }
        public DataTable TimKiemTaiKhoan(string tukhoa)
        {
            string query = @"
            SELECT tk.MaTaiKhoan, tk.TenTaiKhoan, tk.MatKhau, tk.Role, nv.TenNV
            FROM TaiKhoan tk
            LEFT JOIN NhanVien nv ON tk.MaNV = nv.MaNV
            WHERE tk.MaTaiKhoan LIKE @Tukhoa OR tk.TenTaiKhoan LIKE N'@Tukhoa' OR tk.MatKhau LIKE @Tukhoa OR nv.TenNV Like @Tukhoa OR tk.Role Like @Tukhoa";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Tukhoa", "%" + tukhoa + "%")
            };
            return kn.HienThiDuLieu(query, parameters);
        }
        public bool KiemTraTenTaiKhoanTonTai(string tenTaiKhoan)
        {
            // Truy vấn cơ sở dữ liệu để kiểm tra
            string query = $"SELECT COUNT(*) FROM TaiKhoan WHERE TenTaiKhoan = '{tenTaiKhoan}'";
            int count = kn.ThucThiScalarSoNguyen(query); // Hàm thực thi truy vấn trả về số lượng
            return count > 0; // Trả về true nếu tên tài khoản đã tồn tại
        }

    }
}
