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
    public class DAL_KhachHang
    {
        // sử dụng class kết nối
        DBKetNoi kn = new DBKetNoi();

        // Hiển thị dữ liệu khách hàng
        public DataTable Hienthidulieu()
        {
            string query = "SELECT * FROM KhachHang";
            return kn.Hienthidulieu(query);
        }

        // các thao tác cơ bản
        public int Themkhachhang(DTO_KhachHang kh)
        {
            string query = "INSERT INTO KhachHang(MaKH, TenKH, SDT) VALUES(@MaKH, @TenKH, @SDT)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaKH", kh.MaKH),
                new SqlParameter("@TenKH", kh.TenKH),
                new SqlParameter("@SDT", kh.SDT)
            };
            return kn.Thaotacdulieu(query, parameters);
        }
        public int Capnhatkhachhang(DTO_KhachHang kh)
        {
            string query = "UPDATE KhachHang SET TenKH = @TenKH, SDT = @SDT WHERE MaKH = @MaKH";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaKH", kh.MaKH),
                new SqlParameter("@TenKH", kh.TenKH),
                new SqlParameter("@SDT", kh.SDT)
            };
            return kn.Thaotacdulieu(query, parameters);
        }
        public int Xoakhachhang(string MaKH)
        {
            string query = "DELETE FROM KhachHang WHERE MaKH = @MaKH";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaKH", MaKH)
            };
            return kn.Thaotacdulieu(query, parameters);
        }
        
        // thao tác tìm kiếm
        public DataTable Timkiemkhachhang(string tukhoa)
        {
            string query = "SELECT * FROM KhachHang WHERE MaKH LIKE @Tukhoa OR TenKH LIKE @Tukhoa OR SDT LIKE @Tukhoa";           
            SqlParameter[] parameters =
            {
                new SqlParameter("@Tukhoa", "%" + tukhoa + "%")
            };
            return kn.Hienthidulieu(query, parameters);
        }


        // kiểm tra mã khách hàng xem tồn tại chưa
        public bool Kiemtramakhachhang(string MaKH)
        {
            
            string query = "SELECT COUNT(*) FROM KhachHang WHERE MaKH = @MaKH";
            
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaKH", MaKH)
            };
            int count = kn.Thucthiexcutescalar(query, parameters);
            return count > 0;
        }
    }
}
