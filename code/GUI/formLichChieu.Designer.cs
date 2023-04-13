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
            this.cbxLPC = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbxDOBLC = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.txtMaLC = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGV = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnResetLC = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuaLC = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaLC = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemLC = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchLC = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtSearchLC = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbxPhim = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLC)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchLC)).BeginInit();
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
            this.dtgvLC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLC_CellContentClick);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox1.Controls.Add(this.cbxPhim);
            this.guna2GroupBox1.Controls.Add(this.label7);
            this.guna2GroupBox1.Controls.Add(this.cbxLPC);
            this.guna2GroupBox1.Controls.Add(this.cbxDOBLC);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.guna2Button3);
            this.guna2GroupBox1.Controls.Add(this.txtMaLC);
            this.guna2GroupBox1.Controls.Add(this.txtTT);
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
            // cbxLPC
            // 
            this.cbxLPC.BackColor = System.Drawing.Color.Transparent;
            this.cbxLPC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.cbxLPC.BorderRadius = 3;
            this.cbxLPC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxLPC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLPC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxLPC.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxLPC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxLPC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbxLPC.ForeColor = System.Drawing.Color.White;
            this.cbxLPC.ItemHeight = 30;
            this.cbxLPC.Location = new System.Drawing.Point(160, 101);
            this.cbxLPC.Name = "cbxLPC";
            this.cbxLPC.Size = new System.Drawing.Size(194, 36);
            this.cbxLPC.TabIndex = 48;
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
            this.cbxDOBLC.ValueChanged += new System.EventHandler(this.cbxDOBLC_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(48, 112);
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
            // txtTT
            // 
            this.txtTT.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtTT.BorderRadius = 4;
            this.txtTT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTT.DefaultText = "";
            this.txtTT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.txtTT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTT.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTT.ForeColor = System.Drawing.Color.Silver;
            this.txtTT.HoverState.BorderColor = System.Drawing.Color.DarkBlue;
            this.txtTT.Location = new System.Drawing.Point(503, 154);
            this.txtTT.Margin = new System.Windows.Forms.Padding(4);
            this.txtTT.Name = "txtTT";
            this.txtTT.PasswordChar = '\0';
            this.txtTT.PlaceholderText = "";
            this.txtTT.SelectedText = "";
            this.txtTT.Size = new System.Drawing.Size(194, 31);
            this.txtTT.TabIndex = 33;
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
            this.btnResetLC.Click += new System.EventHandler(this.btnResetLC_Click);
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
            this.btnSuaLC.Click += new System.EventHandler(this.btnSuaLC_Click);
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
            this.btnXoaLC.Click += new System.EventHandler(this.btnXoaLC_Click);
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
            this.btnThemLC.Click += new System.EventHandler(this.btnThemLC_Click);
            // 
            // btnSearchLC
            // 
            this.btnSearchLC.Image = global::GUI.Properties.Resources.search_removebg_preview;
            this.btnSearchLC.ImageRotate = 0F;
            this.btnSearchLC.Location = new System.Drawing.Point(778, 248);
            this.btnSearchLC.Name = "btnSearchLC";
            this.btnSearchLC.Size = new System.Drawing.Size(30, 25);
            this.btnSearchLC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearchLC.TabIndex = 58;
            this.btnSearchLC.TabStop = false;
            this.btnSearchLC.Click += new System.EventHandler(this.btnSearchLC_Click);
            // 
            // txtSearchLC
            // 
            this.txtSearchLC.BorderRadius = 2;
            this.txtSearchLC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchLC.DefaultText = "";
            this.txtSearchLC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchLC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchLC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchLC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchLC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.txtSearchLC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchLC.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearchLC.ForeColor = System.Drawing.Color.Silver;
            this.txtSearchLC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchLC.Location = new System.Drawing.Point(617, 245);
            this.txtSearchLC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchLC.Name = "txtSearchLC";
            this.txtSearchLC.PasswordChar = '\0';
            this.txtSearchLC.PlaceholderText = "";
            this.txtSearchLC.SelectedText = "";
            this.txtSearchLC.Size = new System.Drawing.Size(194, 31);
            this.txtSearchLC.TabIndex = 57;
            this.txtSearchLC.TextChanged += new System.EventHandler(this.txtSearchLC_TextChanged);
            // 
            // cbxPhim
            // 
            this.cbxPhim.BackColor = System.Drawing.Color.Transparent;
            this.cbxPhim.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.cbxPhim.BorderRadius = 3;
            this.cbxPhim.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxPhim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPhim.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxPhim.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxPhim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxPhim.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbxPhim.ForeColor = System.Drawing.Color.White;
            this.cbxPhim.ItemHeight = 30;
            this.cbxPhim.Location = new System.Drawing.Point(160, 149);
            this.cbxPhim.Name = "cbxPhim";
            this.cbxPhim.Size = new System.Drawing.Size(194, 36);
            this.cbxPhim.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(48, 160);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 49;
            this.label7.Text = "Tên phim";
            // 
            // formLichChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(824, 502);
            this.Controls.Add(this.btnSearchLC);
            this.Controls.Add(this.txtSearchLC);
            this.Controls.Add(this.btnResetLC);
            this.Controls.Add(this.btnSuaLC);
            this.Controls.Add(this.btnXoaLC);
            this.Controls.Add(this.btnThemLC);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.dtgvLC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formLichChieu";
            this.Text = "formLichChieu";
            this.Load += new System.EventHandler(this.formLichChieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLC)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchLC)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker cbxDOBLC;
        private Guna.UI2.WinForms.Guna2TextBox txtMaLC;
        private Guna.UI2.WinForms.Guna2ComboBox cbxLPC;
        private Guna.UI2.WinForms.Guna2Button btnResetLC;
        private Guna.UI2.WinForms.Guna2Button btnSuaLC;
        private Guna.UI2.WinForms.Guna2Button btnXoaLC;
        private Guna.UI2.WinForms.Guna2Button btnThemLC;
        private Guna.UI2.WinForms.Guna2PictureBox btnSearchLC;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchLC;
        private Guna.UI2.WinForms.Guna2TextBox txtTT;
        private Guna.UI2.WinForms.Guna2ComboBox cbxPhim;
        private System.Windows.Forms.Label label7;
    }
}