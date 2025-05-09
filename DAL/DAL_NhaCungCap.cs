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
        public DataTable HienThiDuLieuNhaCungCap(string q = null)
        {
            
            string query = "SELECT * FROM NhaCungCap";
            return kn.HienThiDuLieu(query);      
        }

        public int ThemNhaCungCap (DTO_NhaCungCap ncc)
        {
            string query = "INSERT INTO NhaCungCap (MaNCC, TenNCC, SDT) VALUES (@MaNCC, @TenNCC, @SDT)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaNCC", ncc.MaNCC),
                new SqlParameter("@TenNCC", ncc.TenNCC),
                new SqlParameter("@SDT", ncc.SDT)
            };
            return kn.ThaoTacDuLieu(query, parameters);
        }
        public int CapNhatNhaCungCap(DTO_NhaCungCap ncc)
        {
            string query = "UPDATE NhaCungCap SET TenNCC = @TenNCC, @SDT = @SDT WHERE MaNCC = @MaNCC";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaNCC", ncc.MaNCC),
                new SqlParameter("@TenNCC", ncc.TenNCC),
                new SqlParameter("@SDT", ncc.SDT)
            };
            return kn.ThaoTacDuLieu(query, parameters);
        }
        public int XoaNhaCungCap(string MaNCC)
        {
            string query = "DELETE FROM NhaCungCap WHERE MaNCC = @MaNCC";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaNCC", MaNCC),
                
            };
            return kn.ThaoTacDuLieu(query, parameters);
        }
        public DataTable TimKiemNhaCungCap(string tukhoa)
        {
            string query = "SELECT * FROM NhaCungCap WHERE MaNCC LIKE @Tukhoa OR TenNCC LIKE @Tukhoa OR SDT LIKE @Tukhoa";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Tukhoa", "%" + tukhoa + "%")
            };
            return kn.HienThiDuLieu(query, parameters);
        }
        public bool KiemTraMaNhaCungCap(string MaNCC)
        {
            string query = "SELECT COUNT(*) FROM NhaCungCap WHERE MaNCC = @MaNCC";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaNCC", MaNCC)
            };
            return kn.ThucThiScalarSoNguyen(query, parameters) > 0;
        }
    }
}
