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
            return dal_tl.Hienthidulieu();
        }
        public int Themtheloai(DTO_TheLoai tl)
        {
            return dal_tl.Themtheloai(tl);
        }
        public int Capnhattheloai(DTO_TheLoai tl)
        {
            return dal_tl.Capnhattheloai(tl);
        }
        public int Xoatheloai(string MaTheLoai)
        {
            return dal_tl.Xoatheloai(MaTheLoai);
        }
        public DataTable Timkiemtheloai(string tukhoa)
        {
            return dal_tl.Timkiemtheloai(tukhoa);
        }
        public bool Kiemtramatheloai(string MaTheLoai)
        {
            return dal_tl.Kiemtramatheloai(MaTheLoai);
        }
    }
}
