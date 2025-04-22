using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using Presentation.HopThoai;
namespace Presentation
{
    public partial class frmNhanVienAdd : Form
    {
        private frmNhanVien _fcha;
        BLL_NhanVien bll_nv = new BLL_NhanVien();
        Hopthoai ht = new Hopthoai();
        public frmNhanVienAdd(frmNhanVien fcha)
        {
            InitializeComponent();
            _fcha = fcha;
        }
        private DTO_NhanVien Laythongtintuform()
        {
            return new DTO_NhanVien
            {
                MaNV = txtMaNV.Text,
                TenNV = txtTenNV.Text,
                SDT = txtSoDT.Text
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DTO_NhanVien nv = Laythongtintuform();
            if (bll_nv.Kiemtramanhanvien(nv.MaNV))
            {
                if (bll_nv.Capnhatnhanvien(nv) > 0)
                {
                    ht.ThongBao(this, "Thông báo", "Cập nhật thông tin nhân viên thành công!", Guna.UI2.WinForms.MessageDialogIcon.Information);
                    _fcha.Hienthidulieu();
                }
                else
                {
                    ht.ThongBao(this, "Lỗi", "Không thể cập nhật thông tin nhân viên!", Guna.UI2.WinForms.MessageDialogIcon.Error);
                }
            }
            else
            {
                if (bll_nv.Themnhanvien(nv) > 0)
                {
                    ht.ThongBao(this, "Thông báo", "Thêm thông tin nhân viên thành công!", Guna.UI2.WinForms.MessageDialogIcon.Information);
                    _fcha.Hienthidulieu();
                }
                else
                {
                    ht.ThongBao(this, "Lỗi", "Không thể thêm thông tin nhân viên!", Guna.UI2.WinForms.MessageDialogIcon.Error);
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNhanVienAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
