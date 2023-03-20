using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            formMain fMain = new formMain();
            this.Hide();
            fMain.ShowDialog();
            this.Show();


        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
