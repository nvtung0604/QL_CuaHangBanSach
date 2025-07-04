﻿using BLL;
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
using System.Windows.Media;

namespace Presentation
{
    public partial class frmTaiKhoan : Form
    {
        Hopthoai ht = new Hopthoai();
        BLL_DangNhap bll_dn = new BLL_DangNhap();

        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            dgTaiKhoan.AutoGenerateColumns = false;
            HienThiDuLieu(); // Load dữ liệu lên DataGridView

            // Liên kết cột DataGridView với các trường dữ liệu
            dgTaiKhoan.Columns["dgcMaTaiK"].DataPropertyName = "MaTaiKhoan";
            dgTaiKhoan.Columns["dgcTenTK"].DataPropertyName = "TenTaiKhoan";
            dgTaiKhoan.Columns["dgcMatK"].DataPropertyName = "MatKhau";
            dgTaiKhoan.Columns["dgcRole"].DataPropertyName = "Role";
            dgTaiKhoan.Columns["dgcMaNV"].DataPropertyName = "MaNV"; // Cột ẩn mã nhân viên
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
                //// Khi nhấn vào nút cập nhật
                //frmTaiKhoanAdd fTKadd = new frmTaiKhoanAdd(this);

                // Gán dữ liệu từ DataGridView sang form cập nhật
                string matk = dgTaiKhoan.CurrentRow.Cells["dgcMaTaiK"].Value.ToString();
                string tentk = dgTaiKhoan.CurrentRow.Cells["dgcTenTK"].Value.ToString();
                string matkhau = dgTaiKhoan.CurrentRow.Cells["dgcMatK"].Value.ToString();
                string role = dgTaiKhoan.CurrentRow.Cells["dgcRole"].Value.ToString();
                string manv = dgTaiKhoan.CurrentRow.Cells["dgcMaNV"].Value.ToString(); // Gán mã nhân viên
                                                                                       // Gọi form cập nhật và truyền dữ liệu vào
                frmTaiKhoanAdd frmTKAdd = new frmTaiKhoanAdd(this, true, matk, tentk, matkhau, role, manv); // true = isEdit
                ht.BlurBackground(frmTKAdd); // Mở form cập nhật
            }
            if (dgTaiKhoan.Columns[e.ColumnIndex].Name == "dgcXoa")
            {
                string selectedRole = dgTaiKhoan.CurrentRow.Cells["dgcRole"].Value.ToString();
                if (selectedRole == "Admin")
                {
                    MessageBox.Show("Tài khoản admin không thể bị xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Khi nhấn vào nút xóa
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
            ht.BlurBackground(fTKadd); // Mở form thêm mới
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            HienThiDuLieu(); // Tìm kiếm theo từ khóa
        }
    }
}