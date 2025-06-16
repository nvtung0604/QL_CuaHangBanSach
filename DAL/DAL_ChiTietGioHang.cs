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
    public class DAL_ChiTietGioHang
    {
        DBKetNoi kn = new DBKetNoi();
        public int ThemChiTietHoaDon(DTO_ChiTietGioHang ctgh)
        {
            
            string query = "INSERT INTO HoaDon_ChiTiet (MaGioHang, MaSach, SoLuong, GiaBan) VALUES (@MaGioHang, @MaSach, @SoLuong, @GiaBan)";
            Console.WriteLine(query);
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaGioHang", ctgh.MaGioHang),
                new SqlParameter("@MaSach", ctgh.MaSach),
                new SqlParameter("@SoLuong", ctgh.SoLuong),
                new SqlParameter("@GiaBan", ctgh.GiaBan)
            };
            return kn.ThaoTacDuLieu(query, parameters);
        }
        public DataTable HienThiDuLieu(string MaGioHang)
        {
            string query = "SELECT gh.MaSach, s.TenSach, gh.SoLuong, gh.GiaBan " +
               "FROM HoaDon_ChiTiet gh " +
               "JOIN Sach s ON gh.MaSach = s.MaSach " +
               "WHERE gh.MaGioHang = @MaGioHang and gh.isDelete = 0";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaGioHang", MaGioHang)
            };
            return kn.HienThiDuLieu(query, parameters);
        }
    }
}
