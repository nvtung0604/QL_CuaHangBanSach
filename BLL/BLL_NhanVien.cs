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
            return dal_nv.Hienthidulieu();
        }

        public int Themnhanvien(DTO_NhanVien nv)
        {
            return dal_nv.Themnhanvien(nv);
        }
        public int Capnhatnhanvien(DTO_NhanVien nv)
        {
            return dal_nv.Capnhatnhanvien(nv);
        }
        public int Xoanhanvien(string MaKH)
        {
            return dal_nv.Xoanhanvien(MaKH);
        }
        public DataTable Timkiemnhanvien(string tukhoa)
        {
            return dal_nv.Timkiemnhanvien(tukhoa);
        }
        public bool Kiemtramanhanvien(string MaKH)
        {
            return dal_nv.Kiemtramanhanvien(MaKH);
        }
    }
}
