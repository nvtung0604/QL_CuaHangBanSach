namespace Presentation
{
    partial class frmBaoCao
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpTuNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpDenNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnXem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.chartBaoCao = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgBaoCao = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.btnSoLuongGioHang = new Guna.UI2.WinForms.Guna2Button();
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.dgcSoTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcSoLHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcTongT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXuatRaExcel = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBaoCao)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Checked = true;
            this.dtpTuNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpTuNgay.Location = new System.Drawing.Point(13, 31);
            this.dtpTuNgay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTuNgay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(184, 36);
            this.dtpTuNgay.TabIndex = 0;
            this.dtpTuNgay.Value = new System.DateTime(2025, 4, 10, 16, 26, 38, 586);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Checked = true;
            this.dtpDenNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDenNgay.Location = new System.Drawing.Point(223, 31);
            this.dtpDenNgay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDenNgay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 36);
            this.dtpDenNgay.TabIndex = 0;
            this.dtpDenNgay.Value = new System.DateTime(2025, 4, 10, 16, 26, 38, 586);
            // 
            // btnXem
            // 
            this.btnXem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Location = new System.Drawing.Point(446, 31);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(127, 36);
            this.btnXem.TabIndex = 1;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.Controls.Add(this.chartBaoCao);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 91);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(620, 257);
            this.guna2Panel1.TabIndex = 2;
            // 
            // chartBaoCao
            // 
            chartArea2.Name = "ChartArea1";
            this.chartBaoCao.ChartAreas.Add(chartArea2);
            this.chartBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartBaoCao.Legends.Add(legend2);
            this.chartBaoCao.Location = new System.Drawing.Point(0, 0);
            this.chartBaoCao.Name = "chartBaoCao";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Số lượng giỏ hàng";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Thanh toán";
            this.chartBaoCao.Series.Add(series3);
            this.chartBaoCao.Series.Add(series4);
            this.chartBaoCao.Size = new System.Drawing.Size(620, 257);
            this.chartBaoCao.TabIndex = 0;
            this.chartBaoCao.Text = "chart1";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.Controls.Add(this.dgBaoCao);
            this.guna2Panel2.Location = new System.Drawing.Point(12, 371);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(965, 250);
            this.guna2Panel2.TabIndex = 3;
            // 
            // dgBaoCao
            // 
            this.dgBaoCao.AllowUserToAddRows = false;
            this.dgBaoCao.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgBaoCao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBaoCao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgBaoCao.ColumnHeadersHeight = 36;
            this.dgBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgBaoCao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcSoTT,
            this.dgcTenNV,
            this.dgcSoLHD,
            this.dgcTongT});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgBaoCao.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBaoCao.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgBaoCao.Location = new System.Drawing.Point(0, 0);
            this.dgBaoCao.Name = "dgBaoCao";
            this.dgBaoCao.ReadOnly = true;
            this.dgBaoCao.RowHeadersVisible = false;
            this.dgBaoCao.RowHeadersWidth = 51;
            this.dgBaoCao.Size = new System.Drawing.Size(965, 250);
            this.dgBaoCao.TabIndex = 0;
            this.dgBaoCao.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgBaoCao.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgBaoCao.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgBaoCao.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgBaoCao.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgBaoCao.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgBaoCao.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgBaoCao.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgBaoCao.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgBaoCao.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgBaoCao.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgBaoCao.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgBaoCao.ThemeStyle.HeaderStyle.Height = 36;
            this.dgBaoCao.ThemeStyle.ReadOnly = true;
            this.dgBaoCao.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgBaoCao.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgBaoCao.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgBaoCao.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgBaoCao.ThemeStyle.RowsStyle.Height = 22;
            this.dgBaoCao.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgBaoCao.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnSoLuongGioHang
            // 
            this.btnSoLuongGioHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSoLuongGioHang.BorderRadius = 5;
            this.btnSoLuongGioHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSoLuongGioHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSoLuongGioHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSoLuongGioHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSoLuongGioHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSoLuongGioHang.ForeColor = System.Drawing.Color.White;
            this.btnSoLuongGioHang.Location = new System.Drawing.Point(693, 31);
            this.btnSoLuongGioHang.Name = "btnSoLuongGioHang";
            this.btnSoLuongGioHang.Size = new System.Drawing.Size(180, 85);
            this.btnSoLuongGioHang.TabIndex = 4;
            this.btnSoLuongGioHang.Text = "guna2Button1";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhToan.BorderRadius = 5;
            this.btnThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(693, 155);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(180, 85);
            this.btnThanhToan.TabIndex = 4;
            this.btnThanhToan.Text = "guna2Button1";
            // 
            // dgcSoTT
            // 
            this.dgcSoTT.HeaderText = "STT";
            this.dgcSoTT.MinimumWidth = 6;
            this.dgcSoTT.Name = "dgcSoTT";
            this.dgcSoTT.ReadOnly = true;
            // 
            // dgcTenNV
            // 
            this.dgcTenNV.HeaderText = "Tên nhân viên";
            this.dgcTenNV.MinimumWidth = 6;
            this.dgcTenNV.Name = "dgcTenNV";
            this.dgcTenNV.ReadOnly = true;
            // 
            // dgcSoLHD
            // 
            this.dgcSoLHD.HeaderText = "Số lượng hóa đơn";
            this.dgcSoLHD.Name = "dgcSoLHD";
            this.dgcSoLHD.ReadOnly = true;
            // 
            // dgcTongT
            // 
            this.dgcTongT.HeaderText = "Tổng tiền";
            this.dgcTongT.MinimumWidth = 6;
            this.dgcTongT.Name = "dgcTongT";
            this.dgcTongT.ReadOnly = true;
            // 
            // btnXuatRaExcel
            // 
            this.btnXuatRaExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuatRaExcel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatRaExcel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatRaExcel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXuatRaExcel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXuatRaExcel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(77)))));
            this.btnXuatRaExcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatRaExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatRaExcel.Location = new System.Drawing.Point(693, 278);
            this.btnXuatRaExcel.Name = "btnXuatRaExcel";
            this.btnXuatRaExcel.Size = new System.Drawing.Size(180, 45);
            this.btnXuatRaExcel.TabIndex = 5;
            this.btnXuatRaExcel.Text = "Xuất ra Excel";
            this.btnXuatRaExcel.Click += new System.EventHandler(this.btnXuatRaExcel_Click_1);
            // 
            // frmBaoCao
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1005, 627);
            this.Controls.Add(this.btnXuatRaExcel);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnSoLuongGioHang);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBaoCao";
            this.Text = "S";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartBaoCao)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBaoCao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTuNgay;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDenNgay;
        private Guna.UI2.WinForms.Guna2Button btnXem;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBaoCao;
        private Guna.UI2.WinForms.Guna2DataGridView dgBaoCao;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Button btnSoLuongGioHang;
        private Guna.UI2.WinForms.Guna2Button btnThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSoTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSoLHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTongT;
        private Guna.UI2.WinForms.Guna2Button btnXuatRaExcel;
    }
}