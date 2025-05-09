using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_POS
    {
        DBKetNoi kn = new DBKetNoi();
        public DataTable LayDanhSach()
        {
            string query = @"
                SELECT 
                    s.MaSach, 
                    s.TenSach, 
                    s.GiaBan, 
                    s.HinhAnh,
                    s.MaTheLoai,
                    t.TenTheLoai,
                    s.SoLuongTon
                FROM Sach s
                JOIN TheLoai t ON s.MaTheLoai = t.MaTheLoai
            ";
            return kn.HienThiDuLieu(query);
        }
        public DataTable LayDanhSachTheLoai()
        {
            string query = "SELECT TenTheLoai FROM TheLoai";
            return kn.HienThiDuLieu(query);
        }
        public DataTable LayDanhSachTheoMa(string MaSach)
        {
            string query = "SELECT Sach.MaSach, Sach.TenSach, Sach.TacGia, TheLoai.TenTheLoai, Sach.GiaBan, Sach.SoLuongTon, Sach.NhaXuatBan, " +
               "Sach.NamXuatBan, Sach.HinhAnh, NhaCungCap.TenNCC " +
               "FROM Sach " +
               "INNER JOIN NhaCungCap ON Sach.MaNCC = NhaCungCap.MaNCC " +
               "INNER JOIN TheLoai ON Sach.MaTheLoai = TheLoai.MaTheLoai " +
               "WHERE Sach.MaSach = @MaSach";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MaSach", MaSach)
            };
            
            return kn.HienThiDuLieu(query,parameters);
        }
        public int CapNhatTrangThai(string MaGioHang)
        {
            string query = "UPDATE HoaDon SET TrangThai = N'Đã thanh toán' WHERE MaGioHang = @MaGioHang";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaGioHang", MaGioHang)
            };
            return kn.ThaoTacDuLieu(query, parameters);
        }
        public DataTable HienThiGioHangDaThanhToan()
        {
            string query = @"SELECT 
                            HoaDon.MaGioHang, 
                            KhachHang.TenKH, 
                            HoaDon.TrangThai, 
                            HoaDon.ThoiGian, 
                            NhanVien.TenNV, 
                            HoaDon.TongTien
                            FROM HoaDon
                            JOIN KhachHang ON HoaDon.SDT = KhachHang.SDT
                            JOIN NhanVien ON HoaDon.MaNV = NhanVien.MaNV
                            WHERE HoaDon.TrangThai = N'Đã thanh toán';";


            return kn.HienThiDuLieu(query);
        }
        public DataTable HienThiChiTietGioHangTheoMa(string magiohang)
        {
            string query = "SELECT gh.MaGioHang, gh.MaSach, s.TenSach, gh.SoLuong, gh.GiaBan, (gh.SoLuong * gh.GiaBan) AS TongTien FROM HoaDon_ChiTiet gh JOIN Sach s ON gh.MaSach = s.MaSach WHERE gh.MaGioHang = @MaGioHang";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaGioHang", magiohang)
            };
            return kn.HienThiDuLieu(query, parameters);
        }
        public int CapNhatChiTietGioHang(string maGioHang, string maSach, int soLuong, decimal giaBan)
        {
            try
            {
                // Cập nhật SoLuong và GiaBan cho đúng bản ghi xác định bởi cả MaGioHang và MaSach
                string query = "UPDATE HoaDon_ChiTiet " +
                               "SET SoLuong = @SoLuong, GiaBan = @GiaBan " +
                               "WHERE MaGioHang = @MaGioHang AND MaSach = @MaSach";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MaGioHang", maGioHang),
                    new SqlParameter("@MaSach", maSach),
                    new SqlParameter("@SoLuong", soLuong),
                    new SqlParameter("@GiaBan", giaBan),
                };

                return kn.ThaoTacDuLieu(query, parameters);
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public int LaySoLuongTonTheoMa(string maS)
        {
            string query = "SELECT SoLuongTon FROM Sach WHERE MaSach = @MaSach";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaSach", maS)
            };

            object result = kn.ThucThiExecuteScalar(query, parameters); // Gọi hàm trong lớp kết nối

            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result);
            }

            return 0; // Trả về 0 nếu không tìm thấy
        }

        public bool KiemTraMaHoaDon(string magh)
        {

            string query = "SELECT COUNT(*) FROM HoaDon WHERE MaGioHang = @MaGioHang";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MaGioHang", magh)
            };
            int count = kn.ThucThiScalarSoNguyen(query, parameters);
            return count > 0;
        }

    }
}
