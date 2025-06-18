using System;
using System.Drawing;
using System.Windows.Forms;
using Presentation.HopThoai;
namespace Presentation
{
    public partial class ucSanPhamSach : UserControl
    {
        private Label lblHetHang;
        public ucSanPhamSach()
        {
            InitializeComponent();
            lblHetHang = new Label();

            lblTenS.ForeColor = Color.Black;
            lblHetHang.BackColor = Color.Yellow;
            lblHetHang.ForeColor = Color.Black;
            lblHetHang.Font = new Font("Segoe UI", 20, FontStyle.Bold | FontStyle.Italic);
            lblHetHang.Text = "Hết";
            lblHetHang.TextAlign = ContentAlignment.MiddleCenter;
            
            lblHetHang.AutoSize = false;
            lblHetHang.Size = new Size(130, 40);  

            // Đặt vị trí ở góc trên bên trái
            lblHetHang.Location = new Point(0, 0);

            // Đặt nằm trên cùng
            lblHetHang.Visible = false;
            // Thêm vào control
            this.Controls.Add(lblHetHang);
            lblHetHang.BringToFront();
        }
        public void SetHetHang()
        {
            lblHetHang.Visible = true;
            //this.BorderStyle = BorderStyle.FixedSingle;
            
            btnXemThemTT.Cursor = Cursors.Hand;
            btnXemThemTT.Enabled = true; 


        }
        // mới thêm
        public int SoLuongTon { get; set; }
        public int SoLuongTonGoc { get; set; }
        public string MaSach { get; set; }
        public decimal GiaBan { get; set; }
        public string TenSach
        {
            get { return lblTenS.Text; }
            set { lblTenS.Text = value; }
        }

        public Image HinHAnh
        {
            get { return pbHinhAnh.Image; }
            set { pbHinhAnh.Image = value; }
        }
         


        public event EventHandler onSelect = null;

        private void pbHinhAnh_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
        Hopthoai ht = new Hopthoai();
        private void btnXemThemTT_Click(object sender, EventArgs e)
        {
            frmXemChiTietSach fXCTS = new frmXemChiTietSach(MaSach);
            ht.BlurBackground(fXCTS);
        }
        
        private void ucSanPhamSach_Load(object sender, EventArgs e)
        {
        }

        private void lblTenS_Click(object sender, EventArgs e)
        {
            

        }
    }
}
