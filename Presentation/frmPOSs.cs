﻿using BLL;
using DTO;
using Guna.UI2.WinForms;
using Presentation.HopThoai;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Drawing.Printing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using System.Web.UI;
using DocumentFormat.OpenXml.Bibliography;
using System.Text.RegularExpressions;

namespace Presentation
{
    public partial class frmPOSs : Form
    {
        Hopthoai ht = new Hopthoai();
        PrintDocument printDocument = new PrintDocument();
        PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
        BLL_POS bus = new BLL_POS();
        //public static bool hienthicapnhat = false;
        public string MaGioHang { get; set; }
        private string _manv;
        public frmPOSs(string MaGH = null, string manv = null)
        {
            InitializeComponent();

            MaGioHang = MaGH;
            _manv = manv;
            
        }
        public string SetSoDT(string soDT = null)
        {
            return soDT;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // mã giỏ hàng
        
        
        private void frmPOS_Load(object sender, EventArgs e)
        {
            btnCapNhatt.Enabled = false;
            // tạo viền
            dgPOS.BorderStyle = BorderStyle.FixedSingle;

            LoadTheLoai();
            flpSach.Controls.Clear();
            LoadSach();
           
            // Xóa hết định dạng cũ
            dgPOS.DefaultCellStyle = new DataGridViewCellStyle();
            dgPOS.RowsDefaultCellStyle = new DataGridViewCellStyle();
            dgPOS.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle();
            // Tắt dùng giao diện mặc định
            dgPOS.EnableHeadersVisualStyles = false;

            // Font chữ đen đậm
            Font boldFont = new Font("Arial", 10, FontStyle.Bold);

            // Áp dụng style mặc định
            dgPOS.DefaultCellStyle.Font = boldFont;
            dgPOS.DefaultCellStyle.ForeColor = Color.Black;
            dgPOS.DefaultCellStyle.BackColor = Color.White;
            dgPOS.DefaultCellStyle.SelectionBackColor = Color.Orange;
            dgPOS.DefaultCellStyle.SelectionForeColor = Color.White;

            // Dòng chẵn (mặc định)
            dgPOS.RowsDefaultCellStyle.Font = boldFont;
            dgPOS.RowsDefaultCellStyle.BackColor = Color.White;
            dgPOS.RowsDefaultCellStyle.ForeColor = Color.Black;

            // Dòng lẻ
            dgPOS.AlternatingRowsDefaultCellStyle.Font = boldFont;
            dgPOS.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#f5f5f5");
            dgPOS.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

            // gợi ý số điện thoại
            SetUpAutoComplete();


            if (!string.IsNullOrEmpty(MaGioHang))
            {
                LoadChiTietGioHang(MaGioHang);
                
            }
        }
        // Tạo danh sách tất cả số điện thoại sẵn
        private AutoCompleteStringCollection soDienThoaiCollection = new AutoCompleteStringCollection();

        // Gọi khi load form
        private void SetUpAutoComplete()
        {
            txtSoDT.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSoDT.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Lấy tất cả số điện thoại từ database 1 lần thôi
            DataTable dt = bll_gh.LaySDTKhachHang(null); // truyền null hoặc bỏ tham số luôn
            foreach (DataRow row in dt.Rows)
            {
                soDienThoaiCollection.Add(row["SDT"].ToString());
            }

            txtSoDT.AutoCompleteCustomSource = soDienThoaiCollection;
        }

        private void txtSoDT_TextChanged(object sender, EventArgs e)
        {
            string sdt = txtSoDT.Text.Trim(); // lấy giá trị từ textbox
            if (sdt.Length > 0)
            {
                string tenkh = bll_gh.LayTenKhachHangTuSDT(sdt);
                if (!string.IsNullOrEmpty(tenkh))
                {
                    lblTenKH.Text = tenkh;
                }
                else
                {
                    lblTenKH.Text = "Không tìm thấy khách hàng!";
                }
            }
            else
            {
                lblTenKH.Text = ""; // Nếu trống thì xóa luôn label
            }
        }


        private void txtSoDT_Leave(object sender, EventArgs e)
        {
            
        }


        // Phương thức Load thể loại
        private Guna2Button selectedButton = null;  // Biến để lưu nút được chọn

        public void LoadTheLoai()
        {
            DataTable dt = bus.LayDanhSachTheLoai();
            flpTheLoai.Controls.Clear(); // Xóa các control hiện tại

            // Tạo nút "Tất cả" để hiển thị toàn bộ sách
            Guna2Button btnTatCa = new Guna2Button
            {
                FillColor = Color.Transparent,
                Size = new Size(100, 50),
                ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton,
                Text = "Tất cả",
                Margin = new Padding(10),
                ForeColor = Color.Black,
                BorderRadius = 10,
                BorderColor = Color.Transparent
            };

            btnTatCa.Click += (s, e) =>
            {
                // Thay đổi trạng thái của nút "Tất cả"
                if (selectedButton != null)
                {
                    // Đưa nút trước về trạng thái ban đầu
                    selectedButton.FillColor = Color.Transparent;
                    selectedButton.ForeColor = Color.Black;
                    selectedButton.BorderColor = Color.Transparent;
                    selectedButton.BorderThickness = 1;
                }

                // Cập nhật nút "Tất cả" làm nút được chọn
                btnTatCa.FillColor = Color.FromArgb(0xf5, 0xf5, 0xf5);
                btnTatCa.ForeColor = Color.FromArgb(0xff, 0xa5, 0x00);
                btnTatCa.BorderColor = Color.FromArgb(0xff, 0xa5, 0x00);
                btnTatCa.BorderThickness = 2;

                selectedButton = btnTatCa;  // Lưu nút "Tất cả" là nút được chọn

                // Gọi hàm hiển thị toàn bộ sách
                LoadSach();
            };

            flpTheLoai.Controls.Add(btnTatCa);

            // Tạo các button thể loại còn lại
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Guna2Button b = new Guna2Button
                    {
                        FillColor = Color.Transparent,
                        Size = new Size(100, 50),
                        ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton,
                        Text = row["TenTheLoai"].ToString(),
                        Margin = new Padding(10),
                        ForeColor = Color.Black,
                        BorderRadius = 10,
                        BorderColor = Color.Transparent
                    };

                    b.Click += (s, e) =>
                    {
                        // Nếu đã có nút được chọn, cập nhật lại trạng thái của nó
                        if (selectedButton != null)
                        {
                            selectedButton.FillColor = Color.Transparent;
                            selectedButton.ForeColor = Color.Black;
                            selectedButton.BorderColor = Color.Transparent;
                            selectedButton.BorderThickness = 1;
                        }

                        // Cập nhật nút hiện tại làm nút được chọn
                        b.FillColor = Color.FromArgb(0xf5, 0xf5, 0xf5);
                        b.ForeColor = Color.FromArgb(0xff, 0xa5, 0x00);
                        b.BorderColor = Color.FromArgb(0xff, 0xa5, 0x00);
                        b.BorderThickness = 2;

                        selectedButton = b;  // Lưu nút hiện tại là nút được chọn

                        // Lọc sách theo thể loại
                        Locsachtheotheloai(b.Text);
                    };

                    flpTheLoai.Controls.Add(b);
                }
            }
        }


