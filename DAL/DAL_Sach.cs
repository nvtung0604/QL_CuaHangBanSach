﻿using System.Data;
using System.Data.SqlClient;
using DTO;
using Microsoft.SqlServer.Server;

namespace DAL
{
    public class DAL_Sach
    {
        // sử dụng class kết nối
        DBKetNoi kn = new DBKetNoi();

        public DataTable Hienthidulieu()
        {
            string query = @"
            SELECT 
            s.MaSach, s.TenSach, s.TacGia, t.TenTheLoai, s.GiaBan,
            s.SoLuongTon, s.NhaXuatBan, s.NamXuatBan,
            s.MaNCC, n.TenNCC, s.HinhAnh
            FROM Sach s
            JOIN NhaCungCap n ON s.MaNCC = n.MaNCC
            JOIN TheLoai t ON s.MaTheLoai = t.MaTheLoai";
            return kn.HienThiDuLieu(query);
        }

        // Thêm sách
        public int ThemSach(DTO_Sach s)
        {
            string query = "INSERT INTO Sach(MaSach, TenSach, TacGia, MaTheLoai, GiaBan, SoLuongTon, NhaXuatBan, NamXuatBan, MaNCC, HinhAnh) " +
                           "VALUES(@MaSach, @TenSach, @TacGia, @MaTheLoai, @GiaBan, @SoLuongTon, @NhaXuatBan, @NamXuatBan, @MaNCC, @HinhAnh)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MaSach", s.MaSach),
                new SqlParameter("@TenSach", s.TenSach),
                new SqlParameter("@TacGia", s.TacGia),
                new SqlParameter("@MaTheLoai", s.MaTheLoai),
                new SqlParameter("@GiaBan", s.GiaBan),
                new SqlParameter("@SoLuongTon", s.SoLuongTon),
                new SqlParameter("@NhaXuatBan", s.NhaXuatBan),
                new SqlParameter("@NamXuatBan", s.NamXuatBan),
                new SqlParameter("@MaNCC", s.MaNCC),
                new SqlParameter("@HinhAnh", s.HinhAnh)
            };

            return kn.ThaoTacDuLieu(query, parameters);
        }

        // Cập nhật sách
        public int CapNhatSach(DTO_Sach s)
        {
            string query = "UPDATE Sach SET TenSach = @TenSach, TacGia = @TacGia, MaTheLoai = @MaTheLoai, GiaBan = @GiaBan, " +
                           "SoLuongTon = @SoLuongTon, NhaXuatBan = @NhaXuatBan, NamXuatBan = @NamXuatBan, MaNCC = @MaNCC, HinhAnh = @HinhAnh " +
                           "WHERE MaSach = @MaSach";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MaSach", s.MaSach),
                new SqlParameter("@TenSach", s.TenSach),
                new SqlParameter("@TacGia", s.TacGia),
                new SqlParameter("@MaTheLoai", s.MaTheLoai),
                new SqlParameter("@GiaBan", s.GiaBan),
                new SqlParameter("@SoLuongTon", s.SoLuongTon),
                new SqlParameter("@NhaXuatBan", s.NhaXuatBan),
                new SqlParameter("@NamXuatBan", s.NamXuatBan),
                new SqlParameter("@MaNCC", s.MaNCC),
                new SqlParameter("@HinhAnh", s.HinhAnh)
            };

            return kn.ThaoTacDuLieu(query, parameters);
        }

        // Xóa sách
        public int XoaSach(string MaSach)
        {
            string query = "DELETE FROM Sach WHERE MaSach = @MaSach";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaSach", MaSach)
            };
            return kn.ThaoTacDuLieu(query, parameters);
        }

        // Tìm kiếm sách
        public DataTable TimKiemSach(string tuKhoa)
        {
            string query = "SELECT * FROM Sach s " +
               "JOIN TheLoai t ON s.MaTheLoai = t.MaTheLoai " +
               "JOIN NhaCungCap ncc ON s.MaNCC = ncc.MaNCC " +
               "WHERE (s.MaSach LIKE @TuKhoa " +
               "OR s.TenSach LIKE @TuKhoa " +
               "OR s.TacGia LIKE @TuKhoa " +
               "OR s.NhaXuatBan LIKE @TuKhoa " +
               "OR s.NamXuatBan LIKE @TuKhoa " +
               "OR ncc.TenNCC LIKE @TuKhoa " +
               "OR t.TenTheLoai LIKE @TuKhoa);";
            SqlParameter[] parameters =
            {
                new SqlParameter("@TuKhoa", "%" + tuKhoa + "%")
            };
            return kn.HienThiDuLieu(query, parameters);
        }

        // Kiểm tra mã sách đã tồn tại chưa
        public bool KiemTraMaSach(string maSach)
        {
            string query = "SELECT COUNT(*) FROM Sach WHERE MaSach = @MaSach";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaSach", maSach)
            };
            int count = kn.ThucThiScalarSoNguyen(query, parameters);
            return count > 0;
        }
        DAL_TheLoai dal_tl = new DAL_TheLoai();
        public DataTable LayDanhSachTheLoai()
        {
            return dal_tl.HienThiDuLieu();
        }
        DAL_NhaCungCap dal_ncc = new DAL_NhaCungCap();
        public DataTable LayDanhSachMaNCC()
        {
            
            return dal_ncc.HienThiDuLieuNhaCungCap();
        }
    }
}
