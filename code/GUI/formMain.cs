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
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void formMain_Load(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            formKhachHang fKhachhang = new formKhachHang();
            this.Hide();
            fKhachhang.ShowDialog();
            this.Show();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            formLogin fLogin = new formLogin();
            this.Hide();
            fLogin.ShowDialog();
            this.Show();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            formNhanVien fnhanvien = new formNhanVien();
            this.Hide();
            fnhanvien.ShowDialog();
            this.Show();
        }
    }
}
