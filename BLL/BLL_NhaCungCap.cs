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
            return dal_ncc.Hienthidulieu();
        }
        public int Themnhacungcap(DTO_NhaCungCap ncc)
        {
            return dal_ncc.Themnhacungcap(ncc);
        }
        public int Capnhatnhacungcap(DTO_NhaCungCap ncc)
        {
            return dal_ncc.Capnhatnhacungcap(ncc);
        }
        public int Xoanhacungcap(string MaNCC)
        {
            return dal_ncc.Xoanhacungcap(MaNCC);
        }
        public DataTable Timkiemnhacungcap(string tukhoa)
        {
            return dal_ncc.Timkiemnhacungcap(tukhoa);
        }
        public bool Kiemtramanhacungcap(string MaNCC)
        {
            return dal_ncc.Kiemtramanhacungcap(MaNCC);
        }
    }
}
