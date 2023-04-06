namespace GUI
{
    partial class fromDatVe
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
            this.panelMainNav = new Guna.UI2.WinForms.Guna2Panel();
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.btnPhongChieu = new Guna.UI2.WinForms.Guna2Button();
            this.btnLoaiPhim = new Guna.UI2.WinForms.Guna2Button();
            this.panelMainNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainNav
            // 
            this.panelMainNav.BackColor = System.Drawing.Color.Gray;
            this.panelMainNav.Controls.Add(this.btnLoaiPhim);
            this.panelMainNav.Controls.Add(this.btnPhongChieu);
            this.panelMainNav.Location = new System.Drawing.Point(1, 1);
            this.panelMainNav.Name = "panelMainNav";
            this.panelMainNav.Size = new System.Drawing.Size(183, 507);
            this.panelMainNav.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(184, 31);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(938, 548);
            this.panelMain.TabIndex = 1;
            // 
            // btnPhongChieu
            // 
            this.btnPhongChieu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPhongChieu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPhongChieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPhongChieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPhongChieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPhongChieu.ForeColor = System.Drawing.Color.White;
            this.btnPhongChieu.Location = new System.Drawing.Point(0, 159);
            this.btnPhongChieu.Name = "btnPhongChieu";
            this.btnPhongChieu.Size = new System.Drawing.Size(180, 45);
            this.btnPhongChieu.TabIndex = 0;
            this.btnPhongChieu.Text = "Phòng Chiếu";
            this.btnPhongChieu.Click += new System.EventHandler(this.btnPhongChieu_Click);
            // 
            // btnLoaiPhim
            // 
            this.btnLoaiPhim.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoaiPhim.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoaiPhim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoaiPhim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoaiPhim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoaiPhim.ForeColor = System.Drawing.Color.White;
            this.btnLoaiPhim.Location = new System.Drawing.Point(3, 234);
            this.btnLoaiPhim.Name = "btnLoaiPhim";
            this.btnLoaiPhim.Size = new System.Drawing.Size(180, 45);
            this.btnLoaiPhim.TabIndex = 0;
            this.btnLoaiPhim.Text = "Loại Phim";
            this.btnLoaiPhim.Click += new System.EventHandler(this.btnLoaiPhim_Click);
            // 
            // fromDatVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1125, 583);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMainNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fromDatVe";
            this.Text = "fromDatVe";
            this.panelMainNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelMainNav;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private Guna.UI2.WinForms.Guna2Button btnPhongChieu;
        private Guna.UI2.WinForms.Guna2Button btnLoaiPhim;
    }
}