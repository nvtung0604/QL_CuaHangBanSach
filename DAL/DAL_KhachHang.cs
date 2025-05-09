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
        public DataTable HienThiDuLieuKhachHang()
        {
            string query = "SELECT * FROM KhachHang";
            return kn.HienThiDuLieu(query);
        }

        // các thao tác cơ bản
        public int ThemKhachHang(DTO_KhachHang kh)
        {
            string query = "INSERT INTO KhachHang(SDT, TenKH) VALUES(@SDT, @TenKH)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@SDT", kh.SDT),
                new SqlParameter("@TenKH", kh.TenKH)
            };
            return kn.ThaoTacDuLieu(query, parameters);
        }
        public int CapNhatKhachHang(DTO_KhachHang kh)
        {
            string query = "UPDATE KhachHang SET TenKH = @TenKH WHERE SDT = @SDT";
            SqlParameter[] parameters =
            {
                new SqlParameter("@TenKH", kh.TenKH),
                new SqlParameter("@SDT", kh.SDT)
            };
            return kn.ThaoTacDuLieu(query, parameters);
        }
        public int XoaKhachHang(string SDT)
        {
            string query = "DELETE FROM KhachHang WHERE SDT = @SDT";
            SqlParameter[] parameters =
            {
                new SqlParameter("@SDT", SDT)
            };
            return kn.ThaoTacDuLieu(query, parameters);
        }
        
        // thao tác tìm kiếm
        public DataTable TimKiemKhachHang(string tukhoa)
        {
            string query = "SELECT * FROM KhachHang WHERE TenKH LIKE @Tukhoa OR SDT LIKE @Tukhoa";           
            SqlParameter[] parameters =
            {
                new SqlParameter("@Tukhoa", "%" + tukhoa + "%")
            };
            return kn.HienThiDuLieu(query, parameters);
        }


        // kiểm tra sdt khách hàng xem tồn tại chưa
        public bool KiemTraSDTKhachHang(string SDT)
        {
            
            string query = "SELECT COUNT(*) FROM KhachHang WHERE SDT = @SDT";
            
            SqlParameter[] parameters =
            {
                new SqlParameter("@SDT", SDT)
            };
            int count = kn.ThucThiScalarSoNguyen(query, parameters);
            return count > 0;
        }
        
    }
}
