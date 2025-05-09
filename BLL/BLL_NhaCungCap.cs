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
    public class BLL_NhaCungCap
    {
        DAL_NhaCungCap dal_ncc = new DAL_NhaCungCap();
        public DataTable Hienthidulieu()
        {
            return dal_ncc.HienThiDuLieuNhaCungCap();
        }
        public int Themnhacungcap(DTO_NhaCungCap ncc)
        {
            return dal_ncc.ThemNhaCungCap(ncc);
        }
        public int Capnhatnhacungcap(DTO_NhaCungCap ncc)
        {
            return dal_ncc.CapNhatNhaCungCap(ncc);
        }
        public int Xoanhacungcap(string MaNCC)
        {
            return dal_ncc.XoaNhaCungCap(MaNCC);
        }
        public DataTable Timkiemnhacungcap(string tukhoa)
        {
            return dal_ncc.TimKiemNhaCungCap(tukhoa);
        }
        public bool Kiemtramanhacungcap(string MaNCC)
        {
            return dal_ncc.KiemTraMaNhaCungCap(MaNCC);
        }
    }
}
