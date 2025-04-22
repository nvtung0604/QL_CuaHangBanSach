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
        public DataTable Hienthidulieu()
        {
            return dal_kh.Hienthidulieu();
        }
        public int Themkhachhang(DTO_KhachHang kh)
        {
            return dal_kh.Themkhachhang(kh);
        }
        public int Capnhatkhachhang(DTO_KhachHang kh)
        {
            return dal_kh.Capnhatkhachhang(kh);
        }
        public int Xoakhachhang(string MaKH)
        {
            return dal_kh.Xoakhachhang(MaKH);
        }
        public DataTable Timkiemkhachhang(string tukhoa)
        {
            return dal_kh.Timkiemkhachhang(tukhoa);
        }
        public bool Kiemtramakhachhang(string MaKH)
        {
            return dal_kh.Kiemtramakhachhang(MaKH);
        }
    }
}
