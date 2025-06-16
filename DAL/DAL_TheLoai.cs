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
        public DataTable HienThiDuLieu()
        {
            string query = @"
            SELECT 
                tl.MaTheLoai,
                tl.TenTheLoai,
                COUNT(s.MaSach) AS SoLuongSach
            FROM 
                TheLoai tl
            LEFT JOIN 
                Sach s ON tl.MaTheLoai = s.MaTheLoai AND s.isDelete = 0
            WHERE 
                tl.isDelete = 0
            GROUP BY 
                tl.MaTheLoai, tl.TenTheLoai
            ";


            return kn.HienThiDuLieu(query);
        }

        // các thao tác cơ bản
        public int ThemTheLoai(DTO_TheLoai tl)
        {
            string query = "INSERT INTO TheLoai(MaTheLoai, TenTheLoai) VALUES(@MaTheLoai, @TenTheLoai)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaTheLoai", tl.MaTheLoai),
                new SqlParameter("@TenTheLoai", tl.TenTheLoai)
            };
            return kn.ThaoTacDuLieu(query, parameters);
        }
        public int CapNhatTheLoai(DTO_TheLoai tl)
        {
            string query = "UPDATE TheLoai SET TenTheLoai = @TenTheLoai WHERE MaTheLoai = @MaTheLoai";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaTheLoai", tl.MaTheLoai),
                new SqlParameter("@TenTheLoai", tl.TenTheLoai)
            };
            return kn.ThaoTacDuLieu(query, parameters);
        }
        public int XoaTheLoai(string MaTheLoai)
        {
            string query = "UPDATE TheLoai SET isDelete = 1 WHERE MaTheLoai = @MaTheLoai";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaTheLoai", MaTheLoai)
            };
            return kn.ThaoTacDuLieu(query, parameters);
        }

        // thao tác tìm kiếm
        public DataTable TimKiemTheLoai(string tukhoa)
        {
            string query = "SELECT * FROM TheLoai WHERE MaTheLoai LIKE @Tukhoa OR TenTheLoai LIKE @Tukhoa AND isDelete = 0";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Tukhoa", "%" + tukhoa + "%")
            };
            return kn.HienThiDuLieu(query, parameters);
        }


        // kiểm tra mã thể loại xem tồn tại chưaa
        public bool KiemTraMaTheLoai(string MaTheLoai)
        {

            string query = "SELECT COUNT(*) FROM TheLoai WHERE MaTheLoai = @MaTheLoai";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MaTheLoai", MaTheLoai)
            };
            int count = kn.ThucThiScalarSoNguyen(query, parameters);
            return count > 0;
        }
        public int CapNhatTheLoaiMacDinh(string mtl)
        {
            string query = "UPDATE Sach SET MaTheLoai = 'ChuaCo' WHERE MaTheLoai = @MaTheLoai";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaTheLoai", mtl)
            };
            return kn.ThaoTacDuLieu(query, parameters);
        }
        public string ThemTheLoaiVaLayMa(DTO_TheLoai tl)
        {
            using (SqlConnection conn = kn.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_ThemTheLoaiTraMaTL", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TenTheLoai", tl.TenTheLoai);

                    SqlParameter maNVOut = new SqlParameter("@MaTLMoi", SqlDbType.VarChar, 20)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(maNVOut);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return maNVOut.Value.ToString();
                }
            }
        }
    }
}
