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
            this.SuspendLayout();
            // 
            // panelMainNav
            // 
            this.panelMainNav.BackColor = System.Drawing.Color.Gray;
            this.panelMainNav.Location = new System.Drawing.Point(1, 1);
            this.panelMainNav.Name = "panelMainNav";
            this.panelMainNav.Size = new System.Drawing.Size(200, 471);
            this.panelMainNav.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(207, 35);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(679, 437);
            this.panelMain.TabIndex = 1;
            // 
            // fromDatVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(886, 473);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMainNav);
            this.Name = "fromDatVe";
            this.Text = "fromDatVe";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelMainNav;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
    }
}