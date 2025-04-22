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
    public partial class frmChonNhanVien : Form
    {
        public frmChonNhanVien()
        {
            InitializeComponent();
        }
        BLL_NhanVien bll_nv = new BLL_NhanVien();
       
        private void frmChonNhanVien_Load(object sender, EventArgs e)
        {
            DataTable dt = bll_nv.Hienthidulieu();
            foreach(DataRow row in dt.Rows)
            {
                Guna.UI2.WinForms.Guna2Button button = new Guna.UI2.WinForms.Guna2Button();
                button.Text = row["TenNV"].ToString();
                button.Tag = row["MaNV"].ToString();
                button.Width = 100;
                button.Height = 50;
                button.FillColor = Color.FromArgb(241, 85, 126);
                button.HoverState.FillColor = Color.FromArgb(50, 55, 89);
                button.Click += new EventHandler(button_Click);
                flpChonNhanVien.Controls.Add(button);
            }
            
        }
        public string MaNV;

        private void button_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button btn = sender as Guna.UI2.WinForms.Guna2Button;
            MaNV = btn.Tag.ToString(); // lấy mã khách hàng đã lưu trong Tag
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
