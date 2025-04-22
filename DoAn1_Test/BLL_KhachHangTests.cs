using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DTO;
using NUnit.Framework;
namespace DoAn1_Test
{
    [TestFixture]
    public class BLL_KhachHangTests
    {
        BLL_KhachHang kh = new BLL_KhachHang();
        [Test]
        public void ThemKhachHang_HopLe()
        {
            DTO_KhachHang dto = new DTO_KhachHang
            {
                MaKH = "KH005",
                TenKH = "Lâm Trần Tuấn",
                SDT = "0667669978"
            };
            int result = kh.Themkhachhang(dto);
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void SuaKhachHang_HopLe()
        {
            DTO_KhachHang dto = new DTO_KhachHang
            {
                MaKH = "KH001",
                TenKH = "Nguyễn Văn An",
                SDT = "0901111222"
            };
            int result = kh.Capnhatkhachhang(dto);
            Assert.That(result, Is.EqualTo(1));
        }
        public void XoaKhachHang()
        {
            DTO_KhachHang dto = new DTO_KhachHang
            {
                MaKH = "KH001",
                
            };
            int result = kh.Xoakhachhang(dto.MaKH);
            Assert.That(result, Is.EqualTo(1));
        }
    }
}
