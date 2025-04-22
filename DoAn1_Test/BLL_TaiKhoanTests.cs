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
    public class BLL_TaiKhoanTests
    {
        BLL_DangNhap dn = new BLL_DangNhap();
        [Test]
        public void ThemTaiKhoan_HopLe_TraVeMotDong()
        {
            var tk = new DTO_DangNhap
            {
                MaTaiKhoan = "TK003",
                TenTaiKhoan = "nhanvien03",
                MatKhau = "nv03",
                Role = "Nhân Viên",
                MaNV = "NV002"

            };
            int result = dn.ThemTaiKhoan(tk);
            Assert.That(result, Is.EqualTo(1));
        }
        
        [Test]
        public void CapNhatTaiKhoan_HopLe_TraVeMotDong()
        {
            var tk = new DTO_DangNhap
            {
                MaTaiKhoan = "TK001",
                TenTaiKhoan = "admin01",
                MatKhau = "ad01",
                Role = "Admin",
                MaNV = "NV001"

            };
            int result = dn.CapNhatTaiKhoan(tk);
            Assert.That(result, Is.EqualTo(1));
        }
        public void XoaTaiKhoan_HopLe_TraVeMotDong()
        {
            var tk = new DTO_DangNhap
            {
                MaTaiKhoan = "TKOO2"
            };
            int result = dn.XoaTaiKhoan(tk.MaTaiKhoan);
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void ThemTaiKhoan_ThieuMaTaiKhoan_TraVeKhongDong()
        {
            var tk = new DTO_DangNhap
            {
                MaTaiKhoan = "",
                TenTaiKhoan = "nhanvien02",
                MatKhau = "nv02",
                Role = "Nhân Viên",
                MaNV = "NV003"

            };
            int result = dn.ThemTaiKhoan(tk);
            Assert.That(result, Is.EqualTo(0));
        }

    }
}
