﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Sach
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string TacGia { get; set; }
        public string MaTheLoai { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuongTon { get; set; }
        public string NhaXuatBan { get; set; }
        public int NamXuatBan { get; set; }
        public string MaNCC { get; set; }
        public byte[] HinhAnh { get; set; }

    }
}
