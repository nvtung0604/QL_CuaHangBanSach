using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhanVien
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string SDT { get; set; }
        public DTO_NhanVien() { }
        public DTO_NhanVien(string maNV, string tenNV, string sdt)
        {
            MaNV = maNV;
            TenNV = tenNV;
            SDT = sdt;
        }
    }
}
