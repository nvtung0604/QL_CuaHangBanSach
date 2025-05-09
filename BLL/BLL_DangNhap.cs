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
    public class BLL_DangNhap
    {
        DAL_DangNhap dn = new DAL_DangNhap();
        public DataTable KiemTraDangNhap(DTO_DangNhap dto_dn)
        {
            return dn.KiemTraDangNhap(dto_dn);
        }
        public DataTable HienThiDuLieu()
        {
            return dn.HienThiDuLieu();
        }
        public int ThemTaiKhoan(DTO_DangNhap dto_dn)
        {
            return dn.ThemTaiKhoan(dto_dn);
        }
        public int CapNhatTaiKhoan(DTO_DangNhap dto_dn)
        {
            return dn.CapNhatTaiKhoan(dto_dn);
        }
        public int XoaTaiKhoan(string MaTaiKhoan)
        {
            return dn.XoaTaiKhoan(MaTaiKhoan);
        }
        public bool KiemTraMaTaiKhoanTonTai(string MaTaiKhoan)
        {
            return dn.KiemTraMaTaiKhoanTonTai(MaTaiKhoan);
        }
        public bool KiemTraTenTaiKhoanTonTai(string TenTaiKhoan)
        {
            return dn.KiemTraTenTaiKhoanTonTai(TenTaiKhoan);
        }
        public DataTable LoadMaNV()
        {
            return dn.LoadMaNV();
        }
        public string LayTenNhanVien(string username)
        {
            return dn.LayTenNhanVienTuTenTaiKhoan(username);
        }
        public string LayMaNhanVien(string username)
        {
            return dn.LayMaNhanVienTuTenTaiKhoan(username);
        }
        public string LayQuyenTuTen(string username)
        {
            return dn.LayQuyenTuNhanVien(username);
        }
        public DataTable TimKiemTaiKhoan(string tukhoa)
        {
            return dn.TimKiemTaiKhoan(tukhoa);
        }
    }
}
