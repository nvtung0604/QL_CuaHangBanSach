using BLL;
using DTO;
using Presentation.HopThoai;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Add
{
    public partial class frmTheLoaiAdd : Form
    {
        // các thành phần cần dùng
        BLL_TheLoai bll_tl = new BLL_TheLoai();
        Hopthoai ht = new Hopthoai();
        private frmTheLoai _fcha;
        public frmTheLoaiAdd(frmTheLoai fcha)
        {
            InitializeComponent();
            _fcha = fcha;
        }
        private DTO_TheLoai Laythongtintuform()
        {
            return new DTO_TheLoai
            {
                MaTheLoai = txtMaTL.Text,
                TenTheLoai = txtTenTL.Text
            };
        }
        private void frmTheLoaiAdd_Load(object sender, EventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DTO_TheLoai tl = Laythongtintuform();
            if (bll_tl.Kiemtramatheloai(tl.MaTheLoai))
            {
                if (bll_tl.Capnhattheloai(tl) > 0)
                {
                    ht.ThongBao(this, "Thông báo", "Cập nhật thông tin thể loại thành công!", Guna.UI2.WinForms.MessageDialogIcon.Information);
                    _fcha.Hienthidulieu();
                }
                else
                {
                    ht.ThongBao(this, "Lỗi", "Không thể cập nhật thông tin thể loại!", Guna.UI2.WinForms.MessageDialogIcon.Error);
                }

            }
            else
            {
                if (bll_tl.Themtheloai(tl) > 0)
                {
                    ht.ThongBao(this, "Thông báo", "Thêm thông tin thể loại thành công!", Guna.UI2.WinForms.MessageDialogIcon.Information);
                    _fcha.Hienthidulieu();
                }
                else
                {
                    ht.ThongBao(this, "Lỗi", "Không thể thêm thông tin thể loại!", Guna.UI2.WinForms.MessageDialogIcon.Error);
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
