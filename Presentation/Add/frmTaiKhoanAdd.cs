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
    public partial class frmTaiKhoanAdd : Form
    {
        frmTaiKhoan _fcha;
        BLL_DangNhap bll_dn = new BLL_DangNhap();
        Hopthoai ht = new Hopthoai();
        public frmTaiKhoanAdd(frmTaiKhoan fcha)
        {
            InitializeComponent();
            _fcha = fcha;
        }
        private DTO_DangNhap Laythongtintuform()
        {
            return new DTO_DangNhap
            {
                MaTaiKhoan = txtMaTaiK.Text,
                TenTaiKhoan = txtTenTK.Text,
                MatKhau = txtMatK.Text,
                Role = cboRole.Text,
                MaNV = cboTenNV.SelectedValue?.ToString()
            };
        }
        public void LoadMaNV()
        {
            cboTenNV.DataSource = bll_dn.LoadMaNV();
            cboTenNV.DisplayMember = "TenNV";
            cboTenNV.ValueMember = "MaNV";
            
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTaiKhoanAdd_Load(object sender, EventArgs e)
        {
            LoadMaNV();  // Load danh sách nhân viên vào cboTenNV

            // Kiểm tra nếu form đang ở chế độ thêm (không có tài khoản được chọn)
            if (string.IsNullOrEmpty(txtMaTaiK.Text))
            {
                cboTenNV.SelectedIndex = -1;  // Đặt ô về trạng thái trống
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu dữ liệu bị thiếu
                if (string.IsNullOrEmpty(txtMaTaiK.Text) ||
                    string.IsNullOrEmpty(txtTenTK.Text) ||
                    string.IsNullOrEmpty(txtMatK.Text) ||
                    string.IsNullOrEmpty(cboRole.Text) ||
                    cboTenNV.SelectedValue == null)
                {
                    ht.ThongBao(this, "Thông báo", "Vui lòng kiểm tra lại, có trường dữ liệu bị thiếu!", Guna.UI2.WinForms.MessageDialogIcon.Warning);
                    return; // Dừng tiến trình nếu dữ liệu thiếu
                }

                // Lấy thông tin từ form
                DTO_DangNhap dn = Laythongtintuform();

                // Kiểm tra nếu tài khoản đã tồn tại
                if (bll_dn.KiemTraTenTaiKhoanTonTai(dn.MaTaiKhoan))
                {
                    if (bll_dn.CapNhatTaiKhoan(dn) > 0)
                    {
                        ht.ThongBao(this, "Thông báo", "Cập nhật thông tin tài khoản thành công!", Guna.UI2.WinForms.MessageDialogIcon.Information);
                        _fcha.HienThiDuLieu();
                    }
                    else
                    {
                        ht.ThongBao(this, "Lỗi", "Không thể cập nhật thông tin tài khoản!", Guna.UI2.WinForms.MessageDialogIcon.Error);
                    }
                }
                else
                {
                    if (bll_dn.ThemTaiKhoan(dn) > 0)
                    {
                        ht.ThongBao(this, "Thông báo", "Thêm thông tin tài khoản thành công!", Guna.UI2.WinForms.MessageDialogIcon.Information);
                        _fcha.HienThiDuLieu();
                    }
                    else
                    {
                        ht.ThongBao(this, "Lỗi", "Không thể thêm thông tin tài khoản!", Guna.UI2.WinForms.MessageDialogIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                ht.ThongBao(this, "Lỗi", $"Đã xảy ra lỗi: {ex.Message}", Guna.UI2.WinForms.MessageDialogIcon.Error);
            }
        }
    }
    
}
