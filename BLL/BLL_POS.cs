using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_POS
    {
        //private DAL_Sach dal_s = new DAL_Sach();
        //private DAL_TheLoai dal_tl = new DAL_TheLoai();


        //public DataTable LayDanhSach()
        //{
        //    return dal_s.Hienthidulieu();
        //}
        //// Lấy danh sách thể loại
        //public DataTable LayDanhSachTheLoai()
        //{
        //    return dal_tl.Hienthidulieu();
        //}
        private DAL_POS dal_pos = new DAL_POS();
        private List<DAL_POS> giohang = new List<DAL_POS>();
        public DataTable LayDanhSach() => dal_pos.LayDanhSach();
        public DataTable LayDanhSachTheLoai() => dal_pos.LayDanhSachTheLoai();
        public DataTable LayDanhSachTheoMa(string MaSach) => dal_pos.LayDanhSachTheoMa(MaSach);
        // Chuyển DataTable thành List<DTO_POS>
        public List<DTO_POS> ChuyenDoiSangListPOS(DataTable dt)
        {
            List<DTO_POS> list = new List<DTO_POS>();

            foreach (DataRow row in dt.Rows)
            {
                DTO_POS item = new DTO_POS
                {
                    MaSach = row["MaSach"].ToString(),
                    TenSach = row["TenSach"].ToString(),
                    MaTheLoai = row["MaTheLoai"].ToString(),
                    GiaBan = Convert.ToDecimal(row["GiaBan"]),
                    HinhAnh = row["HinhAnh"] is DBNull ? null : (byte[])row["HinhAnh"],
                    SoLuong = 1
                };

                list.Add(item);
            }

            return list;
        }
        public List<DTO_POS> LocSachTheoTheLoai(string theloai)
        {
            var all = ChuyenDoiSangListPOS(LayDanhSach());
            return all.Where(s => s.MaTheLoai == theloai).ToList();
        }
        public int CapNhatTrangThai(string MaGioHang)
        {
            return dal_pos.CapNhatTrangThai(MaGioHang);
        }
        public DataTable HienThiGioHangDaThanhToan()
        {
            return dal_pos.HienThiGioHangDaThanhToan();
        }
        public DataTable HienThiChiTietGioHangTheoMa(string magiohang)
        {
            return dal_pos.HienThiChiTietGioHangTheoMa(magiohang);
        }
        public int CapNhatChiTietGioHang(string magGioHang, string maSach, int soLuong, decimal giaBan)
        {
            return dal_pos.CapNhatChiTietGioHang(magGioHang, maSach, soLuong, giaBan);
        }
        public int LaySoLuongTonTheoMa(string maS)
        {
            return dal_pos.LaySoLuongTonTheoMa(maS);
        }
        public bool KiemTraMaHoaDon(string magh)
        {
            return dal_pos.KiemTraMaHoaDon(magh);
        }
        public int TruTonKho(string ms, int sl)
        {
            return dal_pos.TruTonKho(ms, sl);
        }
    }
}
