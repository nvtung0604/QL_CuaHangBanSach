using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    
    public partial class frmGiaoDienChinh : Form
    {
        public string TenNhanVien
        {
            get { return lbUser.Text; }
            set { lbUser.Text = value; }
        }
        string role;
        public string Role
        {
            get { return role; }
            set { role = value; }
        }
        public frmGiaoDienChinh(string tendn, string role)
        {
            InitializeComponent();
            TenNhanVien = tendn;
            Role = role;
            this.IsMdiContainer = true;
        }
        // đưa form lên giao diện chính
        public void ThemFormLenGiaoDienChinh(Form f)
        {
            panelChinh.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            panelChinh.Controls.Add(f);
            f.Show();
        }
        
        private void frmGiaoDienChinh_Load(object sender, EventArgs e)
        {
            // Hiển thị Home mặc định
            ThemFormLenGiaoDienChinh(new frmHome());
            btnHome.Checked = true;

            // Kiểm tra role và thiết lập các nút
            if (Role == "Admin")
            {
                // Hiển thị toàn bộ nút bấm cho Admin
                btnHome.Visible = true;
                btnAccount.Visible = true;
                btnBook.Visible = true;
                btnStaff.Visible = true;
                btnCustomer.Visible = true;
                btnCategory.Visible = true;
                btnPOS.Visible = true;
                btnReport.Visible = true;
                btnNhaCC.Visible = true;
            }
            else if (Role == "Nhân Viên")
            {
                // Hiển thị POS và Khách hàng cho Nhân Viên, các nút khác ẩn đi
                btnHome.Visible = false;
                btnAccount.Visible = false;
                btnBook.Visible = false;
                btnStaff.Visible = false;
                btnCategory.Visible = false;
                btnPOS.Visible = true;
                btnCustomer.Visible = true;
                btnReport.Visible = false;
                btnNhaCC.Visible = false;
            }
        }

        // thoát app
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // chuyển đồi cho tôi mang hết dưới dòng đã comment
        private void btnHome_Click_1(object sender, EventArgs e)
        {
            ThemFormLenGiaoDienChinh(new frmHome());
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            ThemFormLenGiaoDienChinh(new frmTaiKhoan());
        }

        private void btnBook_Click_1(object sender, EventArgs e)
        {
            ThemFormLenGiaoDienChinh(new frmSach());
        }

        private void btnStaff_Click_1(object sender, EventArgs e)
        {
            ThemFormLenGiaoDienChinh(new frmNhanVien());
        }

        private void btnCustomer_Click_1(object sender, EventArgs e)
        {
            ThemFormLenGiaoDienChinh(new frmKhachHang());
        }

        private void btnCategory_Click_1(object sender, EventArgs e)
        {
            ThemFormLenGiaoDienChinh(new frmTheLoai());
        }

        private void btnPOS_Click_1(object sender, EventArgs e)
        {
            ThemFormLenGiaoDienChinh(new frmPOSs());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ThemFormLenGiaoDienChinh(new frmBaoCao());
        }

        private void btnNhaCC_Click(object sender, EventArgs e)
        {
            ThemFormLenGiaoDienChinh(new frmNhaCungCap());
        }
    }
}
