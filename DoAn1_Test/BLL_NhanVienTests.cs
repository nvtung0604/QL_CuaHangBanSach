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
    public  class BLL_NhanVienTests
    {
        BLL_NhanVien nv = new BLL_NhanVien();
        [Test]
        public void ThemNhanVien_HopLe()
        {
            DTO_NhanVien dto = new DTO_NhanVien
            {
                MaNV = "NV004",
                TenNV = "Phạm Qúy An",
                SDT = "0977671411"
            };
            int result = nv.Themnhanvien(dto);
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void SuaNhanVien_HopLe()
        {
            DTO_NhanVien dto = new DTO_NhanVien
            {
                MaNV = "NV003",
                TenNV = "Lê Thị Thu",
                SDT = "0923456789"
            };
            int result = nv.Capnhatnhanvien(dto);
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void XoaNhanVien_HopLe()
        {
            DTO_NhanVien dto = new DTO_NhanVien
            {
                MaNV = "NV002",  
            };
            int result = nv.Xoanhanvien(dto.MaNV);
            Assert.That(result, Is.EqualTo(1));
        }
    }
}
