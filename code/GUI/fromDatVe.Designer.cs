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
            this.panelMainNav.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMainNav.Name = "panelMainNav";
            this.panelMainNav.Size = new System.Drawing.Size(267, 580);
            this.panelMainNav.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(276, 69);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(905, 512);
            this.panelMain.TabIndex = 1;
            // 
            // fromDatVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1181, 582);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMainNav);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fromDatVe";
            this.Text = "fromDatVe";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelMainNav;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
    }
}