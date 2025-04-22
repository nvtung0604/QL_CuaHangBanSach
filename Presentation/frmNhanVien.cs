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
namespace Presentation
{
    public partial class frmNhanVien : Form
    {
        BLL_NhanVien bll_nv = new BLL_NhanVien();
        Hopthoai ht = new Hopthoai();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dgNhanVien.AutoGenerateColumns = false;
            dgNhanVien.DataSource = bll_nv.Hienthidulieu();
            dgNhanVien.Columns["dgcMaNV"].DataPropertyName = "MaNV";
            dgNhanVien.Columns["dgcTenNV"].DataPropertyName = "TenNV";
            dgNhanVien.Columns["dgcSoDT"].DataPropertyName = "SDT";

        }
        public void Hienthidulieu()
        {
            string tukhoa = txtTimKiem.Text.Trim();
            if (!string.IsNullOrEmpty(tukhoa))
            {
                dgNhanVien.DataSource = bll_nv.Timkiemnhanvien(tukhoa);
                
            }
            else
            {
                dgNhanVien.DataSource = bll_nv.Hienthidulieu();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            Hienthidulieu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmNhanVienAdd fNVadd = new frmNhanVienAdd(this);
            ht.BlurBackground(fNVadd);
        }

        private void dgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgNhanVien.Columns[e.ColumnIndex].Name == "dgcCapNhat")
            {
                frmNhanVienAdd fNVadd = new frmNhanVienAdd(this);
                fNVadd.txtMaNV.Text = dgNhanVien.CurrentRow.Cells["dgcMaNV"].Value.ToString();
                fNVadd.txtTenNV.Text = dgNhanVien.CurrentRow.Cells["dgcTenNV"].Value.ToString();
                fNVadd.txtSoDT.Text = dgNhanVien.CurrentRow.Cells["dgcSoDT"].Value.ToString();
                ht.BlurBackground(fNVadd);
            }
            if (dgNhanVien.Columns[e.ColumnIndex].Name == "dgcXoa")
            {
                string ma = dgNhanVien.CurrentRow.Cells["dgcMaNV"].Value.ToString();

                if (ht.XacNhan(this, "Xác nhận xóa", "Bạn có chắc muốn xóa khách hàng này không?") == DialogResult.Yes)
                {
                    bll_nv.Xoanhanvien(ma);
                    Hienthidulieu();
                }
            }
        }
    }
}
