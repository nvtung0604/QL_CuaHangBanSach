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
            dgTheLoai.Columns["dgcSoLS"].DataPropertyName = "SoLuongSach";

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
            // Kiểm tra nếu tên cột là "dgcCapNhat" (Cập nhật thể loại)
            if (dgTheLoai.Columns[e.ColumnIndex].Name == "dgcCapNhat")
            {
                // Kiểm tra nếu thể loại được chọn là "ChuaCo"
                string selectedMaTheLoai = dgTheLoai.CurrentRow.Cells["dgcMaTL"].Value.ToString();
                if (selectedMaTheLoai == "ChuaCo")
                {
                    MessageBox.Show("Thể loại 'Chưa có' không thể được cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Mở form cập nhật thể loại
                frmTheLoaiAdd fTLadd = new frmTheLoaiAdd(this);

                // Truyền dữ liệu từ DataGridView sang các TextBox của form cập nhật
                fTLadd.txtMaTL.Text = dgTheLoai.CurrentRow.Cells["dgcMaTL"].Value.ToString();
                fTLadd.txtTenTL.Text = dgTheLoai.CurrentRow.Cells["dgcTenTL"].Value.ToString();

                // Làm mờ background và hiển thị form
                ht.BlurBackground(fTLadd);
            }
            // Kiểm tra nếu tên cột là "dgcXoa" (Xóa thể loại)
            if (dgTheLoai.Columns[e.ColumnIndex].Name == "dgcXoa")
            {
                // Lấy mã thể loại từ dòng hiện tại trong DataGridView
                string maTheLoai = dgTheLoai.CurrentRow.Cells["dgcMaTL"].Value.ToString();
                
                if (maTheLoai == "ChuaCo")
                {
                    MessageBox.Show("Thể loại 'Chưa có' không xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Hiển thị hộp thoại xác nhận xóa
                if (ht.XacNhan(this, "Xác nhận xóa", "Bạn có chắc muốn xóa thể loại này không?") == DialogResult.Yes)
                {
                    try
                    {
                        
                        bll_tl.XoaTheLoai(maTheLoai); // Gọi lớp BLL để xóa thể loại

                        Hienthidulieu(); // Cập nhật lại dữ liệu trên giao diện
                        MessageBox.Show("Xóa thể loại thành công!");
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            Hienthidulieu();
        }
    }
}
