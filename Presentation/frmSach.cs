using BLL;
using DTO;
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
    public partial class frmSach : Form
    {
        // Những thứ cần dùng
        BLL_Sach bll_s = new BLL_Sach();
        Hopthoai ht = new Hopthoai();

        public frmSach()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Mở form thêm sách
            frmSachAdd fSachAdd = new frmSachAdd(this);
            ht.BlurBackground(fSachAdd);
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            // Ngăn tự tạo động cột
            dgSach.AutoGenerateColumns = false;
            dgSach.DataSource = bll_s.HienThiDuLieu(); // Hiển thị danh sách sách
            dgSach.Columns["dgcMaS"].DataPropertyName = "MaSach";
            dgSach.Columns["dgcTenS"].DataPropertyName = "TenSach";
            dgSach.Columns["dgcTacG"].DataPropertyName = "TacGia";
            dgSach.Columns["dgcTheL"].DataPropertyName = "TenTheLoai";
            dgSach.Columns["dgcGiaB"].DataPropertyName = "GiaBan";
            dgSach.Columns["dgcSoLT"].DataPropertyName = "SoLuongTon";
            dgSach.Columns["dgcNhaXB"].DataPropertyName = "NhaXuatBan";
            dgSach.Columns["dgcNamXB"].DataPropertyName = "NamXuatBan";
            dgSach.Columns["dgcTenNCC"].DataPropertyName = "TenNCC";
            dgSach.Columns["dgcHinhA"].DataPropertyName = "HinhAnh"; 
        }

        public void Hienthidulieu()
        {
            string tukhoa = txtTimKiem.Text.Trim();
            if (!string.IsNullOrEmpty(tukhoa))
            {
                // Tìm kiếm sách theo từ khóa
                dgSach.DataSource = bll_s.TimKiemSach(tukhoa);
            }
            else
            {
                // Hiển thị toàn bộ danh sách sách
                dgSach.DataSource = bll_s.HienThiDuLieu();
            }
        }

        private void dgSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgSach.Columns[e.ColumnIndex].Name == "dgcCapNhat")
            {
                // Cập nhật thông tin sách khi nhấn nút Cập nhật
                frmSachAdd fSachAdd = new frmSachAdd(this);
                fSachAdd.Laydanhsachtheloai();
                fSachAdd.Laydanhsachmancc();
                fSachAdd.txtMaS.Text = dgSach.CurrentRow.Cells["dgcMaS"].Value.ToString();
                fSachAdd.txtTenS.Text = dgSach.CurrentRow.Cells["dgcTenS"].Value.ToString();
                fSachAdd.txtTacG.Text = dgSach.CurrentRow.Cells["dgcTacG"].Value.ToString();
                fSachAdd.cboTheL.Text = dgSach.CurrentRow.Cells["dgcTheL"].Value.ToString();
                fSachAdd.txtGiaB.Text = dgSach.CurrentRow.Cells["dgcGiaB"].Value.ToString();
                fSachAdd.txtSoLT.Text = dgSach.CurrentRow.Cells["dgcSoLT"].Value.ToString();
                fSachAdd.txtNhaXB.Text = dgSach.CurrentRow.Cells["dgcNhaXB"].Value.ToString();
                fSachAdd.cboMaNCC.Text = dgSach.CurrentRow.Cells["dgcTenNCC"].Value.ToString();
                fSachAdd.txtNamXB.Text = dgSach.CurrentRow.Cells["dgcNamXB"].Value.ToString();


                // Hiển thị hình ảnh nếu có
                byte[] imageData = dgSach.CurrentRow.Cells["dgcHinhA"].Value as byte[];
                if (imageData != null)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        fSachAdd.pcHinhA.Image = Image.FromStream(ms);
                        fSachAdd.SetImageData(imageData);
                    }
                }

                ht.BlurBackground(fSachAdd);
            }
            if (dgSach.Columns[e.ColumnIndex].Name == "dgcXoa")
            {
                // Xóa sách khi nhấn nút Xóa
                string ma = dgSach.CurrentRow.Cells["dgcMaS"].Value.ToString();
                if (ht.XacNhan(this, "Xác nhận xóa", "Bạn có chắc muốn xóa sách này không?") == DialogResult.Yes)
                {
                    bll_s.XoaSach(ma);
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
