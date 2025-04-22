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

namespace Presentation
{
    public partial class frmGioHangChiTiet : Form
    {
        public frmGioHangChiTiet()
        {
            InitializeComponent();
        }
        public string MaGioHang;
        BLL_ChiTietGioHang bll_ctgh = new BLL_ChiTietGioHang();
        private void frmGioHangChiTiet_Load(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(MaGioHang))
                {
                    MessageBox.Show("Mã giỏ hàng không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dgcChiTietGioHang.AutoGenerateColumns = false;
                dgcChiTietGioHang.DataSource = bll_ctgh.HienThiDuLieu(MaGioHang);
                dgcChiTietGioHang.Columns["dgcTenS"].DataPropertyName = "TenSach";
                dgcChiTietGioHang.Columns["dgcSoL"].DataPropertyName = "SoLuong";
                dgcChiTietGioHang.Columns["dgcGiaB"].DataPropertyName = "GiaBan";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu giỏ hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
