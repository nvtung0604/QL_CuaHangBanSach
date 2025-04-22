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
namespace Presentation
{
    public partial class frmKhachHang : Form
    {
        // những thứ cần dùng
        BLL_KhachHang bll_kh = new BLL_KhachHang();
        Hopthoai ht = new Hopthoai();


        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmKhachHangAdd fKHadd = new frmKhachHangAdd(this);
            ht.BlurBackground(fKHadd);
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            // ngăn tự tạo động cột
            dgKhachHang.AutoGenerateColumns = false;
            dgKhachHang.DataSource = bll_kh.Hienthidulieu();
            dgKhachHang.Columns["dgcMaKH"].DataPropertyName = "MaKH";
            dgKhachHang.Columns["dgcTenKH"].DataPropertyName = "TenKH";
            dgKhachHang.Columns["dgcSoDT"].DataPropertyName = "SDT";
        }
        public void Hienthidulieu()
        {
            string tukhoa = txtTimKiem.Text.Trim();
            if (!string.IsNullOrEmpty(tukhoa))
            {
                dgKhachHang.DataSource = bll_kh.Timkiemkhachhang(tukhoa);
            }
            else
            {
               
                dgKhachHang.DataSource = bll_kh.Hienthidulieu();
            }
        }
        
        private void dgKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgKhachHang.Columns[e.ColumnIndex].Name == "dgcCapNhat")
            {
                frmKhachHangAdd fKHadd = new frmKhachHangAdd(this);
                fKHadd.txtMaKH.Text = dgKhachHang.CurrentRow.Cells["dgcMaKH"].Value.ToString();
                fKHadd.txtTenKH.Text = dgKhachHang.CurrentRow.Cells["dgcTenKH"].Value.ToString();
                fKHadd.txtSoDT.Text = dgKhachHang.CurrentRow.Cells["dgcSoDT"].Value.ToString();
                ht.BlurBackground(fKHadd);
            }
            if (dgKhachHang.Columns[e.ColumnIndex].Name == "dgcXoa")
            {
                string ma = dgKhachHang.CurrentRow.Cells["dgcMaKH"].Value.ToString();
                
                if (ht.XacNhan(this, "Xác nhận xóa", "Bạn có chắc muốn xóa khách hàng này không?") == DialogResult.Yes)
                {
                    bll_kh.Xoakhachhang(ma);
                    Hienthidulieu();
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            Hienthidulieu();
        }
    }
}
