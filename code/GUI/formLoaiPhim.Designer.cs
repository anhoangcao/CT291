namespace GUI
{
    partial class formLoaiPhim
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvLP = new System.Windows.Forms.DataGridView();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnResetLP = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuaLP = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaLP = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDongLP = new Guna.UI2.WinForms.Guna2Button();
            this.txtMoTa = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenLoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaLoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLP)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvLP
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvLP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvLP.BackgroundColor = System.Drawing.Color.White;
            this.dtgvLP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvLP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvLP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvLP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvLP.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvLP.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvLP.EnableHeadersVisualStyles = false;
            this.dtgvLP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvLP.Location = new System.Drawing.Point(17, 272);
            this.dtgvLP.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvLP.Name = "dtgvLP";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 14F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvLP.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvLP.RowHeadersVisible = false;
            this.dtgvLP.RowTemplate.Height = 24;
            this.dtgvLP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvLP.Size = new System.Drawing.Size(795, 219);
            this.dtgvLP.TabIndex = 55;
            this.dtgvLP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLP_CellContentClick);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(764, -28);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(34, 24);
            this.guna2ControlBox2.TabIndex = 19;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(802, -28);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(34, 24);
            this.guna2ControlBox1.TabIndex = 18;
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
            this.btnResetLP.Location = new System.Drawing.Point(311, 233);
            this.btnResetLP.Name = "btnResetLP";
            this.btnResetLP.Size = new System.Drawing.Size(94, 31);
            this.btnResetLP.TabIndex = 53;
            this.btnResetLP.Text = "Làm mới";
            this.btnResetLP.Click += new System.EventHandler(this.btnResetLP_Click);
            // 
            // btnSuaLP
            // 
            this.btnSuaLP.BorderRadius = 5;
            this.btnSuaLP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaLP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaLP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaLP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaLP.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSuaLP.ForeColor = System.Drawing.Color.White;
            this.btnSuaLP.Location = new System.Drawing.Point(116, 233);
            this.btnSuaLP.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaLP.Name = "btnSuaLP";
            this.btnSuaLP.Size = new System.Drawing.Size(73, 31);
            this.btnSuaLP.TabIndex = 52;
            this.btnSuaLP.Text = "Sửa";
            this.btnSuaLP.Click += new System.EventHandler(this.btnSuaLP_Click);
            // 
            // btnXoaLP
            // 
            this.btnXoaLP.BorderRadius = 5;
            this.btnXoaLP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaLP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaLP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaLP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaLP.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnXoaLP.ForeColor = System.Drawing.Color.White;
            this.btnXoaLP.Location = new System.Drawing.Point(212, 233);
            this.btnXoaLP.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaLP.Name = "btnXoaLP";
            this.btnXoaLP.Size = new System.Drawing.Size(73, 31);
            this.btnXoaLP.TabIndex = 51;
            this.btnXoaLP.Text = "Xóa";
            this.btnXoaLP.Click += new System.EventHandler(this.btnXoaLP_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.btnDongLP);
            this.guna2GroupBox1.Controls.Add(this.txtMoTa);
            this.guna2GroupBox1.Controls.Add(this.txtTenLoai);
            this.guna2GroupBox1.Controls.Add(this.txtMaLoai);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.guna2GroupBox1.Location = new System.Drawing.Point(17, 17);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(795, 180);
            this.guna2GroupBox1.TabIndex = 54;
            this.guna2GroupBox1.Text = "Thông tin loại phim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(419, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "Mô tả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(56, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Mã loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(56, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tên loại";
            // 
            // btnDongLP
            // 
            this.btnDongLP.BorderRadius = 5;
            this.btnDongLP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDongLP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDongLP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDongLP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDongLP.FillColor = System.Drawing.Color.Tomato;
            this.btnDongLP.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDongLP.ForeColor = System.Drawing.Color.White;
            this.btnDongLP.Location = new System.Drawing.Point(716, 6);
            this.btnDongLP.Margin = new System.Windows.Forms.Padding(2);
            this.btnDongLP.Name = "btnDongLP";
            this.btnDongLP.Size = new System.Drawing.Size(73, 31);
            this.btnDongLP.TabIndex = 36;
            this.btnDongLP.Text = "Đóng";
            this.btnDongLP.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtMoTa.BorderRadius = 2;
            this.txtMoTa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoTa.DefaultText = "";
            this.txtMoTa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMoTa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMoTa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.txtMoTa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMoTa.ForeColor = System.Drawing.Color.Silver;
            this.txtMoTa.HoverState.BorderColor = System.Drawing.Color.DarkBlue;
            this.txtMoTa.Location = new System.Drawing.Point(477, 52);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.PasswordChar = '\0';
            this.txtMoTa.PlaceholderText = "";
            this.txtMoTa.SelectedText = "";
            this.txtMoTa.Size = new System.Drawing.Size(222, 83);
            this.txtMoTa.TabIndex = 32;
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtTenLoai.BorderRadius = 4;
            this.txtTenLoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenLoai.DefaultText = "";
            this.txtTenLoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenLoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenLoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenLoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenLoai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.txtTenLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenLoai.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTenLoai.ForeColor = System.Drawing.Color.Silver;
            this.txtTenLoai.HoverState.BorderColor = System.Drawing.Color.DarkBlue;
            this.txtTenLoai.Location = new System.Drawing.Point(132, 104);
            this.txtTenLoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.PasswordChar = '\0';
            this.txtTenLoai.PlaceholderText = "";
            this.txtTenLoai.SelectedText = "";
            this.txtTenLoai.Size = new System.Drawing.Size(222, 31);
            this.txtTenLoai.TabIndex = 31;
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtMaLoai.BorderRadius = 4;
            this.txtMaLoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaLoai.DefaultText = "";
            this.txtMaLoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaLoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaLoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaLoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaLoai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.txtMaLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaLoai.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMaLoai.ForeColor = System.Drawing.Color.Silver;
            this.txtMaLoai.HoverState.BorderColor = System.Drawing.Color.DarkBlue;
            this.txtMaLoai.Location = new System.Drawing.Point(132, 52);
            this.txtMaLoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.PasswordChar = '\0';
            this.txtMaLoai.PlaceholderText = "";
            this.txtMaLoai.SelectedText = "";
            this.txtMaLoai.Size = new System.Drawing.Size(222, 31);
            this.txtMaLoai.TabIndex = 30;
            this.txtMaLoai.TextChanged += new System.EventHandler(this.txtMaLoai_TextChanged);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 5;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(18, 233);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(73, 31);
            this.guna2Button2.TabIndex = 55;
            this.guna2Button2.Text = "Thêm";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // formLoaiPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(824, 502);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.btnResetLP);
            this.Controls.Add(this.btnSuaLP);
            this.Controls.Add(this.btnXoaLP);
            this.Controls.Add(this.dtgvLP);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formLoaiPhim";
            this.Text = "formLoaiPhim";
            this.Load += new System.EventHandler(this.formLoaiPhim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLP)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvLP;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Button btnResetLP;
        private Guna.UI2.WinForms.Guna2Button btnSuaLP;
        private Guna.UI2.WinForms.Guna2Button btnXoaLP;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnDongLP;
        private Guna.UI2.WinForms.Guna2TextBox txtMoTa;
        private Guna.UI2.WinForms.Guna2TextBox txtTenLoai;
        private Guna.UI2.WinForms.Guna2TextBox txtMaLoai;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}