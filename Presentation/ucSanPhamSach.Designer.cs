namespace Presentation
{
    partial class ucSanPhamSach
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblTenS = new System.Windows.Forms.Label();
            this.btnXemThemTT = new Guna.UI2.WinForms.Guna2Button();
            this.pbHinhAnh = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.guna2Separator1);
            this.guna2ShadowPanel1.Controls.Add(this.lblTenS);
            this.guna2ShadowPanel1.Controls.Add(this.btnXemThemTT);
            this.guna2ShadowPanel1.Controls.Add(this.pbHinhAnh);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 3);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowDepth = 60;
            this.guna2ShadowPanel1.ShadowShift = 4;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(205, 242);
            this.guna2ShadowPanel1.TabIndex = 0;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(0, 185);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(199, 10);
            this.guna2Separator1.TabIndex = 3;
            // 
            // lblTenS
            // 
            this.lblTenS.BackColor = System.Drawing.Color.Transparent;
            this.lblTenS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenS.Location = new System.Drawing.Point(3, 137);
            this.lblTenS.Name = "lblTenS";
            this.lblTenS.Size = new System.Drawing.Size(196, 54);
            this.lblTenS.TabIndex = 2;
            this.lblTenS.Text = "Tên sách";
            this.lblTenS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTenS.Click += new System.EventHandler(this.lblTenS_Click);
            // 
            // btnXemThemTT
            // 
            this.btnXemThemTT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXemThemTT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXemThemTT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXemThemTT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXemThemTT.FillColor = System.Drawing.Color.Transparent;
            this.btnXemThemTT.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemThemTT.ForeColor = System.Drawing.Color.Black;
            this.btnXemThemTT.Location = new System.Drawing.Point(35, 194);
            this.btnXemThemTT.Name = "btnXemThemTT";
            this.btnXemThemTT.Size = new System.Drawing.Size(121, 39);
            this.btnXemThemTT.TabIndex = 1;
            this.btnXemThemTT.Text = "Xem thêm";
            this.btnXemThemTT.Click += new System.EventHandler(this.btnXemThemTT_Click);
            // 
            // pbHinhAnh
            // 
            this.pbHinhAnh.Image = global::Presentation.Properties.Resources.gdc_books21;
            this.pbHinhAnh.ImageRotate = 0F;
            this.pbHinhAnh.Location = new System.Drawing.Point(22, 3);
            this.pbHinhAnh.Name = "pbHinhAnh";
            this.pbHinhAnh.Size = new System.Drawing.Size(146, 135);
            this.pbHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHinhAnh.TabIndex = 0;
            this.pbHinhAnh.TabStop = false;
            this.pbHinhAnh.Click += new System.EventHandler(this.pbHinhAnh_Click);
            // 
            // ucSanPhamSach
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucSanPhamSach";
            this.Size = new System.Drawing.Size(205, 245);
            this.Load += new System.EventHandler(this.ucSanPhamSach_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox pbHinhAnh;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label lblTenS;
        private Guna.UI2.WinForms.Guna2Button btnXemThemTT;
    }
}
