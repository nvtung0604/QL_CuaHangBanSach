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
    public class BLL_NhaCungCapTests
    {
        BLL_NhaCungCap ncc = new BLL_NhaCungCap();
        [Test]
        public void ThemNhaCC_HopLe()
        {
            DTO_NhaCungCap dto = new DTO_NhaCungCap
            {
                MaNCC = "NCC04",
                TenNCC = "NXB Ánh Trăng",
                SDT = "0667975438"
            };
            int result = ncc.Themnhacungcap(dto);
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void SuaNhaCC_HopLe()
        {
            DTO_NhaCungCap dto = new DTO_NhaCungCap
            {
                MaNCC = "NCC01",
                TenNCC = "NXB Trẻ",
                SDT = "0901234567"
            };
            int result = ncc.Capnhatnhacungcap(dto);
            Assert.That(result, Is.EqualTo(1));
        }
        public void XoaKhachHang()
        {
            DTO_NhaCungCap dto = new DTO_NhaCungCap
            {
                MaNCC = "KH001",

            };
            int result = ncc.Xoanhacungcap(dto.MaNCC);
            Assert.That(result, Is.EqualTo(1));
        }
    }
}
