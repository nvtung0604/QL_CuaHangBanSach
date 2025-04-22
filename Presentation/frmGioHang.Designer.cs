namespace Presentation
{
    partial class frmGioHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgGioHang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnHoaDonThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.ppcNhanVien = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.dgcMaGH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcTrangT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcThoiG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcTongT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcCapNhat = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgcXoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgcInHD = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgGioHang)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppcNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgGioHang
            // 
            this.dgGioHang.AllowUserToAddRows = false;
            this.dgGioHang.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgGioHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgGioHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgGioHang.ColumnHeadersHeight = 48;
            this.dgGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgGioHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcMaGH,
            this.dgcTenKH,
            this.dgcTrangT,
            this.dgcThoiG,
            this.dgcTenNV,
            this.dgcTongT,
            this.dgcCapNhat,
            this.dgcXoa,
            this.dgcInHD});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgGioHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgGioHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgGioHang.Location = new System.Drawing.Point(0, 79);
            this.dgGioHang.Name = "dgGioHang";
            this.dgGioHang.ReadOnly = true;
            this.dgGioHang.RowHeadersVisible = false;
            this.dgGioHang.RowHeadersWidth = 51;
            this.dgGioHang.RowTemplate.Height = 24;
            this.dgGioHang.Size = new System.Drawing.Size(775, 363);
            this.dgGioHang.TabIndex = 0;
            this.dgGioHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgGioHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgGioHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgGioHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgGioHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgGioHang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgGioHang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgGioHang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgGioHang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgGioHang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgGioHang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgGioHang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgGioHang.ThemeStyle.HeaderStyle.Height = 48;
            this.dgGioHang.ThemeStyle.ReadOnly = true;
            this.dgGioHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgGioHang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgGioHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgGioHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgGioHang.ThemeStyle.RowsStyle.Height = 24;
            this.dgGioHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgGioHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgGioHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGioHang_CellClick);
            this.dgGioHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGioHang_CellContentClick);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(111)))), ((int)(((byte)(81)))));
            this.guna2Panel1.Controls.Add(this.btnHoaDonThanhToan);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.ppcNhanVien);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(775, 73);
            this.guna2Panel1.TabIndex = 11;
            // 
            // btnHoaDonThanhToan
            // 
            this.btnHoaDonThanhToan.BorderRadius = 5;
            this.btnHoaDonThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHoaDonThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHoaDonThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHoaDonThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHoaDonThanhToan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.btnHoaDonThanhToan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHoaDonThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnHoaDonThanhToan.Location = new System.Drawing.Point(582, 12);
            this.btnHoaDonThanhToan.Name = "btnHoaDonThanhToan";
            this.btnHoaDonThanhToan.Size = new System.Drawing.Size(181, 45);
            this.btnHoaDonThanhToan.TabIndex = 2;
            this.btnHoaDonThanhToan.Text = "Xem hóa đơn đã thanh toán";
            this.btnHoaDonThanhToan.Click += new System.EventHandler(this.btnHoaDonThanhToan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(84, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giỏ Hàng";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.guna2Panel2.Controls.Add(this.btnClose);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 448);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(775, 69);
            this.guna2Panel2.TabIndex = 12;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Presentation.Properties.Resources.icon_pencil;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 94;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Presentation.Properties.Resources.icon_print;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 94;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::Presentation.Properties.Resources.icon_print;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 86;
            // 
            // ppcNhanVien
            // 
            this.ppcNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.ppcNhanVien.Image = global::Presentation.Properties.Resources.icon_theloai;
            this.ppcNhanVien.ImageRotate = 0F;
            this.ppcNhanVien.Location = new System.Drawing.Point(12, 8);
            this.ppcNhanVien.Name = "ppcNhanVien";
            this.ppcNhanVien.Size = new System.Drawing.Size(62, 57);
            this.ppcNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ppcNhanVien.TabIndex = 0;
            this.ppcNhanVien.TabStop = false;
            this.ppcNhanVien.UseTransparentBackground = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderRadius = 4;
            this.btnClose.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(111)))), ((int)(((byte)(81)))));
            this.btnClose.CheckedState.Image = global::Presentation.Properties.Resources.icon_home_checked1;
            this.btnClose.CustomizableEdges.TopRight = false;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::Presentation.Properties.Resources.icon_close;
            this.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnClose.Location = new System.Drawing.Point(619, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 45);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.TextOffset = new System.Drawing.Point(20, 0);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // dgcMaGH
            // 
            this.dgcMaGH.HeaderText = "Mã giỏ hàng";
            this.dgcMaGH.MinimumWidth = 6;
            this.dgcMaGH.Name = "dgcMaGH";
            this.dgcMaGH.ReadOnly = true;
            // 
            // dgcTenKH
            // 
            this.dgcTenKH.HeaderText = "Tên khách hàng";
            this.dgcTenKH.MinimumWidth = 6;
            this.dgcTenKH.Name = "dgcTenKH";
            this.dgcTenKH.ReadOnly = true;
            // 
            // dgcTrangT
            // 
            this.dgcTrangT.HeaderText = "Trạng thái";
            this.dgcTrangT.MinimumWidth = 6;
            this.dgcTrangT.Name = "dgcTrangT";
            this.dgcTrangT.ReadOnly = true;
            // 
            // dgcThoiG
            // 
            this.dgcThoiG.HeaderText = "Thời gian";
            this.dgcThoiG.MinimumWidth = 6;
            this.dgcThoiG.Name = "dgcThoiG";
            this.dgcThoiG.ReadOnly = true;
            // 
            // dgcTenNV
            // 
            this.dgcTenNV.HeaderText = "Tên nhân viên";
            this.dgcTenNV.MinimumWidth = 6;
            this.dgcTenNV.Name = "dgcTenNV";
            this.dgcTenNV.ReadOnly = true;
            // 
            // dgcTongT
            // 
            this.dgcTongT.HeaderText = "Tổng tiền";
            this.dgcTongT.MinimumWidth = 6;
            this.dgcTongT.Name = "dgcTongT";
            this.dgcTongT.ReadOnly = true;
            // 
            // dgcCapNhat
            // 
            this.dgcCapNhat.HeaderText = "";
            this.dgcCapNhat.Image = global::Presentation.Properties.Resources.icon_pencil;
            this.dgcCapNhat.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgcCapNhat.MinimumWidth = 6;
            this.dgcCapNhat.Name = "dgcCapNhat";
            this.dgcCapNhat.ReadOnly = true;
            // 
            // dgcXoa
            // 
            this.dgcXoa.HeaderText = "";
            this.dgcXoa.Image = global::Presentation.Properties.Resources.icon_delete5;
            this.dgcXoa.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgcXoa.MinimumWidth = 6;
            this.dgcXoa.Name = "dgcXoa";
            this.dgcXoa.ReadOnly = true;
            // 
            // dgcInHD
            // 
            this.dgcInHD.HeaderText = "";
            this.dgcInHD.Image = global::Presentation.Properties.Resources.icon_print;
            this.dgcInHD.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgcInHD.MinimumWidth = 6;
            this.dgcInHD.Name = "dgcInHD";
            this.dgcInHD.ReadOnly = true;
            // 
            // frmGioHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(775, 517);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.dgGioHang);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGioHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGioHang";
            this.Load += new System.EventHandler(this.frmGioHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgGioHang)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ppcNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgGioHang;
        public Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2PictureBox ppcNhanVien;
        public Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        public Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnHoaDonThanhToan;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcMaGH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTrangT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcThoiG;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTongT;
        private System.Windows.Forms.DataGridViewImageColumn dgcCapNhat;
        private System.Windows.Forms.DataGridViewImageColumn dgcXoa;
        private System.Windows.Forms.DataGridViewImageColumn dgcInHD;
    }
}