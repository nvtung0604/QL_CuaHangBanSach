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
    public class BLL_TheLoai
    {
        private DAL_TheLoai dal_tl = new DAL_TheLoai();
        public DataTable Hienthidulieu()
        {
            return dal_tl.HienThiDuLieu();
        }
        public int Themtheloai(DTO_TheLoai tl)
        {
            return dal_tl.ThemTheLoai(tl);
        }
        public int Capnhattheloai(DTO_TheLoai tl)
        {
            return dal_tl.CapNhatTheLoai(tl);
        }
        public int Xoatheloai(string MaTheLoai)
        {
            return dal_tl.XoaTheLoai(MaTheLoai);
        }
        public DataTable Timkiemtheloai(string tukhoa)
        {
            return dal_tl.TimKiemTheLoai(tukhoa);
        }
        public bool Kiemtramatheloai(string MaTheLoai)
        {
            return dal_tl.KiemTraMaTheLoai(MaTheLoai);
        }
        public void XoaTheLoai(string mtl)
        {
            if (mtl == "ChuaCo")
            {
                throw new InvalidOperationException("Thể loại 'Chưa có' không thể bị xóa.");
            }

            // Cập nhật sách sang thể loại 'ChuaCo'
            dal_tl.CapNhatTheLoaiMacDinh(mtl);

            // Xóa thể loại
            dal_tl.XoaTheLoai(mtl);


        }
        public string ThemTheLoaiVaLayMa(DTO_TheLoai tl)
        {
            return dal_tl.ThemTheLoaiVaLayMa(tl);
        }

    }
}
