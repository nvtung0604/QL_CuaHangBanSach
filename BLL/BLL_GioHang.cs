using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_GioHang
    {
        DAL_GioHang dal_gh = new DAL_GioHang();
        public int ThemDuLieuGioHang(DTO_GioHang gh)
        {
            return dal_gh.ThemHoaDon(gh);
        }
        public DataTable HienThiDuLieu()
        {
            return dal_gh.HienThiDuLieu();
        }
        public string ThemGioHangSinhMa(DTO_GioHang gh)
        {
            return dal_gh.ThemDuLieuGioHangSinhMa(gh);
        }
        // từ đây
        public DataTable LayTongTienTheoNhanVien()
        {
            return dal_gh.LayTongTienTheoNhanVien();
        }

        // Lấy tổng tiền theo nhân viên trong khoảng thời gian
        public DataTable LayTongTienTheoNhanVienTrongKhoang(DateTime tuNgay, DateTime denNgay)
        {
            return dal_gh.LayTongTienTheoNhanVienTrongKhoang(tuNgay, denNgay);
        }

        // Lấy chi tiết hóa đơn đã thanh toán trong khoảng thời gian
        public DataTable LayChiTietHoaDonTrongKhoang(DateTime tuNgay, DateTime denNgay)
        {
            return dal_gh.LayChiTietHoaDonTrongKhoang(tuNgay, denNgay);
        }
        public DataTable LayDuLieuTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            return dal_gh.LayDuLieuTheoNgay(tuNgay, denNgay);
        }
        public DataTable HienThiDuLieuChoBaoCao()
        {
            return dal_gh.HienThiDuLieuChoBaoCao();
        }
        public int XoaDuLieu(string MaGioHang)
        {
            return dal_gh.XoaHoaDon(MaGioHang);
        }
        public DataTable HienThiDuLieu2()
        {
            return dal_gh.HienThiDuLieu2();
        }
        public DataTable LaySDTKhachHang(string sdt)
        {
            return dal_gh.LaySDTKhachHang(sdt);
        }
        public string LayTenKhachHangTuSDT(string sdt)
        {
            return dal_gh.LayTenKhacHangTuSDT(sdt);
        }
    }

}
