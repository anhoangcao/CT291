namespace GUI
{
    partial class formPhim
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnResetLP = new Guna.UI2.WinForms.Guna2Button();
            this.cbxPCLC = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnDongPC = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoCho = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenPC = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaPC = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnResetLC = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuaLC = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaLC = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemLC = new Guna.UI2.WinForms.Guna2Button();
            this.dtgvLC = new System.Windows.Forms.DataGridView();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(388, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "PHIM ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(28, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã phim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(28, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên phim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(326, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Thời lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(326, 148);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sản xuất";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(28, 148);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Mô tả";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(326, 102);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "Đạo diễn";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox1.Controls.Add(this.btnResetLP);
            this.guna2GroupBox1.Controls.Add(this.guna2PictureBox1);
            this.guna2GroupBox1.Controls.Add(this.cbxPCLC);
            this.guna2GroupBox1.Controls.Add(this.btnDongPC);
            this.guna2GroupBox1.Controls.Add(this.guna2TextBox4);
            this.guna2GroupBox1.Controls.Add(this.guna2TextBox3);
            this.guna2GroupBox1.Controls.Add(this.guna2TextBox2);
            this.guna2GroupBox1.Controls.Add(this.txtSoCho);
            this.guna2GroupBox1.Controls.Add(this.txtTenPC);
            this.guna2GroupBox1.Controls.Add(this.txtMaPC);
            this.guna2GroupBox1.Controls.Add(this.label7);
            this.guna2GroupBox1.Controls.Add(this.label9);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label8);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.label10);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.guna2GroupBox1.Location = new System.Drawing.Point(59, 47);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(799, 248);
            this.guna2GroupBox1.TabIndex = 36;
            this.guna2GroupBox1.Text = "Thông tin phim";
            // 
            // btnResetLP
            // 
            this.btnResetLP.BorderRadius = 5;
            this.btnResetLP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResetLP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResetLP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResetLP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResetLP.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnResetLP.ForeColor = System.Drawing.Color.White;
            this.btnResetLP.Location = new System.Drawing.Point(649, 208);
            this.btnResetLP.Name = "btnResetLP";
            this.btnResetLP.Size = new System.Drawing.Size(95, 31);
            this.btnResetLP.TabIndex = 54;
            this.btnResetLP.Text = "Chọn ảnh";
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
            this.cbxPCLC.Location = new System.Drawing.Point(123, 187);
            this.cbxPCLC.Name = "cbxPCLC";
            this.cbxPCLC.Size = new System.Drawing.Size(160, 36);
            this.cbxPCLC.TabIndex = 49;
            // 
            // btnDongPC
            // 
            this.btnDongPC.BorderRadius = 5;
            this.btnDongPC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDongPC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDongPC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDongPC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDongPC.FillColor = System.Drawing.Color.Tomato;
            this.btnDongPC.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDongPC.ForeColor = System.Drawing.Color.White;
            this.btnDongPC.Location = new System.Drawing.Point(720, 6);
            this.btnDongPC.Margin = new System.Windows.Forms.Padding(2);
            this.btnDongPC.Name = "btnDongPC";
            this.btnDongPC.Size = new System.Drawing.Size(73, 31);
            this.btnDongPC.TabIndex = 36;
            this.btnDongPC.Text = "Đóng";
            // 
            // guna2TextBox4
            // 
            this.guna2TextBox4.BorderColor = System.Drawing.Color.RoyalBlue;
            this.guna2TextBox4.BorderRadius = 4;
            this.guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox4.DefaultText = "";
            this.guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.guna2TextBox4.ForeColor = System.Drawing.Color.Silver;
            this.guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.DarkBlue;
            this.guna2TextBox4.Location = new System.Drawing.Point(427, 141);
            this.guna2TextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TextBox4.Name = "guna2TextBox4";
            this.guna2TextBox4.PasswordChar = '\0';
            this.guna2TextBox4.PlaceholderText = "";
            this.guna2TextBox4.SelectedText = "";
            this.guna2TextBox4.Size = new System.Drawing.Size(162, 31);
            this.guna2TextBox4.TabIndex = 32;
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.BorderColor = System.Drawing.Color.RoyalBlue;
            this.guna2TextBox3.BorderRadius = 4;
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.guna2TextBox3.ForeColor = System.Drawing.Color.Silver;
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.DarkBlue;
            this.guna2TextBox3.Location = new System.Drawing.Point(427, 95);
            this.guna2TextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PasswordChar = '\0';
            this.guna2TextBox3.PlaceholderText = "";
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.Size = new System.Drawing.Size(162, 31);
            this.guna2TextBox3.TabIndex = 32;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BorderColor = System.Drawing.Color.RoyalBlue;
            this.guna2TextBox2.BorderRadius = 4;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.guna2TextBox2.ForeColor = System.Drawing.Color.Silver;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.DarkBlue;
            this.guna2TextBox2.Location = new System.Drawing.Point(427, 49);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(162, 31);
            this.guna2TextBox2.TabIndex = 32;
            // 
            // txtSoCho
            // 
            this.txtSoCho.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtSoCho.BorderRadius = 4;
            this.txtSoCho.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoCho.DefaultText = "";
            this.txtSoCho.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoCho.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoCho.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoCho.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoCho.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.txtSoCho.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoCho.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSoCho.ForeColor = System.Drawing.Color.Silver;
            this.txtSoCho.HoverState.BorderColor = System.Drawing.Color.DarkBlue;
            this.txtSoCho.Location = new System.Drawing.Point(123, 141);
            this.txtSoCho.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoCho.Name = "txtSoCho";
            this.txtSoCho.PasswordChar = '\0';
            this.txtSoCho.PlaceholderText = "";
            this.txtSoCho.SelectedText = "";
            this.txtSoCho.Size = new System.Drawing.Size(160, 31);
            this.txtSoCho.TabIndex = 32;
            // 
            // txtTenPC
            // 
            this.txtTenPC.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtTenPC.BorderRadius = 4;
            this.txtTenPC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenPC.DefaultText = "";
            this.txtTenPC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenPC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenPC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenPC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenPC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.txtTenPC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenPC.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTenPC.ForeColor = System.Drawing.Color.Silver;
            this.txtTenPC.HoverState.BorderColor = System.Drawing.Color.DarkBlue;
            this.txtTenPC.Location = new System.Drawing.Point(123, 95);
            this.txtTenPC.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenPC.Name = "txtTenPC";
            this.txtTenPC.PasswordChar = '\0';
            this.txtTenPC.PlaceholderText = "";
            this.txtTenPC.SelectedText = "";
            this.txtTenPC.Size = new System.Drawing.Size(160, 31);
            this.txtTenPC.TabIndex = 31;
            // 
            // txtMaPC
            // 
            this.txtMaPC.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtMaPC.BorderRadius = 4;
            this.txtMaPC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaPC.DefaultText = "";
            this.txtMaPC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaPC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaPC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaPC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaPC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.txtMaPC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaPC.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMaPC.ForeColor = System.Drawing.Color.Silver;
            this.txtMaPC.HoverState.BorderColor = System.Drawing.Color.DarkBlue;
            this.txtMaPC.Location = new System.Drawing.Point(123, 49);
            this.txtMaPC.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPC.Name = "txtMaPC";
            this.txtMaPC.PasswordChar = '\0';
            this.txtMaPC.PlaceholderText = "";
            this.txtMaPC.SelectedText = "";
            this.txtMaPC.Size = new System.Drawing.Size(160, 31);
            this.txtMaPC.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(28, 197);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 19);
            this.label10.TabIndex = 5;
            this.label10.Text = "Thể loại";
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
            this.btnResetLC.Location = new System.Drawing.Point(352, 312);
            this.btnResetLC.Name = "btnResetLC";
            this.btnResetLC.Size = new System.Drawing.Size(93, 31);
            this.btnResetLC.TabIndex = 61;
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
            this.btnSuaLC.Location = new System.Drawing.Point(156, 312);
            this.btnSuaLC.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaLC.Name = "btnSuaLC";
            this.btnSuaLC.Size = new System.Drawing.Size(73, 31);
            this.btnSuaLC.TabIndex = 60;
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
            this.btnXoaLC.Location = new System.Drawing.Point(253, 312);
            this.btnXoaLC.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaLC.Name = "btnXoaLC";
            this.btnXoaLC.Size = new System.Drawing.Size(73, 31);
            this.btnXoaLC.TabIndex = 59;
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
            this.btnThemLC.Location = new System.Drawing.Point(59, 312);
            this.btnThemLC.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemLC.Name = "btnThemLC";
            this.btnThemLC.Size = new System.Drawing.Size(73, 31);
            this.btnThemLC.TabIndex = 58;
            this.btnThemLC.Text = "Thêm ";
            // 
            // dtgvLC
            // 
            this.dtgvLC.BackgroundColor = System.Drawing.Color.White;
            this.dtgvLC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLC.Location = new System.Drawing.Point(59, 349);
            this.dtgvLC.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvLC.Name = "dtgvLC";
            this.dtgvLC.RowHeadersWidth = 51;
            this.dtgvLC.RowTemplate.Height = 24;
            this.dtgvLC.Size = new System.Drawing.Size(799, 173);
            this.dtgvLC.TabIndex = 57;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 2;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(632, 49);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(128, 149);
            this.guna2PictureBox1.TabIndex = 50;
            this.guna2PictureBox1.TabStop = false;
            // 
            // formPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(911, 537);
            this.Controls.Add(this.btnResetLC);
            this.Controls.Add(this.btnSuaLC);
            this.Controls.Add(this.btnXoaLC);
            this.Controls.Add(this.btnThemLC);
            this.Controls.Add(this.dtgvLC);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formPhim";
            this.Text = "formPhim";
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button btnDongPC;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox txtSoCho;
        private Guna.UI2.WinForms.Guna2TextBox txtTenPC;
        private Guna.UI2.WinForms.Guna2TextBox txtMaPC;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ComboBox cbxPCLC;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnResetLP;
        private Guna.UI2.WinForms.Guna2Button btnResetLC;
        private Guna.UI2.WinForms.Guna2Button btnSuaLC;
        private Guna.UI2.WinForms.Guna2Button btnXoaLC;
        private Guna.UI2.WinForms.Guna2Button btnThemLC;
        private System.Windows.Forms.DataGridView dtgvLC;
    }
}