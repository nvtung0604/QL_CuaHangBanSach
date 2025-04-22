namespace Presentation
{
    partial class frmSach
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
            this.dgSach = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThem = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dgcMaS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcTenS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcTacG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcTheL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcGiaB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcSoLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcNhaXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcNamXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcTenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcHinhA = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgcCapNhat = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgcXoa = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSach
            // 
            this.dgSach.AllowUserToAddRows = false;
            this.dgSach.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgSach.ColumnHeadersHeight = 40;
            this.dgSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcMaS,
            this.dgcTenS,
            this.dgcTacG,
            this.dgcTheL,
            this.dgcGiaB,
            this.dgcSoLT,
            this.dgcNhaXB,
            this.dgcNamXB,
            this.dgcTenNCC,
            this.dgcHinhA,
            this.dgcCapNhat,
            this.dgcXoa});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSach.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgSach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgSach.Location = new System.Drawing.Point(33, 155);
            this.dgSach.Name = "dgSach";
            this.dgSach.ReadOnly = true;
            this.dgSach.RowHeadersVisible = false;
            this.dgSach.RowTemplate.Height = 35;
            this.dgSach.Size = new System.Drawing.Size(853, 376);
            this.dgSach.TabIndex = 21;
            this.dgSach.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgSach.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgSach.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgSach.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgSach.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgSach.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgSach.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgSach.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgSach.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgSach.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgSach.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgSach.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgSach.ThemeStyle.HeaderStyle.Height = 40;
            this.dgSach.ThemeStyle.ReadOnly = true;
            this.dgSach.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgSach.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgSach.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgSach.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgSach.ThemeStyle.RowsStyle.Height = 35;
            this.dgSach.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgSach.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSach_CellClick);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(33, 137);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(853, 10);
            this.guna2Separator1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(647, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Danh Sách";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Presentation.Properties.Resources.icon_edit5;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 77;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Presentation.Properties.Resources.icon_delete;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 78;
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
            this.txtTimKiem.Location = new System.Drawing.Point(650, 92);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PlaceholderText = "Tìm kiếm";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(236, 36);
            this.txtTimKiem.TabIndex = 25;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.Image = global::Presentation.Properties.Resources.icon_add;
            this.btnThem.ImageRotate = 0F;
            this.btnThem.Location = new System.Drawing.Point(22, 73);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(81, 55);
            this.btnThem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnThem.TabIndex = 22;
            this.btnThem.TabStop = false;
            this.btnThem.UseTransparentBackground = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgcMaS
            // 
            this.dgcMaS.HeaderText = " Mã sách";
            this.dgcMaS.Name = "dgcMaS";
            this.dgcMaS.ReadOnly = true;
            // 
            // dgcTenS
            // 
            this.dgcTenS.HeaderText = "Tên sách";
            this.dgcTenS.Name = "dgcTenS";
            this.dgcTenS.ReadOnly = true;
            // 
            // dgcTacG
            // 
            this.dgcTacG.HeaderText = "Tác giả";
            this.dgcTacG.Name = "dgcTacG";
            this.dgcTacG.ReadOnly = true;
            // 
            // dgcTheL
            // 
            this.dgcTheL.HeaderText = "Thể loại";
            this.dgcTheL.Name = "dgcTheL";
            this.dgcTheL.ReadOnly = true;
            // 
            // dgcGiaB
            // 
            this.dgcGiaB.HeaderText = "Giá bán";
            this.dgcGiaB.Name = "dgcGiaB";
            this.dgcGiaB.ReadOnly = true;
            // 
            // dgcSoLT
            // 
            this.dgcSoLT.HeaderText = "Số lượng tồn";
            this.dgcSoLT.Name = "dgcSoLT";
            this.dgcSoLT.ReadOnly = true;
            // 
            // dgcNhaXB
            // 
            this.dgcNhaXB.HeaderText = "Nhà xuất bản";
            this.dgcNhaXB.Name = "dgcNhaXB";
            this.dgcNhaXB.ReadOnly = true;
            // 
            // dgcNamXB
            // 
            this.dgcNamXB.HeaderText = "Năm Xuất Bản";
            this.dgcNamXB.Name = "dgcNamXB";
            this.dgcNamXB.ReadOnly = true;
            // 
            // dgcTenNCC
            // 
            this.dgcTenNCC.HeaderText = "Nhà cung cấp";
            this.dgcTenNCC.Name = "dgcTenNCC";
            this.dgcTenNCC.ReadOnly = true;
            // 
            // dgcHinhA
            // 
            this.dgcHinhA.HeaderText = "Hình ảnh";
            this.dgcHinhA.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgcHinhA.Name = "dgcHinhA";
            this.dgcHinhA.ReadOnly = true;
            // 
            // dgcCapNhat
            // 
            this.dgcCapNhat.HeaderText = "";
            this.dgcCapNhat.Image = global::Presentation.Properties.Resources.icon_edit5;
            this.dgcCapNhat.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgcCapNhat.Name = "dgcCapNhat";
            this.dgcCapNhat.ReadOnly = true;
            // 
            // dgcXoa
            // 
            this.dgcXoa.HeaderText = "";
            this.dgcXoa.Image = global::Presentation.Properties.Resources.icon_delete;
            this.dgcXoa.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgcXoa.Name = "dgcXoa";
            this.dgcXoa.ReadOnly = true;
            // 
            // frmSach
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(921, 583);
            this.Controls.Add(this.dgSach);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThem);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSach";
            this.Text = "frmSach";
            this.Load += new System.EventHandler(this.frmSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgSach;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox btnThem;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcMaS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTenS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTacG;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTheL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcGiaB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSoLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNhaXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNamXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTenNCC;
        private System.Windows.Forms.DataGridViewImageColumn dgcHinhA;
        private System.Windows.Forms.DataGridViewImageColumn dgcCapNhat;
        private System.Windows.Forms.DataGridViewImageColumn dgcXoa;
    }
}