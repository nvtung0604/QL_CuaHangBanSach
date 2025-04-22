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
    public partial class frmChonKhachHang : Form
    {
        public frmChonKhachHang()
        {
            InitializeComponent();
        }
        BLL_KhachHang bll_kh = new BLL_KhachHang();
        private void frmChonKhachHang_Load(object sender, EventArgs e)
        {
            DataTable dt = bll_kh.Hienthidulieu();
            foreach (DataRow row in dt.Rows)
            {
                Guna.UI2.WinForms.Guna2Button button = new Guna.UI2.WinForms.Guna2Button();
                button.Text = row["TenKH"].ToString(); // hiển thị tên
                button.Tag = row["MaKH"].ToString();   // lưu mã khách hàng
                button.Width = 100;
                button.Height = 50;
                button.FillColor = Color.FromArgb(241, 85, 126);
                button.HoverState.FillColor = Color.FromArgb(50, 55, 89);
                button.Click += new EventHandler(button_Click);
                flpChonKhachHang.Controls.Add(button);
            }
        }

        // Thay vì lưu TenKH, ta lưu MaKH
        public string MaKH;

        private void button_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button btn = sender as Guna.UI2.WinForms.Guna2Button;
            MaKH = btn.Tag.ToString(); // lấy mã khách hàng đã lưu trong Tag
            this.Close();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
