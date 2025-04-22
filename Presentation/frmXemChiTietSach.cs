using BLL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Presentation
{
    public partial class frmXemChiTietSach : Form
    {
        private string ms;
        private BLL_POS bll_POS = new BLL_POS();

        public frmXemChiTietSach(string maSach)
        {
            InitializeComponent();
            this.ms = maSach;
        }

        private void frmXemChiTietSach_Load(object sender, EventArgs e)
        {
            DataTable dt = bll_POS.LayDanhSachTheoMa(ms);
            if (dt.Rows.Count > 0)
            {
                lbMaS.Text = dt.Rows[0]["MaSach"].ToString();
                lbTenS.Text = dt.Rows[0]["TenSach"].ToString();
                lbTacG.Text = dt.Rows[0]["TacGia"].ToString();
                lbTheL.Text = dt.Rows[0]["TenTheLoai"].ToString();
                lbGiaB.Text = dt.Rows[0]["GiaBan"].ToString();
                lblSoLT.Text = dt.Rows[0]["SoLuongTon"].ToString();
                lbNhaXB.Text = dt.Rows[0]["NhaXuatBan"].ToString();
                lbNamXB.Text = dt.Rows[0]["NamXuatBan"].ToString();
                lblNhaCC.Text = dt.Rows[0]["TenNCC"].ToString();
                lbNhaXB2.Text = dt.Rows[0]["NhaXuatBan"].ToString();
                lbNhaCC2.Text = dt.Rows[0]["TenNCC"].ToString();
                lbTenS2.Text = dt.Rows[0]["TenSach"].ToString();
                lbTheL2.Text = dt.Rows[0]["TenTheLoai"].ToString();
                lbGiaB2.Text = dt.Rows[0]["GiaBan"].ToString();
                if (dt.Rows[0]["HinhAnh"] != DBNull.Value)
                {
                    guna2PictureBox1.Image = Image.FromStream(new MemoryStream((byte[])dt.Rows[0]["HinhAnh"]));
                }
                else
                {
                    guna2PictureBox1.Image = null;
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu để hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        public void LoadDuLieu()
        {
            
        }
       
    }
}
