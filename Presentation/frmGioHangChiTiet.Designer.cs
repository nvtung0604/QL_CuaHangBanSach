namespace Presentation
{
    partial class frmGioHangChiTiet
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
            this.dgcChiTietGioHang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgcTenS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcSoL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcGiaB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgcChiTietGioHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgcChiTietGioHang
            // 
            this.dgcChiTietGioHang.AllowUserToAddRows = false;
            this.dgcChiTietGioHang.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgcChiTietGioHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgcChiTietGioHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcChiTietGioHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgcChiTietGioHang.ColumnHeadersHeight = 40;
            this.dgcChiTietGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgcChiTietGioHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcTenS,
            this.dgcSoL,
            this.dgcGiaB});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgcChiTietGioHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgcChiTietGioHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgcChiTietGioHang.Location = new System.Drawing.Point(12, 118);
            this.dgcChiTietGioHang.Name = "dgcChiTietGioHang";
            this.dgcChiTietGioHang.ReadOnly = true;
            this.dgcChiTietGioHang.RowHeadersVisible = false;
            this.dgcChiTietGioHang.RowHeadersWidth = 51;
            this.dgcChiTietGioHang.RowTemplate.Height = 35;
            this.dgcChiTietGioHang.Size = new System.Drawing.Size(814, 376);
            this.dgcChiTietGioHang.TabIndex = 16;
            this.dgcChiTietGioHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgcChiTietGioHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgcChiTietGioHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgcChiTietGioHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgcChiTietGioHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgcChiTietGioHang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgcChiTietGioHang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgcChiTietGioHang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgcChiTietGioHang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgcChiTietGioHang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgcChiTietGioHang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgcChiTietGioHang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgcChiTietGioHang.ThemeStyle.HeaderStyle.Height = 40;
            this.dgcChiTietGioHang.ThemeStyle.ReadOnly = true;
            this.dgcChiTietGioHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgcChiTietGioHang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgcChiTietGioHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgcChiTietGioHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgcChiTietGioHang.ThemeStyle.RowsStyle.Height = 35;
            this.dgcChiTietGioHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgcChiTietGioHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dgcTenS
            // 
            this.dgcTenS.HeaderText = "Tên sách";
            this.dgcTenS.MinimumWidth = 6;
            this.dgcTenS.Name = "dgcTenS";
            this.dgcTenS.ReadOnly = true;
            // 
            // dgcSoL
            // 
            this.dgcSoL.HeaderText = "Số lượng";
            this.dgcSoL.MinimumWidth = 6;
            this.dgcSoL.Name = "dgcSoL";
            this.dgcSoL.ReadOnly = true;
            // 
            // dgcGiaB
            // 
            this.dgcGiaB.HeaderText = "Giá bán";
            this.dgcGiaB.MinimumWidth = 6;
            this.dgcGiaB.Name = "dgcGiaB";
            this.dgcGiaB.ReadOnly = true;
            // 
            // btnClose
            // 
            this.btnClose.AutoRoundedCorners = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(111)))), ((int)(((byte)(81)))));
            this.btnClose.CheckedState.Image = global::Presentation.Properties.Resources.icon_home_checked1;
            this.btnClose.CustomizableEdges.TopRight = false;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(111)))), ((int)(((byte)(81)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::Presentation.Properties.Resources.icon_close;
            this.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnClose.Location = new System.Drawing.Point(646, 24);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 45);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.TextOffset = new System.Drawing.Point(20, 0);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmGioHangChiTiet
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 568);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgcChiTietGioHang);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGioHangChiTiet";
            this.Text = "frmGioHangChiTiet";
            this.Load += new System.EventHandler(this.frmGioHangChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcChiTietGioHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgcChiTietGioHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTenS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSoL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcGiaB;
        public Guna.UI2.WinForms.Guna2Button btnClose;
    }
}