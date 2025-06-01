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
    public class BLL_NhanVien
    {
        private DAL_NhanVien dal_nv = new DAL_NhanVien();

        public DataTable Hienthidulieu()
        {
            return dal_nv.HienThiDuLieu();
        }

        public int Themnhanvien(DTO_NhanVien nv)
        {
            return dal_nv.ThemNhanVien(nv);
        }
        public int Capnhatnhanvien(DTO_NhanVien nv)
        {
            return dal_nv.CapNhatNhanVien(nv);
        }
        public int Xoanhanvien(string MaKH)
        {
            return dal_nv.XoaNhanVien(MaKH);
        }
        public DataTable Timkiemnhanvien(string tukhoa)
        {
            return dal_nv.TimKiemNhanVien(tukhoa);
        }
        public bool Kiemtramanhanvien(string MaNV)
        {
            return dal_nv.KiemTraMaNhanVien(MaNV);
        }
        public bool KiemTraTaiKhoanAdmin(string MaNV)
        {
            return dal_nv.KiemTraTaiKhoanAdmin(MaNV);
        }

        public string ThemNhanVienVaLayMa(DTO_NhanVien nv)
        {
            return dal_nv.ThemNhanVienVaLayMa(nv);
        }
    }
}
