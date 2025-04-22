using BLL;
using Presentation.Add;
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
    public partial class frmTheLoai : Form
    {
        // những thứ cần dùng
        BLL_TheLoai bll_tl = new BLL_TheLoai();
        Hopthoai ht = new Hopthoai();

        public frmTheLoai()
        {
            InitializeComponent();
        }

        private void frmTheLoai_Load(object sender, EventArgs e)
        {
            // ngăn tự tạo động cột
            dgTheLoai.AutoGenerateColumns = false;
            dgTheLoai.DataSource = bll_tl.Hienthidulieu();
            dgTheLoai.Columns["dgcMaTL"].DataPropertyName = "MaTheLoai";
            dgTheLoai.Columns["dgcTenTL"].DataPropertyName = "TenTheLoai";
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmTheLoaiAdd fTLadd = new frmTheLoaiAdd(this);
            ht.BlurBackground(fTLadd);
        }
        public void Hienthidulieu()
        {
            string tukhoa = txtTimKiem.Text.Trim();
            if (!string.IsNullOrEmpty(tukhoa))
            {
                dgTheLoai.DataSource = bll_tl.Timkiemtheloai(tukhoa);
            }
            else
            {
                dgTheLoai.DataSource = bll_tl.Hienthidulieu();
            }
        }

        private void dgTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgTheLoai.Columns[e.ColumnIndex].Name == "dgcCapNhat")
            {
                frmTheLoaiAdd fTLadd = new frmTheLoaiAdd(this);
                fTLadd.txtMaTL.Text = dgTheLoai.CurrentRow.Cells["dgcMaTL"].Value.ToString();
                fTLadd.txtTenTL.Text = dgTheLoai.CurrentRow.Cells["dgcTenTL"].Value.ToString();
                ht.BlurBackground(fTLadd);
            }
            if (dgTheLoai.Columns[e.ColumnIndex].Name == "dgcXoa")
            {
                string ma = dgTheLoai.CurrentRow.Cells["dgcMaTL"].Value.ToString();

                if (ht.XacNhan(this, "Xác nhận xóa", "Bạn có chắc muốn xóa thể loại này không?") == DialogResult.Yes)
                {
                    bll_tl.Xoatheloai(ma);
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
