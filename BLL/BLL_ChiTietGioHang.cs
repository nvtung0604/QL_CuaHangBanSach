using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_ChiTietGioHang
    {
        DAL_ChiTietGioHang dal_ctgh = new DAL_ChiTietGioHang();
        public int ThemDuLieuVaoChiTietHoaDon(DTO_ChiTietGioHang ctgh)
        {
            return dal_ctgh.ThemChiTietHoaDon(ctgh);
        }
        public DataTable HienThiDuLieu(string MaGioHang)
        {
            return dal_ctgh.HienThiDuLieu(MaGioHang);
        }
        public string LayChiTietGioHangText(string maGiohang)
        {
            DataTable dt = dal_ctgh.HienThiDuLieu(maGiohang);
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("----- Danh sách sách đã mua -----");
            sb.AppendLine($"{"Tên sách",-30} {"SL",5} {"Đơn giá",15} {"Thành tiền",15}");

            foreach (DataRow row in dt.Rows)
            {
                string tenSach = row["TenSach"].ToString();
                int soLuong = Convert.ToInt32(row["SoLuong"]);
                decimal giaBan = Convert.ToDecimal(row["GiaBan"]);
                decimal thanhTien = soLuong * giaBan;

                sb.AppendLine($"{tenSach,-30} {soLuong,5} {giaBan,15:N0} {thanhTien,15:N0}");
            }

            return sb.ToString();
        }

    }
}
