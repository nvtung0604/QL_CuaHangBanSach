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
            return kn.Hienthidulieu(query, parameters);
        }
        public DataTable HienThiDuLieu()
        {
            string query = "select tk.MaTaiKhoan, tk.TenTaiKhoan, tk.MatKhau, tk.Role, nv.TenNV from TaiKhoan tk join NhanVien nv ON tk.MaNV = nv.MaNV;";
            return kn.Hienthidulieu(query);
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
            return kn.Thaotacdulieu(query, parameters);
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
                return kn.Thaotacdulieu(query, parameters); // Ensure Thaotacdulieu accepts parameters
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
            return kn.Thaotacdulieu(query, parameters);
        }
        public bool KiemTraTenTaiKhoanTonTai(string MaTaiKhoan)
        {
            string query = "SELECT COUNT(*) FROM TaiKhoan WHERE MaTaiKhoan = @MaTaiKhoan";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MaTaiKhoan", MaTaiKhoan)
            };
            int count = kn.Thucthiexcutescalar(query, parameters);
            return count > 0;
        }
        public DataTable LoadMaNV()
        {
            string query = "select MaNV, TenNV from NhanVien ";
            return kn.Hienthidulieu(query);
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
            WHERE tk.MaTaiKhoan LIKE @Tukhoa OR tk.TenTaiKhoan LIKE N'@Tukhoa' OR tk.MatKhau LIKE @Tukhoa";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Tukhoa", "%" + tukhoa + "%")
            };
            return kn.Hienthidulieu(query, parameters);
        }
        
    }
}
