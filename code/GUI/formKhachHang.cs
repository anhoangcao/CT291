using BLL;
using DTO;
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
    public partial class formKhachHang : Form
    {
        public formKhachHang()
        {
            InitializeComponent();
        }

        private void formKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            formMain fMain = new formMain();
            this.Hide();
            fMain.ShowDialog();
            this.Show();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // DataGridView
        private void LoadGridView()
        {
            dtgvKhachHang.Columns[0].HeaderText = "Mã nhân viên";
            dtgvKhachHang.Columns[1].HeaderText = "Tên nhân viên";
            dtgvKhachHang.Columns[2].HeaderText = "Địa chỉ";
            dtgvKhachHang.Columns[3].HeaderText = "Điện thoại";
            foreach (DataGridViewColumn item in dtgvKhachHang.Columns)
                item.DividerWidth = 1;

        }
        BLL_KhachHang bllkhachhang = new BLL_KhachHang();

        private void dtgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void formKhachHang_Load_1(object sender, EventArgs e)
        {
            dtgvKhachHang.DataSource = bllkhachhang.List_KhachHang();
            LoadGridView();
        }
    }
}
