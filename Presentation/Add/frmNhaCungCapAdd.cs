using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation.HopThoai;
using DTO;
namespace Presentation
{
    public partial class frmNhaCungCapAdd : Form
    {

        

        // các thành phần sử dụng
        private frmNhaCungCap _fcha;
        BLL_NhaCungCap bll_ncc = new BLL_NhaCungCap();
        Hopthoai ht = new Hopthoai();

        private bool isEdit = false;
        private string maNCC = "";
        public frmNhaCungCapAdd(frmNhaCungCap fcha)
        {
            InitializeComponent();
            _fcha = fcha;
        }
        public frmNhaCungCapAdd(frmNhaCungCap fcha, bool isEdit, string ma, string ten, string sdt)
           : this(fcha)
        {
            this.isEdit = isEdit;
            this.maNCC = ma;
            txtTenNCC.Text = ten;
            txtSoDT.Text = sdt;
        }
        public DTO_NhaCungCap Laythongtintuform()
        {
            return new DTO_NhaCungCap
            {
                MaNCC = maNCC,
                TenNCC = txtTenNCC.Text,
                SDT = txtSoDT.Text
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DTO_NhaCungCap ncc = Laythongtintuform();

            if (isEdit)
            {
                // Cập nhật
                if (bll_ncc.Capnhatnhacungcap(ncc) > 0)
                {
                    ht.ThongBao(this, "Thông báo", "Cập nhật thông tin nhà cung cấp thành công!", Guna.UI2.WinForms.MessageDialogIcon.Information);
                    _fcha?.Hienthidulieu();
                }
                else
                {
                    ht.ThongBao(this, "Lỗi", "Không thể cập nhật thông tin nhà cung cấp!", Guna.UI2.WinForms.MessageDialogIcon.Error);
                }
            }
            else
            {
                // Thêm mới
                string mancc = bll_ncc.ThemNhaCungCapVaLayMa(ncc);
                if (!string.IsNullOrEmpty(mancc))
                {
                    ht.ThongBao(this, "Thông báo", $"Thêm nhà cung cấp thành công! Mã NCC: {mancc}", Guna.UI2.WinForms.MessageDialogIcon.Information);
                    _fcha?.Hienthidulieu();
                }
                else
                {
                    ht.ThongBao(this, "Lỗi", "Không thể thêm thông tin nhà cung cấp!", Guna.UI2.WinForms.MessageDialogIcon.Error);
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
