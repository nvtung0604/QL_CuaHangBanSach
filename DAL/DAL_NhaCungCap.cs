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
    public class DAL_NhaCungCap
    {
        DBKetNoi kn = new DBKetNoi();
        public DataTable Hienthidulieu(string q = null)
        {
            
            string query = "SELECT * FROM NhaCungCap";
            return kn.Hienthidulieu(query);      
        }

        public int Themnhacungcap (DTO_NhaCungCap ncc)
        {
            string query = "INSERT INTO NhaCungCap (MaNCC, TenNCC, SDT) VALUES (@MaNCC, @TenNCC, @SDT)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaNCC", ncc.MaNCC),
                new SqlParameter("@TenNCC", ncc.TenNCC),
                new SqlParameter("@SDT", ncc.SDT)
            };
            return kn.Thaotacdulieu(query, parameters);
        }
        public int Capnhatnhacungcap(DTO_NhaCungCap ncc)
        {
            string query = "UPDATE NhaCungCap SET TenNCC = @TenNCC, @SDT = @SDT WHERE MaNCC = @MaNCC";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaNCC", ncc.MaNCC),
                new SqlParameter("@TenNCC", ncc.TenNCC),
                new SqlParameter("@SDT", ncc.SDT)
            };
            return kn.Thaotacdulieu(query, parameters);
        }
        public int Xoanhacungcap(string MaNCC)
        {
            string query = "DELETE FROM NhaCungCap WHERE MaNCC = @MaNCC";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaNCC", MaNCC),
                
            };
            return kn.Thaotacdulieu(query, parameters);
        }
        public DataTable Timkiemnhacungcap(string tukhoa)
        {
            string query = "SELECT * FROM NhaCungCap WHERE MaNCC LIKE @Tukhoa OR TenNCC LIKE @Tukhoa OR SDT LIKE @Tukhoa";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Tukhoa", "%" + tukhoa + "%")
            };
            return kn.Hienthidulieu(query, parameters);
        }
        public bool Kiemtramanhacungcap(string MaNCC)
        {
            string query = "SELECT COUNT(*) FROM NhaCungCap WHERE MaNCC = @MaNCC";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaNCC", MaNCC)
            };
            return kn.Thucthiexcutescalar(query, parameters) > 0;
        }
    }
}
