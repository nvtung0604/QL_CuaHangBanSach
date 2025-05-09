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
using Presentation.HopThoai;
namespace Presentation
{
    public partial class frmDangNhap : Form
    {
        
        
        public frmDangNhap()
        {
            InitializeComponent();
        }
        BLL_DangNhap bll_dn = new BLL_DangNhap();
        Hopthoai ht = new Hopthoai();
        public DTO_DangNhap LayThongTinTuForm()
        {
            DTO_DangNhap dto_dn = new DTO_DangNhap
            {
                TenTaiKhoan = txtUsername.Text,
                MatKhau = txtPassword.Text,
            };
            return dto_dn;
        }
        public string LayTenDangNhap()
        {
            return txtUsername.Text;
        }
        
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btbDangNhap_Click(object sender, EventArgs e)
        {
            DTO_DangNhap dto_dn = LayThongTinTuForm();
            DataTable dt = bll_dn.KiemTraDangNhap(dto_dn);

            if (dt.Rows.Count > 0)
            {
                string tenTaiKhoan = dto_dn.TenTaiKhoan;
                string tenNhanVien = bll_dn.LayTenNhanVien(tenTaiKhoan);
                string maNhanVien = bll_dn.LayMaNhanVien(tenTaiKhoan);
                string role = bll_dn.LayQuyenTuTen(tenTaiKhoan);

                MessageBox.Show("Đăng nhập thành công");
                //MessageBox.Show($"Chào mừng {role} - {tenNhanVien}");
                ht.ThongBao(this, "Thông báo", $"Chào mừng {role} - {tenNhanVien}", Guna.UI2.WinForms.MessageDialogIcon.Information);
                frmGiaoDienChinh fGDC = new frmGiaoDienChinh(tenNhanVien, role, maNhanVien); // truyền tên nhân viên
                fGDC.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
