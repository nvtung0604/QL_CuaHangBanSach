namespace Presentation
{
    partial class frmChonKhachHang
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
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dlmThongBao = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.flpChonKhachHang = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.ppcNhanVien = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppcNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.guna2Panel2.Controls.Add(this.btnClose);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 339);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(551, 69);
            this.guna2Panel2.TabIndex = 11;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(111)))), ((int)(((byte)(81)))));
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.ppcNhanVien);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(551, 73);
            this.guna2Panel1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(84, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chọn khách hàng";
            // 
            // dlmThongBao
            // 
            this.dlmThongBao.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.dlmThongBao.Caption = null;
            this.dlmThongBao.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.dlmThongBao.Parent = null;
            this.dlmThongBao.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.dlmThongBao.Text = null;
            // 
            // flpChonKhachHang
            // 
            this.flpChonKhachHang.Location = new System.Drawing.Point(13, 90);
            this.flpChonKhachHang.Name = "flpChonKhachHang";
            this.flpChonKhachHang.Size = new System.Drawing.Size(526, 218);
            this.flpChonKhachHang.TabIndex = 13;
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
            this.btnClose.Location = new System.Drawing.Point(371, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 45);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.TextOffset = new System.Drawing.Point(20, 0);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ppcNhanVien
            // 
            this.ppcNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.ppcNhanVien.Image = global::Presentation.Properties.Resources.icon_customer_checked1;
            this.ppcNhanVien.ImageRotate = 0F;
            this.ppcNhanVien.Location = new System.Drawing.Point(12, 8);
            this.ppcNhanVien.Name = "ppcNhanVien";
            this.ppcNhanVien.Size = new System.Drawing.Size(62, 57);
            this.ppcNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ppcNhanVien.TabIndex = 0;
            this.ppcNhanVien.TabStop = false;
            this.ppcNhanVien.UseTransparentBackground = true;
            // 
            // frmChonKhachHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(551, 408);
            this.Controls.Add(this.flpChonKhachHang);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChonKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChonKhachHang";
            this.Load += new System.EventHandler(this.frmChonKhachHang_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppcNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        public Guna.UI2.WinForms.Guna2Button btnClose;
        public Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2PictureBox ppcNhanVien;
        public Guna.UI2.WinForms.Guna2MessageDialog dlmThongBao;
        private System.Windows.Forms.FlowLayoutPanel flpChonKhachHang;
    }
}