using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DTO;
using NUnit.Framework;
using System.IO;
namespace DoAn1_Test
{
    [TestFixture]
    public class BLL_SachTests
    {
        BLL_Sach s = new BLL_Sach();
        [Test]
        public void ThemSach_HopLe()
        {
            DTO_Sach dTO_Sach = new DTO_Sach
            {
                MaSach = "MS001",
                TenSach = "Tử thần phiêu nguyệt",
                TacGia = "Pyong Wol",
                MaTheLoai = "TL01",
                MaNCC = "NCC02",
                GiaBan = 67000,
                SoLuongTon = 2,
                NhaXuatBan = "NXB Trẻ",
                NamXuatBan = 2018,
                HinhAnh = File.ReadAllBytes(@"D:\Workspace\Project1\DoAn1\Images\Img_Sach\asach_demtruongtamtoi.png") // Đường dẫn thực tế
            };
            int result = s.Themsach(dTO_Sach);
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void SuaSach_HopLe()
        {
            DTO_Sach dTO_Sach = new DTO_Sach
            {
                MaSach = "S001",
                TenSach = "Đêm trường tăm tối",
                TacGia = "Tử Kim Trần",
                MaTheLoai = "TL04",
                MaNCC = "NCC01",
                GiaBan = 85000,
                SoLuongTon = 0,
                NhaXuatBan = "NXB Lao Động",
                NamXuatBan = 2018,
                //HinhAnh = File.ReadAllBytes(@"D:\Workspace\Project1\DoAn1\Images\Img_Sach\asach_demtruongtamtoi.png") // Đường dẫn thực tế
            };
            int result = s.Capnhatsach(dTO_Sach);
            Assert.That(result, Is.EqualTo(1));
        }
    }
}
