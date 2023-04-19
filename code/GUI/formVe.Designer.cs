namespace GUI
{
    partial class formVe
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
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxShowtimeIdTextBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbxCustomerIdTextBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaDV = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtHienPhim = new Guna.UI2.WinForms.Guna2TextBox();
            this.totalPriceTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picHienAnh = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtHienGiaVe = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHienAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox1.Controls.Add(this.txtHienGiaVe);
            this.guna2GroupBox1.Controls.Add(this.picHienAnh);
            this.guna2GroupBox1.Controls.Add(this.totalPriceTextBox);
            this.guna2GroupBox1.Controls.Add(this.txtHienPhim);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.cbxShowtimeIdTextBox);
            this.guna2GroupBox1.Controls.Add(this.cbxCustomerIdTextBox);
            this.guna2GroupBox1.Controls.Add(this.gunaDV);
            this.guna2GroupBox1.Controls.Add(this.guna2Button1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.guna2GroupBox1.Location = new System.Drawing.Point(38, 267);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(744, 221);
            this.guna2GroupBox1.TabIndex = 70;
            this.guna2GroupBox1.Text = "Thông tin vé đặt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 77;
            this.label2.Text = "Mã lịch chiếu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 77;
            this.label1.Text = "Mã khách hàng";
            // 
            // cbxShowtimeIdTextBox
            // 
            this.cbxShowtimeIdTextBox.BackColor = System.Drawing.Color.Transparent;
            this.cbxShowtimeIdTextBox.BorderRadius = 4;
            this.cbxShowtimeIdTextBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxShowtimeIdTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxShowtimeIdTextBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxShowtimeIdTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxShowtimeIdTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbxShowtimeIdTextBox.ForeColor = System.Drawing.Color.Black;
            this.cbxShowtimeIdTextBox.ItemHeight = 30;
            this.cbxShowtimeIdTextBox.Location = new System.Drawing.Point(156, 107);
            this.cbxShowtimeIdTextBox.Name = "cbxShowtimeIdTextBox";
            this.cbxShowtimeIdTextBox.Size = new System.Drawing.Size(95, 36);
            this.cbxShowtimeIdTextBox.TabIndex = 76;
            this.cbxShowtimeIdTextBox.SelectedIndexChanged += new System.EventHandler(this.cbxShowtimeIdTextBox_SelectedIndexChanged);
            // 
            // cbxCustomerIdTextBox
            // 
            this.cbxCustomerIdTextBox.BackColor = System.Drawing.Color.Transparent;
            this.cbxCustomerIdTextBox.BorderRadius = 4;
            this.cbxCustomerIdTextBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxCustomerIdTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCustomerIdTextBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxCustomerIdTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxCustomerIdTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbxCustomerIdTextBox.ForeColor = System.Drawing.Color.Black;
            this.cbxCustomerIdTextBox.ItemHeight = 30;
            this.cbxCustomerIdTextBox.Location = new System.Drawing.Point(156, 51);
            this.cbxCustomerIdTextBox.Name = "cbxCustomerIdTextBox";
            this.cbxCustomerIdTextBox.Size = new System.Drawing.Size(95, 36);
            this.cbxCustomerIdTextBox.TabIndex = 75;
            this.cbxCustomerIdTextBox.SelectedIndexChanged += new System.EventHandler(this.cbxCustomerIdTextBox_SelectedIndexChanged);
            // 
            // gunaDV
            // 
            this.gunaDV.BorderRadius = 8;
            this.gunaDV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaDV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunaDV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunaDV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunaDV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaDV.ForeColor = System.Drawing.Color.White;
            this.gunaDV.Location = new System.Drawing.Point(167, 177);
            this.gunaDV.Name = "gunaDV";
            this.gunaDV.Size = new System.Drawing.Size(84, 31);
            this.gunaDV.TabIndex = 74;
            this.gunaDV.Text = "Đặt vé";
            this.gunaDV.Click += new System.EventHandler(this.gunaDV_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(42, 177);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(104, 31);
            this.guna2Button1.TabIndex = 46;
            this.guna2Button1.Text = "Chọn ghế";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(65, 22);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(687, 225);
            this.flowLayoutPanel2.TabIndex = 73;
            // 
            // txtHienPhim
            // 
            this.txtHienPhim.BorderRadius = 2;
            this.txtHienPhim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHienPhim.DefaultText = "";
            this.txtHienPhim.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHienPhim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHienPhim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHienPhim.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHienPhim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHienPhim.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHienPhim.ForeColor = System.Drawing.Color.Black;
            this.txtHienPhim.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHienPhim.Location = new System.Drawing.Point(567, 177);
            this.txtHienPhim.Name = "txtHienPhim";
            this.txtHienPhim.PasswordChar = '\0';
            this.txtHienPhim.PlaceholderText = "";
            this.txtHienPhim.SelectedText = "";
            this.txtHienPhim.Size = new System.Drawing.Size(165, 33);
            this.txtHienPhim.TabIndex = 78;
            this.txtHienPhim.TextChanged += new System.EventHandler(this.txtHienPhim_TextChanged);
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.BorderRadius = 4;
            this.totalPriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalPriceTextBox.DefaultText = "";
            this.totalPriceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.totalPriceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.totalPriceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalPriceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalPriceTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalPriceTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.totalPriceTextBox.ForeColor = System.Drawing.Color.Black;
            this.totalPriceTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalPriceTextBox.Location = new System.Drawing.Point(376, 111);
            this.totalPriceTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.PasswordChar = '\0';
            this.totalPriceTextBox.PlaceholderText = "";
            this.totalPriceTextBox.SelectedText = "";
            this.totalPriceTextBox.Size = new System.Drawing.Size(128, 32);
            this.totalPriceTextBox.TabIndex = 79;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(295, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 77;
            this.label4.Text = "Tổng tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(295, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 19);
            this.label5.TabIndex = 77;
            this.label5.Text = "Giá vé";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // picHienAnh
            // 
            this.picHienAnh.BorderRadius = 2;
            this.picHienAnh.ImageRotate = 0F;
            this.picHienAnh.Location = new System.Drawing.Point(580, 12);
            this.picHienAnh.Name = "picHienAnh";
            this.picHienAnh.Size = new System.Drawing.Size(139, 155);
            this.picHienAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHienAnh.TabIndex = 80;
            this.picHienAnh.TabStop = false;
            // 
            // txtHienGiaVe
            // 
            this.txtHienGiaVe.BorderRadius = 4;
            this.txtHienGiaVe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHienGiaVe.DefaultText = "";
            this.txtHienGiaVe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHienGiaVe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHienGiaVe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHienGiaVe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHienGiaVe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHienGiaVe.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtHienGiaVe.ForeColor = System.Drawing.Color.Black;
            this.txtHienGiaVe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHienGiaVe.Location = new System.Drawing.Point(376, 51);
            this.txtHienGiaVe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHienGiaVe.Name = "txtHienGiaVe";
            this.txtHienGiaVe.PasswordChar = '\0';
            this.txtHienGiaVe.PlaceholderText = "";
            this.txtHienGiaVe.SelectedText = "";
            this.txtHienGiaVe.Size = new System.Drawing.Size(128, 32);
            this.txtHienGiaVe.TabIndex = 81;
            this.txtHienGiaVe.TextChanged += new System.EventHandler(this.txtHienGiaVe_TextChanged);
            // 
            // formVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(824, 502);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formVe";
            this.Text = "formVe";
            this.Load += new System.EventHandler(this.formVe_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHienAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button gunaDV;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbxShowtimeIdTextBox;
        private Guna.UI2.WinForms.Guna2ComboBox cbxCustomerIdTextBox;
        private Guna.UI2.WinForms.Guna2TextBox txtHienPhim;
        private Guna.UI2.WinForms.Guna2TextBox totalPriceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2PictureBox picHienAnh;
        private Guna.UI2.WinForms.Guna2TextBox txtHienGiaVe;
    }
}