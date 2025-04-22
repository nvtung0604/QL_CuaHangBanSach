using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    // kế thừa
    public class DTO_POS : DTO_Sach
    {
        public int SoLuong { get; set; } = 1;
        public decimal ThanhTien => GiaBan * SoLuong;


    }
}
