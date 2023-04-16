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
using System.Data.SqlClient;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
                       
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            string stringConnect = @"Server=DESKTOP-0MK0TTK;Database=tesst;integrated security=true";
            SqlConnection conn = new SqlConnection(stringConnect);
            login(txtTaikhoan.Text, txtMatkhau.Text, conn);
        }


        public void login(string user, string pass, SqlConnection conn)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from TaiKhoan where UserName='" + user + "' and Pass='" + pass + "'", conn);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "sv");
            if (dataset.Tables[0].Rows.Count > 0)
            {
                conn.Open();
                string query = "SELECT TOP (1000)[LoaiTK] FROM [tesst].[dbo].[TaiKhoan] where UserName='"+user+"' and Pass='"+pass+"'";
                SqlCommand command = new SqlCommand(query, conn);
                string loaiTK = command.ExecuteScalar().ToString();
                if(int.Parse(loaiTK) == 1)
                {
                    MessageBox.Show("Chúc mừng bạn đăng nhập thành công");
                    formMain fmain = new formMain();
                    this.Hide();
                    fmain.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Chúc mừng bạn đăng nhập thành công");
                    formMainNV fmainnhanvien = new formMainNV();
                    this.Hide();
                    fmainnhanvien.ShowDialog();
                    this.Show();
                }               
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
        }
    }
}
