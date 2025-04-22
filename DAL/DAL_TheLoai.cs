using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TheLoai
    {
        // sử dụng class kết nối
        DBKetNoi kn = new DBKetNoi();

        // Hiển thị dữ liệu thể loại
        public DataTable Hienthidulieu()
        {
            string query = "SELECT * FROM TheLoai";
            return kn.Hienthidulieu(query);
        }

        // các thao tác cơ bản
        public int Themtheloai(DTO_TheLoai tl)
        {
            string query = "INSERT INTO TheLoai(MaTheLoai, TenTheLoai) VALUES(@MaTheLoai, @TenTheLoai)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaTheLoai", tl.MaTheLoai),
                new SqlParameter("@TenTheLoai", tl.TenTheLoai)
            };
            return kn.Thaotacdulieu(query, parameters);
        }
        public int Capnhattheloai(DTO_TheLoai tl)
        {
            string query = "UPDATE TheLoai SET TenTheLoai = @TenTheLoai WHERE MaTheLoai = @MaTheLoai";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaTheLoai", tl.MaTheLoai),
                new SqlParameter("@TenTheLoai", tl.TenTheLoai)
            };
            return kn.Thaotacdulieu(query, parameters);
        }
        public int Xoatheloai(string MaTheLoai)
        {
            string query = "DELETE FROM TheLoai WHERE MaTheLoai = @MaTheLoai";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaTheLoai", MaTheLoai)
            };
            return kn.Thaotacdulieu(query, parameters);
        }

        // thao tác tìm kiếm
        public DataTable Timkiemtheloai(string tukhoa)
        {
            string query = "SELECT * FROM TheLoai WHERE MaTheLoai LIKE @Tukhoa OR TenTheLoai LIKE @Tukhoa";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Tukhoa", "%" + tukhoa + "%")
            };
            return kn.Hienthidulieu(query, parameters);
        }


        // kiểm tra mã thể loại xem tồn tại chưa
        public bool Kiemtramatheloai(string MaTheLoai)
        {

            string query = "SELECT COUNT(*) FROM TheLoai WHERE MaTheLoai = @MaTheLoai";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MaTheLoai", MaTheLoai)
            };
            int count = kn.Thucthiexcutescalar(query, parameters);
            return count > 0;
        }
    }
}
