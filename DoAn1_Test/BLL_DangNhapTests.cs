using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DTO;
using NUnit.Framework;

namespace DoAn1_Test
{
    [TestFixture]
    public class BLL_DangNhapTests
    {
       
        private BLL_DangNhap dn;
        [SetUp]
        public void SetUp()
        {
            dn = new BLL_DangNhap();
        }
        [Test]
        public void DangNhap_DungTaiKhoanMatKhau_TraVeMotDong()
        {
            var dto = new DTO_DangNhap
            {
                TenTaiKhoan = "admin01",
                MatKhau = "ad01"
            };
            DataTable result = dn.KiemTraDangNhap(dto);
            Assert.That(result.Rows.Count, Is.EqualTo(1));
        }
        [Test]
        public void DangNhap_TaiKhoanSai_TraVeKhongDong()
        {
            var dto = new DTO_DangNhap
            {
                TenTaiKhoan = "ad",
                MatKhau = "1"
            };
            DataTable result = dn.KiemTraDangNhap(dto);
            Assert.That(result.Rows.Count, Is.EqualTo(0));
        }
        [Test]
        public void DangNhap_TenTaiKhoanBoTrong_TraVeKhongDong()
        {
            var dto = new DTO_DangNhap
            {
                TenTaiKhoan = "",
                MatKhau = "ad01"
            };
            DataTable result = dn.KiemTraDangNhap(dto);
            Assert.That(result.Rows.Count, Is.EqualTo(0));
        }
        [Test]
        public void DangNhap_MaKhauBoTrong_TraVeKhongDong()
        {
            var dto = new DTO_DangNhap
            {
                TenTaiKhoan = "admin01",
                MatKhau = ""
            };
            DataTable result = dn.KiemTraDangNhap(dto);
            Assert.That(result.Rows.Count, Is.EqualTo(0));
        }

    }
}
