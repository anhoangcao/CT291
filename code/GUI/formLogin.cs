using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class formLogin : Form
    {
        DTO_TKHT tkht = new DTO_TKHT();
        BLL_TKHT tkhtbll = new BLL_TKHT();
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
            //formMain fMain = new formMain();
            //this.Hide();
            //fMain.ShowDialog();
            //this.Show();

            tkht.Tkht_Taikhoan = txtTaikhoan.Text;
            tkht.Tkht_Matkhau = txtMatkhau.Text;

            string getuser = tkhtbll.CheckLogin(tkht);

            // Trả lại kết quả nếu không đúng
            switch (getuser)
            {
                case "requeid_taikhoan":
                    MessageBox.Show("Bạn chưa nhập tài khoản");
                    return;

                case "requeid_password":
                    MessageBox.Show("Bạn chưa nhập mật khẩu");
                    return;

                case "Tài khoản hoặc mật khẩu không đúng!":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
                    return;
            }

            if(txtTaikhoan.Text == "admin" && txtMatkhau.Text == "12345")
            {
                formMain fMain = new formMain();
                this.Hide();
                fMain.ShowDialog();
                this.Show();
            } else if(txtTaikhoan.Text == "user" && txtMatkhau.Text == "67890")
            {
                formMainNV fMainnv = new formMainNV();
                this.Hide();
                fMainnv.ShowDialog();
                this.Show();
            }

            
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
