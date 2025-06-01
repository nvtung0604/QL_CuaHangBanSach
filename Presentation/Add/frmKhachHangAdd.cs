using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Presentation.HopThoai;
namespace Presentation
{
    public partial class frmKhachHangAdd : Form
    {
        // các thành phần cần dùng
        BLL_KhachHang bll_kh = new BLL_KhachHang();
        Hopthoai ht = new Hopthoai();
        private frmKhachHang _fcha;
        public frmKhachHangAdd(frmKhachHang fcha = null)
        {
            InitializeComponent();
            _fcha = fcha; 
        }

        private DTO_KhachHang Laythongtintuform()
        {
            return new DTO_KhachHang
            {
                
                TenKH = txtTenKH.Text,
                SDT = txtSoDT.Text
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DTO_KhachHang kh = Laythongtintuform();
            if (bll_kh.KiemTraSDTKhachHang(kh.SDT))
            {
                if (bll_kh.CapNhatKhachHang(kh) > 0)
                {
                    ht.ThongBao(this,"Thông báo", "Cập nhật thông tin khách hàng thành công!", Guna.UI2.WinForms.MessageDialogIcon.Information);
                    _fcha.Hienthidulieu();
                }
                else
                {
                    ht.ThongBao(this,"Lỗi", "Không thể cập nhật thông tin khách hàng!", Guna.UI2.WinForms.MessageDialogIcon.Error);
                }
              
            }
            else
            {
                if (bll_kh.ThemKhachHang(kh) > 0)
                {
                    ht.ThongBao(this, "Thông báo", "Thêm thông tin khách hàng thành công!", Guna.UI2.WinForms.MessageDialogIcon.Information);
                    if (_fcha != null)
                    {
                        _fcha.Hienthidulieu();
                    }
                }
                else
                {
                    ht.ThongBao(this, "Lỗi", "Không thể thêm thông tin khách hàng!", Guna.UI2.WinForms.MessageDialogIcon.Error);
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
