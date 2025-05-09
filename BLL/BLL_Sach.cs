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
        public DataTable HienThiDuLieu()
        {
            return dal_s.Hienthidulieu();
        }
        public int ThemSach(DTO_Sach s)
        {
            return dal_s.ThemSach(s);
        }
        public int CapNhatSach(DTO_Sach s)
        {
            return dal_s.CapNhatSach(s);
        }
        public int XoaSach(string MaSach)
        {
            return dal_s.XoaSach(MaSach);
        }
        public DataTable TimKiemSach(string tuKhoa)
        {
            return dal_s.TimKiemSach(tuKhoa);
        }
        public bool KiemTraMaSach(string MaSach)
        {
            return dal_s.KiemTraMaSach(MaSach);
        }
        public DataTable LayDanhSachTheLoai()
        {
            return dal_s.LayDanhSachTheLoai();
        }
        public DataTable Laydanhsachmancc()
        {
            return dal_s.LayDanhSachMaNCC();
        }
    }
}
