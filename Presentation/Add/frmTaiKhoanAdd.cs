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
        frmTaiKhoan _fcha; // Form cha
        BLL_DangNhap bll_dn = new BLL_DangNhap();
        Hopthoai ht = new Hopthoai();

        public frmTaiKhoanAdd(frmTaiKhoan fcha)
        {
            InitializeComponent();
            _fcha = fcha;
        }
        public string role;
        private DTO_DangNhap Laythongtintuform()
        {
            // Lấy thông tin từ các điều khiển trên form
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
            cboTenNV.ValueMember = "MaNV";          // Mã nhân viên
            cboTenNV.DisplayMember = "TenNV";       // Tên nhân viên
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTaiKhoanAdd_Load(object sender, EventArgs e)
        {
            LoadMaNV(); // Tải danh sách nhân viên vào ComboBox

            // Nếu là chế độ cập nhật
            if (!string.IsNullOrEmpty(txtMaTaiK.Text))
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
                if (string.IsNullOrEmpty(txtMaTaiK.Text) ||
                    string.IsNullOrEmpty(txtTenTK.Text) ||
                    string.IsNullOrEmpty(txtMatK.Text) ||
                    string.IsNullOrEmpty(cboRole.Text) ||
                    cboTenNV.SelectedValue == null)
                {
                    ht.ThongBao(this, "Thông báo", "Vui lòng kiểm tra lại, có trường dữ liệu bị thiếu!", Guna.UI2.WinForms.MessageDialogIcon.Warning);
                    return;
                }
                // Kiểm tra tên tài khoản đã tồn tại
                if (bll_dn.KiemTraTenTaiKhoanTonTai(txtTenTK.Text))
                {
                    ht.ThongBao(this, "Thông báo", "Tên tài khoản đã tồn tại, vui lòng chọn tên khác!", Guna.UI2.WinForms.MessageDialogIcon.Warning);
                    return; // Dừng tiến trình nếu tên tài khoản đã tồn tại
                }

                // Lấy dữ liệu từ form
                DTO_DangNhap dn = Laythongtintuform();
                role = cboRole.Text;

                MessageBox.Show(role);
                // Xử lý cập nhật hoặc thêm mới
                if (bll_dn.KiemTraMaTaiKhoanTonTai(dn.MaTaiKhoan))
                {
                    if (bll_dn.CapNhatTaiKhoan(dn) > 0)
                    {
                        ht.ThongBao(this, "Thông báo", "Cập nhật tài khoản thành công!", Guna.UI2.WinForms.MessageDialogIcon.Information);
                        _fcha.HienThiDuLieu();
                    }
                    else
                    {
                        ht.ThongBao(this, "Lỗi", "Không thể cập nhật tài khoản!", Guna.UI2.WinForms.MessageDialogIcon.Error);
                    }
                }
                else
                {
                    if (bll_dn.ThemTaiKhoan(dn) > 0)
                    {
                        ht.ThongBao(this, "Thông báo", "Thêm tài khoản mới thành công!", Guna.UI2.WinForms.MessageDialogIcon.Information);
                        _fcha.HienThiDuLieu();
                    }
                    else
                    {
                        ht.ThongBao(this, "Lỗi", "Không thể thêm tài khoản!", Guna.UI2.WinForms.MessageDialogIcon.Error);
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