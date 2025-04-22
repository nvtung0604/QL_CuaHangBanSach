using BLL;
using Presentation.Add;
using Presentation.HopThoai;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{

    public partial class frmTaiKhoan : Form
    {
        Hopthoai ht = new Hopthoai();
        public frmTaiKhoan()
        {
            InitializeComponent();
        }
        BLL_DangNhap bll_dn = new BLL_DangNhap();
        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            dgTaiKhoan.AutoGenerateColumns = false;
            dgTaiKhoan.DataSource = bll_dn.HienThiDuLieu();
            dgTaiKhoan.Columns["dgcMaTaiK"].DataPropertyName = "MaTaiKhoan";
            dgTaiKhoan.Columns["dgcTenTK"].DataPropertyName = "TenTaiKhoan";
            dgTaiKhoan.Columns["dgcMatK"].DataPropertyName = "MatKhau";
            dgTaiKhoan.Columns["dgcRole"].DataPropertyName = "Role";
            dgTaiKhoan.Columns["dgcTenNV"].DataPropertyName = "TenNV";
        }
        public void HienThiDuLieu()
        {
            string tukhoa = txtTimKiem.Text.Trim();
            if (!string.IsNullOrEmpty(tukhoa))
            {
                dgTaiKhoan.DataSource = bll_dn.TimKiemTaiKhoan(tukhoa);
            }
            else
            {

                dgTaiKhoan.DataSource = bll_dn.HienThiDuLieu();
            }
        }
        private void dgTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgTaiKhoan.Columns[e.ColumnIndex].Name == "dgcCapNhat")
            {
                // Cập nhật thông tin sách khi nhấn nút Cập nhật
                frmTaiKhoanAdd fTKadd = new frmTaiKhoanAdd(this);
                fTKadd.txtMaTaiK.Text = dgTaiKhoan.CurrentRow.Cells["dgcMaTaiK"].Value.ToString();
                fTKadd.txtTenTK.Text = dgTaiKhoan.CurrentRow.Cells["dgcTenTK"].Value.ToString();
                fTKadd.txtMatK.Text = dgTaiKhoan.CurrentRow.Cells["dgcMatK"].Value.ToString();
                fTKadd.cboRole.Text = dgTaiKhoan.CurrentRow.Cells["dgcRole"].Value.ToString();
                fTKadd.cboTenNV.Text = dgTaiKhoan.CurrentRow.Cells["dgcTenNV"].Value.ToString();
                
                ht.BlurBackground(fTKadd);
            }
            if (dgTaiKhoan.Columns[e.ColumnIndex].Name == "dgcXoa")
            {
                // Xóa sách khi nhấn nút Xóa
                string ma = dgTaiKhoan.CurrentRow.Cells["dgcMaTaiK"].Value.ToString();
                if (ht.XacNhan(this, "Xác nhận xóa", "Bạn có chắc muốn xóa tài khoản này không?") == DialogResult.Yes)
                {
                    bll_dn.XoaTaiKhoan(ma);
                    HienThiDuLieu();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmTaiKhoanAdd fTKadd = new frmTaiKhoanAdd(this);
            ht.BlurBackground(fTKadd);
        }
        
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }
    }
}
