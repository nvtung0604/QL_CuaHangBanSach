using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class BLL_KhachHang
    {
        private DAL_KhachHang dal_kh = new DAL_KhachHang();
        public DataTable HienThiDuLieuKhachHang()
        {
            return dal_kh.HienThiDuLieuKhachHang();
        }
        public int ThemKhachHang(DTO_KhachHang kh)
        {
            return dal_kh.ThemKhachHang(kh);
        }
        public int CapNhatKhachHang(DTO_KhachHang kh)
        {
            return dal_kh.CapNhatKhachHang(kh);
        }
        public int XoaKhacHang(string SDT)
        {
            return dal_kh.XoaKhachHang(SDT);
        }
        public DataTable TimKiemKhachHang(string tukhoa)
        {
            return dal_kh.TimKiemKhachHang(tukhoa);
        }
        public bool KiemTraSDTKhachHang(string SDT)
        {
            return dal_kh.KiemTraSDTKhachHang(SDT);
        }
    }
}
