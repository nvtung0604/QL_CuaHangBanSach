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
        private frmTaiKhoan _fcha;
        BLL_DangNhap bll_dn = new BLL_DangNhap();
        Hopthoai ht = new Hopthoai();

        private bool isEdit = false;     // phân biệt thêm / sửa
        private string maTK = "";        // lưu mã tài khoản để sửa

        // Constructor cho thêm tài khoản
        public frmTaiKhoanAdd(frmTaiKhoan fcha)
        {
            InitializeComponent();
            _fcha = fcha;
            LoadMaNV();
        }

        // Constructor cho cập nhật tài khoản
        public frmTaiKhoanAdd(frmTaiKhoan fcha, bool isEdit, string maTK, string tenTK, string matKhau, string role, string maNV)
            : this(fcha)
        {
            this.isEdit = isEdit;
            this.maTK = maTK;

            
            txtTenTK.Text = tenTK;
            txtMatK.Text = matKhau;
            cboRole.Text = role;
            cboTenNV.SelectedValue = maNV;

            //txtMaTaiK.Enabled = false; // Không cho sửa mã tài khoản khi cập nhật
        }

        private DTO_DangNhap Laythongtintuform()
        {
            return new DTO_DangNhap
            {
                MaTaiKhoan = maTK,  
                TenTaiKhoan = txtTenTK.Text.Trim(),
                MatKhau = txtMatK.Text.Trim(),
                Role = cboRole.Text.Trim(),
                MaNV = cboTenNV.SelectedValue?.ToString()
            };
        }

        public void LoadMaNV()
        {
            cboTenNV.DataSource = bll_dn.LoadMaNV();
            cboTenNV.ValueMember = "MaNV";
            cboTenNV.DisplayMember = "TenNV";
            cboTenNV.SelectedIndex = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTaiKhoanAdd_Load(object sender, EventArgs e)
        {
            LoadMaNV(); // Tải danh sách nhân viên vào ComboBox

            // Nếu là chế độ cập nhật
            if (!string.IsNullOrEmpty(maTK))
            {
                cboTenNV.SelectedValue = _fcha.dgTaiKhoan.CurrentRow.Cells["dgcMaNV"].Value.ToString();
            }
            else
            {
                cboTenNV.SelectedIndex = -1; // Đặt về mặc định khi thêm mới
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (
                    string.IsNullOrWhiteSpace(txtTenTK.Text) ||
                    string.IsNullOrWhiteSpace(txtMatK.Text) ||
                    string.IsNullOrWhiteSpace(cboRole.Text) ||
                    cboTenNV.SelectedValue == null)
                {
                    ht.ThongBao(this, "Thông báo", "Vui lòng nhập đầy đủ thông tin!", Guna.UI2.WinForms.MessageDialogIcon.Warning);
                    return;
                }

                DTO_DangNhap dn = Laythongtintuform();

                // Nếu là thêm mới
                if (!isEdit)
                {
                    // Kiểm tra tên tài khoản đã tồn tại
                    if (bll_dn.KiemTraTenTaiKhoanTonTai(dn.TenTaiKhoan))
                    {
                        ht.ThongBao(this, "Thông báo", "Tên tài khoản đã tồn tại, vui lòng chọn tên khác!", Guna.UI2.WinForms.MessageDialogIcon.Warning);
                        return;
                    }

                    // Thêm tài khoản mới
                    if (bll_dn.ThemTaiKhoan(dn) > 0)
                    {
                        ht.ThongBao(this, "Thành công", "Thêm tài khoản thành công!", Guna.UI2.WinForms.MessageDialogIcon.Information);
                        _fcha.HienThiDuLieu();
                        this.Close();
                    }
                    else
                    {
                        ht.ThongBao(this, "Lỗi", "Không thể thêm tài khoản!", Guna.UI2.WinForms.MessageDialogIcon.Error);
                    }
                }
                else // Nếu là cập nhật
                {
                    // Cập nhật tài khoản
                    if (bll_dn.CapNhatTaiKhoan(dn) > 0)
                    {
                        ht.ThongBao(this, "Thành công", "Cập nhật tài khoản thành công!", Guna.UI2.WinForms.MessageDialogIcon.Information);
                        _fcha.HienThiDuLieu();
                        this.Close();
                    }
                    else
                    {
                        ht.ThongBao(this, "Lỗi", "Không thể cập nhật tài khoản!", Guna.UI2.WinForms.MessageDialogIcon.Error);
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