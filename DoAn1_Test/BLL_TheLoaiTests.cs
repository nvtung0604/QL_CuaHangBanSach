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
    public class BLL_TheLoaiTests
    {
        BLL_TheLoai tl = new BLL_TheLoai();
        [Test]
        public void ThemTheLoai_HopLe()
        {
            DTO_TheLoai dto = new DTO_TheLoai
            {
                MaTheLoai = "TL06",
                TenTheLoai = "Viễn Tưởng",
                
            };
            int result = tl.Themtheloai(dto);
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void SuaTheLoai_HopLe()
        {
            DTO_TheLoai dto = new DTO_TheLoai
            {
                MaTheLoai = "TL04",
                TenTheLoai = "Giáo dục"

            };
            int result = tl.Capnhattheloai(dto);
            Assert.That(result, Is.EqualTo(1));
        }
        public void XoaKhachHang()
        {
            DTO_TheLoai dto = new DTO_TheLoai
            {
                MaTheLoai = "TL04",

            };
            int result = tl.Xoatheloai(dto.MaTheLoai);
            Assert.That(result, Is.EqualTo(1));
        }
    }
}