        private int LaySoLuongTrongGio(string maSach)
        {
            int tong = 0;
            foreach (DataGridViewRow row in dgPOS.Rows)
            {
                if (!row.IsNewRow && row.Cells["dgcMaS"].Value.ToString() == maSach)
                {
                    tong += Convert.ToInt32(row.Cells["dgcSoL"].Value);
                }
            }
            return tong;
        }

        private void ThemSanPham(string MaSach, string TenSach, string TenTheLoai, string GiaBan, Image HinhAnh, int SoLuongTon)
        {
            if (!decimal.TryParse(GiaBan, out decimal parsedPrice))
            {
                MessageBox.Show("Giá bán không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var w = new ucSanPhamSach()
            {
                MaSach = MaSach,
                TenSach = TenSach,
                GiaBan = parsedPrice,
                HinHAnh = HinhAnh,
                SoLuongTon = SoLuongTon,
                SoLuongTonGoc = SoLuongTon // lưu lại số lượng thực tế
            };

            if (SoLuongTon <= 0)
            {
                w.Cursor = Cursors.Default;
                w.SetHetHang();
            }
            else
            {
                w.onSelect += (ss, ee) =>
                {
                    var wdg = (ucSanPhamSach)ss;

                    int soLuongHienTai = LaySoLuongTrongGio(wdg.MaSach);

                    if (soLuongHienTai >= wdg.SoLuongTonGoc)
                    {
                        ht.ThongBao(this, "Cảnh báo", "Số lượng đặt đã đạt giới hạn tồn kho!", MessageDialogIcon.Warning);
                        return;
                    }

                    bool daCoTrongGio = false;

                    foreach (DataGridViewRow item in dgPOS.Rows)
                    {
                        if (item.Cells["dgcMaS"].Value.ToString() == wdg.MaSach)
                        {
                            int slMoi = Convert.ToInt32(item.Cells["dgcSoL"].Value) + 1;
                            double gia = Convert.ToDouble(item.Cells["dgcGiaB"].Value);
                            UpdateProductQuantity(item, slMoi, gia);

                            daCoTrongGio = true;
                            break;
                        }
                    }

                    if (!daCoTrongGio)
                    {
                        dgPOS.Rows.Add(new object[]
                        {
                            dgPOS.Rows.Count + 1,
                            wdg.MaSach,
                            wdg.TenSach,
                            1,
                            Convert.ToDouble(wdg.GiaBan),
                            Convert.ToDouble(wdg.GiaBan)
                                });
                    }

                    int soLuongConLai = wdg.SoLuongTonGoc - LaySoLuongTrongGio(wdg.MaSach);
                    wdg.SoLuongTon = soLuongConLai;

                    if (soLuongConLai <= 0)
                    {
                        wdg.SetHetHang();
                        wdg.Enabled = false;
                    }

                    Laytong();
                };
            }

            flpSach.Controls.Add(w);
        }


        // Helper method to update quantity and total price in a DataGridView row
        private void UpdateProductQuantity(DataGridViewRow row, int quantity, double price)
        {
            row.Cells["dgcSoL"].Value = quantity;
            row.Cells["dgcTongT"].Value = price * quantity;
        }
        private void Laytong()
        {
            double tongTien = 0;

            // Tính tổng tiền các sản phẩm
            foreach (DataGridViewRow item in dgPOS.Rows)
            {
                if (item.Cells["dgcTongT"].Value != null && item.Cells["dgcTongT"].Value.ToString() != "")
                {
                    tongTien += Convert.ToDouble(item.Cells["dgcTongT"].Value);
                }
            }
            lblTotal.Text = tongTien.ToString();
            // Mặc định không giảm
            double phanTramGiam = 0;

            // Lấy phần trăm giảm giá từ ô nhập
            double.TryParse(txtGiamGia.Text, out phanTramGiam);
            if (phanTramGiam < 0) phanTramGiam = 0;
            if (phanTramGiam > 100) phanTramGiam = 100;

            double tienGiam = tongTien * (phanTramGiam / 100);
            double tienPhaiTra = tongTien - tienGiam;

            // Gán lại lên label
            lbTienPT.Text = tienPhaiTra.ToString("N2");
        }
        public string Macapnhat;
        private void btnXemGioHang_Click(object sender, EventArgs e)
        {
            frmGioHang fGH = new frmGioHang(this);
            fGH.ShowDialog();

            // Kiểm tra giá trị mã giỏ hàng trước khi truyền
            Macapnhat = fGH.maGioHang;
            if (string.IsNullOrEmpty(fGH.maGioHang))
            {
                //MessageBox.Show("Không có mã giỏ hàng để cập nhật.");
                return;
            }

            //UpdateMaGioHang(fGH.maGioHang); // Truyền giá trị vào để load dữ liệu

        }
        public void UpdateMaGioHang(string magiohang)
        {
            //?

            //dgPOS.Rows.Clear();
            LoadChiTietGioHang(magiohang);
            //dgPOS.AutoGenerateColumns = false;
            //dgPOS.DataSource = bus.HienThiChiTietGioHangTheoMa(magiohang);
            //dgPOS.Columns["dgcMaS"].DataPropertyName = "MaSach";
            //dgPOS.Columns["dgcTenS"].DataPropertyName = "TenSach";
            //dgPOS.Columns["dgcSoL"].DataPropertyName = "SoLuong";
            //dgPOS.Columns["dgcGiaB"].DataPropertyName = "GiaBan";
            //dgPOS.Columns["dgcTongT"].DataPropertyName = "TongTien";
        }
        private void dgPOS_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                // Lấy hàng hiện tại
                DataGridViewRow row = dgPOS.Rows[e.RowIndex];

                // Lấy số lượng và giá mới
                int quantity = Convert.ToInt32(row.Cells["dgcSoL"].Value);
                double price = Convert.ToDouble(row.Cells["dgcGiaB"].Value);

                // Cập nhật giá trị tổng tiền
                row.Cells["dgcTongT"].Value = quantity * price;

                Laytong(); // Tính lại tổng tiền cho toàn bộ giỏ hàng
            }
        }
        public bool hien = false;
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            
            
        }
        private void LoadSach()
        {
            flpSach.Controls.Clear();
            DataTable dt = bus.LayDanhSach();
            foreach (DataRow item in dt.Rows)
            {
                Byte[] imgarray = (byte[])item["HinhAnh"];
                byte[] imgbytearray = imgarray;
                ThemSanPham(item["MaSach"].ToString(), item["TenSach"].ToString(), item["MaTheLoai"].ToString(), item["GiaBan"].ToString()
                    , Image.FromStream(new MemoryStream(imgarray)), Convert.ToInt32(item["SoLuongTon"]));
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in flpSach.Controls)
            {
                var s = (ucSanPhamSach)item;
                s.Visible = s.TenSach.ToLower().Contains(txtTimKiem.Text.Trim().ToLower());
            }
        }
        private void Locsachtheotheloai(string theloai)
        {
            // Lấy danh sách sách từ cơ sở dữ liệu
            DataTable dt = bus.LayDanhSach();
            DataView dv = dt.DefaultView;

            // Kiểm tra dữ liệu trước khi áp dụng bộ lọc
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để lọc.");
                return;
            }

            // Áp dụng bộ lọc để lấy sách theo thể loại
            dv.RowFilter = $"TenTheLoai = '{theloai.Trim()}'";

            flpSach.Controls.Clear();

            foreach (DataRow item in dv.ToTable().Rows)
            {
                if (item["HinhAnh"] == DBNull.Value || !(item["HinhAnh"] is byte[]))
                {
                    MessageBox.Show("Dữ liệu hình ảnh không hợp lệ.");
                    continue;
                }

                Byte[] imgarray = (byte[])item["HinhAnh"];
                ThemSanPham(
                    item["MaSach"].ToString(),
                    item["TenSach"].ToString(),
                    item["TenTheLoai"].ToString(),
                    item["GiaBan"].ToString(),
                    Image.FromStream(new MemoryStream(imgarray)),
                    Convert.ToInt32(item["SoLuongTon"])
                );
            }
        }
        
        //private void btnLamMoi_Click(object sender, EventArgs e)
        //{
        //    dgPOS.Rows.Clear();
        //    lblTotal.Text = "0";
        //}

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            frmPOS_Load(sender, e);
            //dgPOS.Rows.Clear(); 
            //lblTotal.Text = "0";
            
        }
        BLL_GioHang bll_gh = new BLL_GioHang();
        
        BLL_ChiTietGioHang bll_ctgh = new BLL_ChiTietGioHang();

        private void btnThemGioHang_Click(object sender, EventArgs e)
        {
            
        }

        
        public void LoadChiTietGioHang(string maGH, string sdt = null)
        {
            dgPOS.Rows.Clear();
            DataTable dt = bll_ctgh.HienThiDuLieu(maGH);
            foreach (DataRow row in dt.Rows)
            {
                dgPOS.Rows.Add(new object[]
                {
                    dgPOS.Rows.Count + 1,
                    row["MaSach"].ToString(),
                    row["TenSach"].ToString(),
                    Convert.ToDecimal(row["SoLuong"]),
                    Convert.ToDecimal(row["GiaBan"]),
                    Convert.ToDecimal(row["SoLuong"]) * Convert.ToDecimal(row["GiaBan"])
                });

            }
            Laytong();
            btnCapNhatt.Enabled = true;
            txtSoDT.Text = sdt;
        }
        BLL_POS bll_pos = new BLL_POS();
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Macapnhat))
            {
                // Tạo mới giỏ hàng
                DTO_GioHang gioHang = new DTO_GioHang
                {
                    SDT = txtSoDT.Text,
                    MaNV = _manv
                };

                string maGioHang = bll_gh.ThemGioHangSinhMa(gioHang);
                MessageBox.Show("Giỏ hàng mới được tạo với mã: " + maGioHang);

                if (!string.IsNullOrEmpty(maGioHang))
                {
                    int soLuongChiTiet = 0;

                    foreach (DataGridViewRow row in dgPOS.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string maSach = row.Cells["dgcMaS"].Value.ToString();
                        int soLuong = Convert.ToInt32(row.Cells["dgcSoL"].Value);
                        decimal giaBan = Convert.ToDecimal(row.Cells["dgcGiaB"].Value);

                        DTO_ChiTietGioHang ctgh = new DTO_ChiTietGioHang
                        {
                            MaGioHang = maGioHang,
                            MaSach = maSach,
                            SoLuong = soLuong,
                            GiaBan = giaBan
                        };

                        int kq = bll_ctgh.ThemDuLieuVaoChiTietHoaDon(ctgh);

                        if (kq > 0)
                        {
                            soLuongChiTiet++;

                            //bus.TruTonKho(maSach, soLuong);
                        }
                    }

                    MessageBox.Show("Đã thêm giỏ hàng và " + soLuongChiTiet + " sản phẩm chi tiết.");

                    if (bll_pos.CapNhatTrangThai(maGioHang) > 0)
                    {
                        ht.ThongBao(this, "Thông báo!", "Đã cập nhật và Thanh toán thành công!", MessageDialogIcon.Information);
                        foreach (DataGridViewRow row in dgPOS.Rows)
                        {
                            if (row.IsNewRow) continue;

                            string maSach = row.Cells["dgcMaS"].Value.ToString();
                            int soLuong = Convert.ToInt32(row.Cells["dgcSoL"].Value);

                            bus.TruTonKho(maSach, soLuong);
                        }
                        frmPOS_Load(sender, e);
                    }

                    Reset();
                }
                else
                {
                    MessageBox.Show("Không thể thêm giỏ hàng. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Đã có mã giỏ hàng, chỉ cần cập nhật trạng thái
                if (bll_pos.CapNhatTrangThai(Macapnhat) > 0)
                {
                    ht.ThongBao(this, "Thông báo!", "Thanh toán thành công!", MessageDialogIcon.Information);

                    foreach (DataGridViewRow row in dgPOS.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string maSach = row.Cells["dgcMaS"].Value.ToString();
                        int soLuong = Convert.ToInt32(row.Cells["dgcSoL"].Value);

                        bus.TruTonKho(maSach, soLuong);
                    }

                    Reset();
                }
            }
        }





        private void btnThemKH_Click(object sender, EventArgs e)
        {
            frmKhachHangAdd fKHDadd = new frmKhachHangAdd();
            ht.BlurBackground(fKHDadd);
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            Laytong();
        }

        private void btnThemVGH_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrWhiteSpace(txtSoDT.Text))
            {
                ht.ThongBao(this, "Cảnh báo", "Số điện thoại không được để trống!", MessageDialogIcon.Warning);
                txtSoDT.Focus();
                return; // Ngắt luôn, không cho chạy tiếp
            }

            // Tạo đối tượng giỏ hàng
            DTO_GioHang gioHang = new DTO_GioHang
            {
                SDT = txtSoDT.Text,
                MaNV = _manv
            };

            // Thêm vào CSDL và nhận lại mã giỏ hàng
            string maGioHang = bll_gh.ThemGioHangSinhMa(gioHang);
            MessageBox.Show("Giỏ hàng mới được tạo với mã: " + maGioHang);

            if (!string.IsNullOrEmpty(maGioHang))
            {
                int soLuongChiTiet = 0;

                foreach (DataGridViewRow row in dgPOS.Rows)
                {
                    if (row.IsNewRow) continue;

                    string maSach = row.Cells["dgcMaS"].Value.ToString();
                    
                    //string tenSach = row.Cells["dgcTenS"].Value.ToString();
                    //MessageBox.Show(tenSach);

                    int soLuong = Convert.ToInt32(row.Cells["dgcSoL"].Value);
                    

                    decimal giaBan = Convert.ToDecimal(row.Cells["dgcGiaB"].Value);
                    

                    DTO_ChiTietGioHang ctgh = new DTO_ChiTietGioHang();
                    ctgh.MaGioHang = maGioHang;
                    ctgh.MaSach = maSach;
                    //ctgh.TenSach = tenSach;
                    ctgh.SoLuong = soLuong;
                    ctgh.GiaBan = giaBan;

                    int kq = bll_ctgh.ThemDuLieuVaoChiTietHoaDon(ctgh);

                    if (kq > 0)
                    {
                        soLuongChiTiet++;
                    }
                    else
                    {
                        //MessageBox.Show("Lỗi khi thêm chi tiết cho sách: " + tenSach, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                //MessageBox.Show("Đã thêm giỏ hàng và " + soLuongChiTiet + " sản phẩm chi tiết.");
                ht.ThongBao(this, "Thông báo", "Đã thêm giỏ hàng '" + soLuongChiTiet + "'", MessageDialogIcon.Information);
                // thêm xong làm mới
                Reset();
            }
            else
            {
                MessageBox.Show("Không thể thêm giỏ hàng. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Reset()
        {
            dgPOS.Rows.Clear();
            lblTotal.Text = "0";
            lbTienPT.Text = "0";
            txtGiamGia.Text = "0";
            txtSoDT.Text = "";
        }
        private void dgPOS_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgPOS.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgPOS.SelectedRows[0];
                dgPOS.Rows.Remove(row);
                CapNhatSTT();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để xoá!");
            }
        }
        private void CapNhatSTT()
        {
            for (int i = 0; i < dgPOS.Rows.Count; i++)
            {
                dgPOS.Rows[i].Cells["dgcSoTT"].Value = i + 1;
            }
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            if (dgPOS.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgPOS.SelectedRows[0];
                int soLuong = Convert.ToInt32(row.Cells["dgcSoL"].Value);

                if (soLuong > 1)
                {
                    soLuong--;
                    row.Cells["dgcSoL"].Value = soLuong;
                }
                else if (soLuong == 1)
                {
                    dgPOS.Rows.Remove(row); // Xóa dòng nếu số lượng sau khi giảm là 0
                }

                CapNhatSTT();  // Cập nhật lại số thứ tự
                Laytong();     // Tính lại tổng
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để giảm số lượng!");
            }
        }



        private void btnTang_Click(object sender, EventArgs e)
        {
            if (dgPOS.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgPOS.SelectedRows[0];

                string maSach = row.Cells["dgcMaS"].Value.ToString();
                int soLuongHienTai = Convert.ToInt32(row.Cells["dgcSoL"].Value);
                int tonKho = bus.LaySoLuongTonTheoMa(maSach); // Lấy số lượng tồn kho thực tế từ cơ sở dữ liệu hoặc nơi khác

                if (soLuongHienTai + 1 > tonKho)
                {
                    //MessageBox.Show("Số lượng đặt vượt quá tồn kho!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ht.ThongBao(this, "Cảnh báo", "Số lượng đặt vượt quá tồn kho!", MessageDialogIcon.Warning);
                    return;
                }

                // Tăng số lượng
                soLuongHienTai++;
                row.Cells["dgcSoL"].Value = soLuongHienTai;

                
                Laytong();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để tăng số lượng!");
            }
        }

        private void btnCapNhatt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Macapnhat))
            {
                MessageBox.Show("Không có giỏ hàng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int tongCapNhat = 0;

            foreach (DataGridViewRow row in dgPOS.Rows)
            {
                if (row.IsNewRow) continue;

                string maSach = row.Cells["dgcMaS"].Value?.ToString();
                if (string.IsNullOrEmpty(maSach)) continue;

                int soLuong = Convert.ToInt32(row.Cells["dgcSoL"].Value);
                decimal giaBan = Convert.ToDecimal(row.Cells["dgcGiaB"].Value);

                int kq = bus.CapNhatChiTietGioHang(Macapnhat, maSach, soLuong, giaBan);
                if (kq > 0) tongCapNhat++;
            }

            if (tongCapNhat > 0)
            {
                ht.ThongBao(this, "Thông báo", $"Đã cập nhật {tongCapNhat} sản phẩm!", MessageDialogIcon.Information);
                Reset();
                btnCapNhatt.Enabled = false;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu nào được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




    }

}
