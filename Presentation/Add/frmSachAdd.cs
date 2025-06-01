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
using DTO;
using System.IO;
namespace Presentation
{
    public partial class frmSachAdd : Form
    {
        BLL_Sach bll_s = new BLL_Sach();
        Hopthoai ht = new Hopthoai();
        private frmSach _fcha;
        private byte[] imageData = null;
        private bool isEdit = false;
        private string masach = "";
        public frmSachAdd(frmSach fcha)
        {
            InitializeComponent();
            _fcha = fcha;
        }
        public frmSachAdd(frmSach fcha, bool isEdit, string ma, string ten, string tacgia, string tl, string giaban, string sl, string nxb, string ncc, string namxb) : this(fcha)
        {
            this.isEdit = isEdit;
            this.masach = ma;

            Laydanhsachtheloai();     
            Laydanhsachmancc();      

            txtTenS.Text = ten;
            txtTacG.Text = tacgia;
            cboTheL.SelectedValue = tl;
            txtGiaB.Text = giaban;
            txtSoLT.Text = sl;
            txtNhaXB.Text = nxb;
            cboMaNCC.SelectedValue = ncc;
            txtNamXB.Text = namxb;
        }


        private DTO_Sach Laythongtintuform()
        {
            return new DTO_Sach
            {
                MaSach = masach,
                TenSach = txtTenS.Text,
                TacGia = txtTacG.Text,
                MaTheLoai = cboTheL.SelectedValue.ToString(),
                GiaBan = Convert.ToDecimal(txtGiaB.Text),
                SoLuongTon = Convert.ToInt32(txtSoLT.Text),
                NhaXuatBan = txtNhaXB.Text,
                NamXuatBan = Convert.ToInt32(txtNamXB.Text),
                MaNCC = cboMaNCC.SelectedValue.ToString(),
                HinhAnh = imageData
            };
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // lấy danh sách thể loại
        public void Laydanhsachtheloai()
        {
            DataTable dtTheL = bll_s.LayDanhSachTheLoai();
            cboTheL.DataSource = dtTheL;
            cboTheL.DisplayMember = "TenTheLoai";
            cboTheL.ValueMember = "MaTheLoai";
            //cboTheL.SelectedIndex = -1;
            
        }
        public void Laydanhsachmancc()
        {
            DataTable dtMaNCC = bll_s.Laydanhsachmancc();
            cboMaNCC.DataSource = dtMaNCC;
            cboMaNCC.DisplayMember = "TenNCC";
            cboMaNCC.ValueMember = "MaNCC";
            //cboMaNCC.SelectedIndex = -1;
        }
        private void frmSachAdd_Load(object sender, EventArgs e)
        {
            Laydanhsachtheloai();
            Laydanhsachmancc();
            if (string.IsNullOrEmpty(masach))
            {
                cboTheL.SelectedIndex = -1;  // Đặt ô về trạng thái trống
                cboMaNCC.SelectedIndex = -1;  // Đặt ô về trạng thái trống
            }
        }

        private void pcHinhA_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pcHinhA.Image = Image.FromFile(ofd.FileName);
                imageData = File.ReadAllBytes(ofd.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Check for missing data
                if (
                    string.IsNullOrWhiteSpace(txtTenS.Text) ||
                    string.IsNullOrWhiteSpace(txtTacG.Text) ||
                    string.IsNullOrWhiteSpace(cboTheL.Text) ||
                    string.IsNullOrWhiteSpace(txtGiaB.Text) ||
                    string.IsNullOrWhiteSpace(txtSoLT.Text) ||
                    string.IsNullOrWhiteSpace(txtNhaXB.Text) ||
                    string.IsNullOrWhiteSpace(txtNamXB.Text) ||
                    string.IsNullOrWhiteSpace(cboMaNCC.Text) || imageData == null)
                    
                {
                    ht.ThongBao(this, "Thông báo", "Vui lòng kiểm tra lại, có trường dữ liệu bị thiếu!", Guna.UI2.WinForms.MessageDialogIcon.Warning);
                    return;
                }
                MessageBox.Show(cboTheL.Text);

                // Get book information
                DTO_Sach sach = Laythongtintuform();

                // Validate specific fields
                if (sach.GiaBan <= 0)
                {
                    MessageBox.Show("Giá bán phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (isEdit)
                {
                    // Update existing book
                    if (bll_s.CapNhatSach(sach) > 0)
                    {
                        ht.ThongBao(this, "Thông báo", "Cập nhật sách thành công!", Guna.UI2.WinForms.MessageDialogIcon.Information);
                        _fcha.Hienthidulieu();
                    }
                    else
                    {
                        ht.ThongBao(this, "Lỗi", "Không thể cập nhật sách!", Guna.UI2.WinForms.MessageDialogIcon.Error);
                    }
                }
                else
                {
                    string masach = bll_s.ThemSachVaLayMa(sach);
                    // Add new book
                    if (!string.IsNullOrEmpty(masach))
                    {
                        ht.ThongBao(this, "Thông báo", "Thêm sách thành công!", Guna.UI2.WinForms.MessageDialogIcon.Information);
                        _fcha.Hienthidulieu();
                    }
                    else
                    {
                        ht.ThongBao(this, "Lỗi", "Không thể thêm sách!", Guna.UI2.WinForms.MessageDialogIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                ht.ThongBao(this, "Lỗi", $"Đã xảy ra lỗi: {ex.Message}", Guna.UI2.WinForms.MessageDialogIcon.Error);
            }
        }
        public void SetImageData(byte[] data)
        {
            imageData = data;
        }
    }
}
