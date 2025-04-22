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
using Presentation.Add;
namespace Presentation
{
    public partial class frmNhaCungCap : Form
    {
        // các thành phần dùng
        BLL_NhaCungCap bll_ncc = new BLL_NhaCungCap();
        Hopthoai ht = new Hopthoai();
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void dgNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgNhaCungCap.Columns[e.ColumnIndex].Name == "dgcCapNhat")
            {
                frmNhaCungCapAdd fNCCadd = new frmNhaCungCapAdd(this);
                fNCCadd.txtMaNCC.Text = dgNhaCungCap.CurrentRow.Cells["dgcMaNCC"].Value.ToString();
                fNCCadd.txtTenNCC.Text = dgNhaCungCap.CurrentRow.Cells["dgcTenNCC"].Value.ToString();
                fNCCadd.txtSoDT.Text = dgNhaCungCap.CurrentRow.Cells["dgcSoDT"].Value.ToString();
                ht.BlurBackground(fNCCadd);
            }
            if (dgNhaCungCap.Columns[e.ColumnIndex].Name == "dgcXoa")
            {
                string ma = dgNhaCungCap.CurrentRow.Cells["dgcMaKH"].Value.ToString();

                if (ht.XacNhan(this, "Xác nhận xóa", "Bạn có chắc muốn xóa nhà cung cấp này không?") == DialogResult.Yes)
                {
                    bll_ncc.Xoanhacungcap(ma);
                    Hienthidulieu();
                }
            }
        }
        public void Hienthidulieu()
        {
            string tukhoa = txtTimKiem.Text.Trim();
            if (!string.IsNullOrEmpty(tukhoa))
            {
                dgNhaCungCap.DataSource = bll_ncc.Timkiemnhacungcap(tukhoa);
            }
            else
            {

                dgNhaCungCap.DataSource = bll_ncc.Hienthidulieu();
            }
        }
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            // ngăn tự tạo động cột
            dgNhaCungCap.AutoGenerateColumns = false;
            dgNhaCungCap.DataSource = bll_ncc.Hienthidulieu();
            dgNhaCungCap.Columns["dgcMaNCC"].DataPropertyName = "MaNCC";
            dgNhaCungCap.Columns["dgcTenNCC"].DataPropertyName = "TenNCC";
            dgNhaCungCap.Columns["dgcSoDT"].DataPropertyName = "SDT";
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            Hienthidulieu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmNhaCungCapAdd fNCCadd = new frmNhaCungCapAdd(this);
            ht.BlurBackground(fNCCadd);
        }
    }
}
