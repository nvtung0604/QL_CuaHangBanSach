using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHang
    {
        public string TenKH { get; set; }
        public string SDT { get; set; }

        public DTO_KhachHang() { }
        public DTO_KhachHang(string tenKH, string sdt)
        {
            TenKH = tenKH;
            SDT = sdt;
        }
    }
}
