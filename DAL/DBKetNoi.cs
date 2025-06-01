using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBKetNoi
    {
        // thành phần sẽ dùng
        public static string chuoiketnoi = "Data Source=TUNG\\SQLEXPRESS;Initial Catalog=DB_UngDung_QuanLyCuaHangBanSach;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection con = new SqlConnection(chuoiketnoi);
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        // mở chuỗi kết nối
        public void MoKetNoi()
        {
            if (con.State  == ConnectionState.Closed)
                con.Open();
        }
        // đóng kết nối
        public void DongKetNoi()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        // hiển thị dữ liệu
        public DataTable HienThiDuLieu(string query, SqlParameter[] parameters = null)
        {
            MoKetNoi();
            cmd = new SqlCommand(query, con);
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            DongKetNoi();
            return dt;

        }

        // thêm, cập nhật, xóa dữ liệu
        public int ThaoTacDuLieu(string query, SqlParameter[] parameter = null)
        {
            int ketqua = 0;
            MoKetNoi();
            cmd = new SqlCommand(query, con);
            if (parameter != null)
            {
                cmd.Parameters.AddRange(parameter);
            }
            ketqua = cmd.ExecuteNonQuery();
            DongKetNoi();
            return ketqua;
        }
        // trả về một giá trị là sốInvalid object name 'GioHang
        public int ThucThiScalarSoNguyen(string query, SqlParameter[] parameters = null)
        {
            MoKetNoi();
            cmd = new SqlCommand(query, con);
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            int ketqua = Convert.ToInt32(cmd.ExecuteScalar());
            DongKetNoi();
            return ketqua;
        }
        // procedure
        public int ThaoTacDuLieuVoiProcedure(string procName, SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(procName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    return cmd.ExecuteNonQuery();
                }
            }
        }
        public object ThucThiExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            object result = null;

            using (SqlConnection conn = new SqlConnection(chuoiketnoi)) // chuoiKetNoi là chuỗi kết nối của bạn
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    result = cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    
                }
            }

            return result;
        }
        public SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            return conn;
        }


    }
}
