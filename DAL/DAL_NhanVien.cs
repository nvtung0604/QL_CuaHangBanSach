using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_NhanVien
    {
        // các thành phần cần dùng
        DBKetNoi kn = new DBKetNoi();
        public DataTable HienThiDuLieu()
        {
            string query = "SELECT * FROM NhanVien";
            return kn.HienThiDuLieu(query);
        }

        // các thao tác cơ bản
        public int ThemNhanVien(DTO_NhanVien nv)
        {
            string query = "INSERT INTO NhanVien (MaNV, TenNV, SDT) VALUES (@MaNV,@TenNV, @SDT)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaNV", nv.MaNV),
                new SqlParameter("@TenNV", nv.TenNV),
                new SqlParameter("@SDT", nv.SDT)
            };
            return kn.ThaoTacDuLieu(query, parameters);
        }
        public int CapNhatNhanVien(DTO_NhanVien nv)
        {
            string query = "UPDATE NhanVien SET TenNV = @TenNV, SDT = @SDT WHERE MaNV = @MaNV";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaNV", nv.MaNV),
                new SqlParameter("@TenNV", nv.TenNV),
                new SqlParameter("@SDT", nv.SDT)
            };
            return kn.ThaoTacDuLieu(query, parameters);
        }
        public int XoaNhanVien(string MaNV)
        {
            string query = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaNV", MaNV),
            };
            return kn.ThaoTacDuLieu(query, parameters);
        }

        //tìm kiếm nhân viên
        public DataTable TimKiemNhanVien(string tukhoa)
        {
            string query = "SELECT * FROM NhanVien WHERE MaNV LIKE @Tukhoa OR TenNV LIKE @Tukhoa OR SDT LIKE @Tukhoa";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Tukhoa", "%" + tukhoa + "%")
            };
            return kn.HienThiDuLieu(query, parameters);
        }
        // kiểm tra mã nhân viên
        public bool KiemTraMaNhanVien(string MaNV)
        {
            string query = "SELECT COUNT(*) FROM NhanVien WHERE MaNV = @MaNV";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaNV", MaNV)
            };
            return kn.ThucThiScalarSoNguyen(query, parameters) > 0;
        }
    }
}
