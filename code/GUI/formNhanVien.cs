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
    public partial class formNhanVien : Form
    {
        public formNhanVien()
        {
            InitializeComponent();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            formMain fmainnv = new formMain();
            this.Hide();
            fmainnv.ShowDialog();
            this.Show();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // DataGridView
        private void LoadGridView()
        {
            dtgvNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dtgvNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dtgvNhanVien.Columns[2].HeaderText = "Ngày sinh";
            dtgvNhanVien.Columns[3].HeaderText = "Giới tính";
            dtgvNhanVien.Columns[4].HeaderText = "Địa chỉ";
            dtgvNhanVien.Columns[5].HeaderText = "Điện thoại";
            foreach (DataGridViewColumn item in dtgvNhanVien.Columns)
                item.DividerWidth = 1;

        }
        BLL_NhanVien bllnhanvien = new BLL_NhanVien();
        private void formNhanVien_Load(object sender, EventArgs e)
        {
            dtgvNhanVien.DataSource = bllnhanvien.List_NhanVien();
            LoadGridView();
        }

        private void dtgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
