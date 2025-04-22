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
        public DataTable Hienthidulieu()
        {
            string query = "SELECT * FROM NhanVien";
            return kn.Hienthidulieu(query);
        }

        // các thao tác cơ bản
        public int Themnhanvien(DTO_NhanVien nv)
        {
            string query = "INSERT INTO NhanVien (MaNV, TenNV, SDT) VALUES (@MaNV,@TenNV, @SDT)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaNV", nv.MaNV),
                new SqlParameter("@TenNV", nv.TenNV),
                new SqlParameter("@SDT", nv.SDT)
            };
            return kn.Thaotacdulieu(query, parameters);
        }
        public int Capnhatnhanvien(DTO_NhanVien nv)
        {
            string query = "UPDATE NhanVien SET TenNV = @TenNV, SDT = @SDT WHERE MaNV = @MaNV";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaNV", nv.MaNV),
                new SqlParameter("@TenNV", nv.TenNV),
                new SqlParameter("@SDT", nv.SDT)
            };
            return kn.Thaotacdulieu(query, parameters);
        }
        public int Xoanhanvien(string MaNV)
        {
            string query = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaNV", MaNV),
            };
            return kn.Thaotacdulieu(query, parameters);
        }

        //tìm kiếm nhân viên
        public DataTable Timkiemnhanvien(string tukhoa)
        {
            string query = "SELECT * FROM NhanVien WHERE MaNV LIKE @Tukhoa OR TenNV LIKE @Tukhoa OR SDT LIKE @Tukhoa";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Tukhoa", "%" + tukhoa + "%")
            };
            return kn.Hienthidulieu(query, parameters);
        }
        // kiểm tra mã nhân viên
        public bool Kiemtramanhanvien(string MaNV)
        {
            string query = "SELECT COUNT(*) FROM NhanVien WHERE MaNV = @MaNV";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaNV", MaNV)
            };
            return kn.Thucthiexcutescalar(query, parameters) > 0;
        }
    }
}
