namespace Presentation
{
    partial class frmTaiKhoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgTaiKhoan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgcMaTaiK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcTenTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcMatK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcCapNhat = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgcXoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThem = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-9, -44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Danh Sách Khách Hàng";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Presentation.Properties.Resources.icon_edit;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 170;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Presentation.Properties.Resources.icon_delete;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 171;
            // 
            // dgTaiKhoan
            // 
            this.dgTaiKhoan.AllowUserToAddRows = false;
            this.dgTaiKhoan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgTaiKhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgTaiKhoan.ColumnHeadersHeight = 40;
            this.dgTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcMaTaiK,
            this.dgcTenTK,
            this.dgcMatK,
            this.dgcRole,
            this.dgcTenNV,
            this.dgcCapNhat,
            this.dgcXoa});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTaiKhoan.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgTaiKhoan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgTaiKhoan.Location = new System.Drawing.Point(72, 90);
            this.dgTaiKhoan.Name = "dgTaiKhoan";
            this.dgTaiKhoan.ReadOnly = true;
            this.dgTaiKhoan.RowHeadersVisible = false;
            this.dgTaiKhoan.RowHeadersWidth = 51;
            this.dgTaiKhoan.RowTemplate.Height = 35;
            this.dgTaiKhoan.Size = new System.Drawing.Size(810, 487);
            this.dgTaiKhoan.TabIndex = 21;
            this.dgTaiKhoan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgTaiKhoan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgTaiKhoan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgTaiKhoan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgTaiKhoan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgTaiKhoan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgTaiKhoan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgTaiKhoan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgTaiKhoan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgTaiKhoan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgTaiKhoan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgTaiKhoan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgTaiKhoan.ThemeStyle.HeaderStyle.Height = 40;
            this.dgTaiKhoan.ThemeStyle.ReadOnly = true;
            this.dgTaiKhoan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgTaiKhoan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgTaiKhoan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgTaiKhoan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgTaiKhoan.ThemeStyle.RowsStyle.Height = 35;
            this.dgTaiKhoan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgTaiKhoan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTaiKhoan_CellClick);
            // 
            // dgcMaTaiK
            // 
            this.dgcMaTaiK.HeaderText = "Mã tài khoản";
            this.dgcMaTaiK.Name = "dgcMaTaiK";
            this.dgcMaTaiK.ReadOnly = true;
            // 
            // dgcTenTK
            // 
            this.dgcTenTK.HeaderText = "Tên tài khoản";
            this.dgcTenTK.MinimumWidth = 6;
            this.dgcTenTK.Name = "dgcTenTK";
            this.dgcTenTK.ReadOnly = true;
            // 
            // dgcMatK
            // 
            this.dgcMatK.HeaderText = "Mật khẩu";
            this.dgcMatK.MinimumWidth = 6;
            this.dgcMatK.Name = "dgcMatK";
            this.dgcMatK.ReadOnly = true;
            // 
            // dgcRole
            // 
            this.dgcRole.HeaderText = "Vai trò";
            this.dgcRole.MinimumWidth = 6;
            this.dgcRole.Name = "dgcRole";
            this.dgcRole.ReadOnly = true;
            // 
            // dgcTenNV
            // 
            this.dgcTenNV.HeaderText = "Tên nhân viên";
            this.dgcTenNV.MinimumWidth = 6;
            this.dgcTenNV.Name = "dgcTenNV";
            this.dgcTenNV.ReadOnly = true;
            // 
            // dgcCapNhat
            // 
            this.dgcCapNhat.HeaderText = "";
            this.dgcCapNhat.Image = global::Presentation.Properties.Resources.icon_edit1;
            this.dgcCapNhat.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgcCapNhat.MinimumWidth = 6;
            this.dgcCapNhat.Name = "dgcCapNhat";
            this.dgcCapNhat.ReadOnly = true;
            // 
            // dgcXoa
            // 
            this.dgcXoa.HeaderText = "";
            this.dgcXoa.Image = global::Presentation.Properties.Resources.icon_delete1;
            this.dgcXoa.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgcXoa.MinimumWidth = 6;
            this.dgcXoa.Name = "dgcXoa";
            this.dgcXoa.ReadOnly = true;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(72, 74);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(810, 10);
            this.guna2Separator1.TabIndex = 20;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.IconLeft = global::Presentation.Properties.Resources.icon_search;
            this.txtTimKiem.Location = new System.Drawing.Point(646, 31);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PlaceholderText = "Tìm kiếm";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(236, 36);
            this.txtTimKiem.TabIndex = 19;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.Image = global::Presentation.Properties.Resources.icon_add;
            this.btnThem.ImageRotate = 0F;
            this.btnThem.Location = new System.Drawing.Point(72, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(81, 55);
            this.btnThem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnThem.TabIndex = 18;
            this.btnThem.TabStop = false;
            this.btnThem.UseTransparentBackground = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Danh sách tài khoản";
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(955, 589);
            this.Controls.Add(this.dgTaiKhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTaiKhoan";
            this.Text = "frmTaiKhoan";
            this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        public Guna.UI2.WinForms.Guna2DataGridView dgTaiKhoan;
        public Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        public Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        public Guna.UI2.WinForms.Guna2PictureBox btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcMaTaiK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTenTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcMatK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTenNV;
        private System.Windows.Forms.DataGridViewImageColumn dgcCapNhat;
        private System.Windows.Forms.DataGridViewImageColumn dgcXoa;
    }
}