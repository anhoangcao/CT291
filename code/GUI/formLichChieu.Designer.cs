namespace GUI
{
    partial class formLichChieu
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
            this.dtgvLC = new System.Windows.Forms.DataGridView();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbxPCLC = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbxDOBLC = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.txtMaLC = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTPLC = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGV = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnResetLC = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuaLC = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaLC = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemLC = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLC)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvLC
            // 
            this.dtgvLC.BackgroundColor = System.Drawing.Color.White;
            this.dtgvLC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLC.Location = new System.Drawing.Point(15, 283);
            this.dtgvLC.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvLC.Name = "dtgvLC";
            this.dtgvLC.RowHeadersWidth = 51;
            this.dtgvLC.RowTemplate.Height = 24;
            this.dtgvLC.Size = new System.Drawing.Size(797, 206);
            this.dtgvLC.TabIndex = 37;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox1.Controls.Add(this.cbxPCLC);
            this.guna2GroupBox1.Controls.Add(this.cbxDOBLC);
            this.guna2GroupBox1.Controls.Add(this.label7);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.guna2Button3);
            this.guna2GroupBox1.Controls.Add(this.txtMaLC);
            this.guna2GroupBox1.Controls.Add(this.txtTPLC);
            this.guna2GroupBox1.Controls.Add(this.txtGV);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.guna2GroupBox1.Location = new System.Drawing.Point(15, 14);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(797, 208);
            this.guna2GroupBox1.TabIndex = 42;
            this.guna2GroupBox1.Text = "Thông tin lịch chiếu";
            // 
            // cbxPCLC
            // 
            this.cbxPCLC.BackColor = System.Drawing.Color.Transparent;
            this.cbxPCLC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.cbxPCLC.BorderRadius = 2;
            this.cbxPCLC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxPCLC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPCLC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxPCLC.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxPCLC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxPCLC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbxPCLC.ForeColor = System.Drawing.Color.White;
            this.cbxPCLC.ItemHeight = 30;
            this.cbxPCLC.Location = new System.Drawing.Point(160, 158);
            this.cbxPCLC.Name = "cbxPCLC";
            this.cbxPCLC.Size = new System.Drawing.Size(194, 36);
            this.cbxPCLC.TabIndex = 48;
            // 
            // cbxDOBLC
            // 
            this.cbxDOBLC.BorderRadius = 4;
            this.cbxDOBLC.Checked = true;
            this.cbxDOBLC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxDOBLC.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbxDOBLC.ForeColor = System.Drawing.Color.White;
            this.cbxDOBLC.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.cbxDOBLC.Location = new System.Drawing.Point(503, 55);
            this.cbxDOBLC.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.cbxDOBLC.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.cbxDOBLC.Name = "cbxDOBLC";
            this.cbxDOBLC.Size = new System.Drawing.Size(194, 31);
            this.cbxDOBLC.TabIndex = 47;
            this.cbxDOBLC.Value = new System.DateTime(2023, 3, 17, 12, 6, 55, 376);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(48, 116);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 45;
            this.label7.Text = "Tên phim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(48, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "Phòng chiếu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(410, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 41;
            this.label6.Text = "Giá vé";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(410, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "Ngày chiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(48, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Mã lịch chiếu";
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 5;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Tomato;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(718, 6);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(73, 31);
            this.guna2Button3.TabIndex = 36;
            this.guna2Button3.Text = "Đóng";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // txtMaLC
            // 
            this.txtMaLC.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtMaLC.BorderRadius = 4;
            this.txtMaLC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaLC.DefaultText = "";
            this.txtMaLC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaLC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaLC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaLC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaLC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.txtMaLC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaLC.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMaLC.ForeColor = System.Drawing.Color.Silver;
            this.txtMaLC.HoverState.BorderColor = System.Drawing.Color.DarkBlue;
            this.txtMaLC.Location = new System.Drawing.Point(160, 55);
            this.txtMaLC.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLC.Name = "txtMaLC";
            this.txtMaLC.PasswordChar = '\0';
            this.txtMaLC.PlaceholderText = "";
            this.txtMaLC.SelectedText = "";
            this.txtMaLC.Size = new System.Drawing.Size(194, 31);
            this.txtMaLC.TabIndex = 33;
            // 
            // txtTPLC
            // 
            this.txtTPLC.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtTPLC.BorderRadius = 4;
            this.txtTPLC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTPLC.DefaultText = "";
            this.txtTPLC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTPLC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTPLC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTPLC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTPLC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.txtTPLC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTPLC.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTPLC.ForeColor = System.Drawing.Color.Silver;
            this.txtTPLC.HoverState.BorderColor = System.Drawing.Color.DarkBlue;
            this.txtTPLC.Location = new System.Drawing.Point(160, 106);
            this.txtTPLC.Margin = new System.Windows.Forms.Padding(4);
            this.txtTPLC.Name = "txtTPLC";
            this.txtTPLC.PasswordChar = '\0';
            this.txtTPLC.PlaceholderText = "";
            this.txtTPLC.SelectedText = "";
            this.txtTPLC.Size = new System.Drawing.Size(194, 31);
            this.txtTPLC.TabIndex = 33;
            // 
            // txtGV
            // 
            this.txtGV.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtGV.BorderRadius = 4;
            this.txtGV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGV.DefaultText = "";
            this.txtGV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.txtGV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGV.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtGV.ForeColor = System.Drawing.Color.Silver;
            this.txtGV.HoverState.BorderColor = System.Drawing.Color.DarkBlue;
            this.txtGV.Location = new System.Drawing.Point(503, 106);
            this.txtGV.Margin = new System.Windows.Forms.Padding(4);
            this.txtGV.Name = "txtGV";
            this.txtGV.PasswordChar = '\0';
            this.txtGV.PlaceholderText = "";
            this.txtGV.SelectedText = "";
            this.txtGV.Size = new System.Drawing.Size(194, 31);
            this.txtGV.TabIndex = 33;
            // 
            // btnResetLC
            // 
            this.btnResetLC.BorderRadius = 5;
            this.btnResetLC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResetLC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResetLC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResetLC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResetLC.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnResetLC.ForeColor = System.Drawing.Color.White;
            this.btnResetLC.Location = new System.Drawing.Point(308, 245);
            this.btnResetLC.Name = "btnResetLC";
            this.btnResetLC.Size = new System.Drawing.Size(93, 31);
            this.btnResetLC.TabIndex = 56;
            this.btnResetLC.Text = "Làm mới";
            // 
            // btnSuaLC
            // 
            this.btnSuaLC.BorderRadius = 5;
            this.btnSuaLC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaLC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaLC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaLC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaLC.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSuaLC.ForeColor = System.Drawing.Color.White;
            this.btnSuaLC.Location = new System.Drawing.Point(112, 245);
            this.btnSuaLC.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaLC.Name = "btnSuaLC";
            this.btnSuaLC.Size = new System.Drawing.Size(73, 31);
            this.btnSuaLC.TabIndex = 55;
            this.btnSuaLC.Text = "Sửa";
            // 
            // btnXoaLC
            // 
            this.btnXoaLC.BorderRadius = 5;
            this.btnXoaLC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaLC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaLC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaLC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaLC.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnXoaLC.ForeColor = System.Drawing.Color.White;
            this.btnXoaLC.Location = new System.Drawing.Point(209, 245);
            this.btnXoaLC.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaLC.Name = "btnXoaLC";
            this.btnXoaLC.Size = new System.Drawing.Size(73, 31);
            this.btnXoaLC.TabIndex = 54;
            this.btnXoaLC.Text = "Xóa";
            // 
            // btnThemLC
            // 
            this.btnThemLC.BorderRadius = 5;
            this.btnThemLC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemLC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemLC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemLC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemLC.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnThemLC.ForeColor = System.Drawing.Color.White;
            this.btnThemLC.Location = new System.Drawing.Point(15, 245);
            this.btnThemLC.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemLC.Name = "btnThemLC";
            this.btnThemLC.Size = new System.Drawing.Size(73, 31);
            this.btnThemLC.TabIndex = 53;
            this.btnThemLC.Text = "Thêm ";
            // 
            // formLichChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(824, 502);
            this.Controls.Add(this.btnResetLC);
            this.Controls.Add(this.btnSuaLC);
            this.Controls.Add(this.btnXoaLC);
            this.Controls.Add(this.btnThemLC);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.dtgvLC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formLichChieu";
            this.Text = "formLichChieu";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLC)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvLC;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2TextBox txtGV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker cbxDOBLC;
        private Guna.UI2.WinForms.Guna2TextBox txtMaLC;
        private Guna.UI2.WinForms.Guna2TextBox txtTPLC;
        private Guna.UI2.WinForms.Guna2ComboBox cbxPCLC;
        private Guna.UI2.WinForms.Guna2Button btnResetLC;
        private Guna.UI2.WinForms.Guna2Button btnSuaLC;
        private Guna.UI2.WinForms.Guna2Button btnXoaLC;
        private Guna.UI2.WinForms.Guna2Button btnThemLC;
    }
}