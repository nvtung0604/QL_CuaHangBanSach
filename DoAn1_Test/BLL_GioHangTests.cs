using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DTO;
namespace DoAn1_Test
{
    public class BLL_GioHangTests
    {
        BLL_GioHang gh = new BLL_GioHang();
        [Test]
        public void ThemGioHang_HopLe()
        {
            DTO_GioHang dTO_GioHang = new DTO_GioHang
            {
                MaGioHang = "GH202504080100",
                MaKH = "KH001",
                TrangThai = "Đã Thanh Toán",
                ThoiGian = DateTime.Now,
                MaNV = "NV001",
                TongTien = 86000
            };
            int result = gh.ThemDuLieuGioHang(dTO_GioHang);
            Assert.That(result, Is.EqualTo(1));
        }
        
        public void SuaGioHang_HopLe()
        {
            DTO_GioHang dTO_GioHang = new DTO_GioHang
            {
                MaGioHang = "GH20250408001",
                MaKH = "KH001",
                TrangThai = "Chưa thanh toán",
                ThoiGian = DateTime.Now,
                MaNV = "NV001",
                TongTien = 0
            };
            
        }
    }
}
