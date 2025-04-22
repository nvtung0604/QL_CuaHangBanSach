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
    public class BLL_Sach
    {
        private DAL_Sach dal_s = new DAL_Sach();

        // Hiển thị dữ liệu
        public DataTable Hienthidulieu()
        {
            return dal_s.Hienthidulieu();
        }
        public int Themsach(DTO_Sach s)
        {
            return dal_s.Themsach(s);
        }
        public int Capnhatsach(DTO_Sach s)
        {
            return dal_s.Capnhatsach(s);
        }
        public int Xoasach(string MaSach)
        {
            return dal_s.Xoasach(MaSach);
        }
        public DataTable Timkiemsach(string tuKhoa)
        {
            return dal_s.Timkiemsach(tuKhoa);
        }
        public bool Kiemtramasach(string MaSach)
        {
            return dal_s.Kiemtramasach(MaSach);
        }
        public DataTable Laydanhsachtheloai()
        {
            return dal_s.Laydanhsachtheloai();
        }
        public DataTable Laydanhsachmancc()
        {
            return dal_s.Laydanhsachmancc();
        }
    }
}
