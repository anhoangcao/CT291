using BLL;
using DTO;
using Guna.UI2.WinForms;
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
        BLL_NhanVien bllstaff = new BLL_NhanVien();
        DTO_NhanVien dto_NhanVien;
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

        private void formNhanVien_Load(object sender, EventArgs e)
        {
            dtgvNhanVien.DataSource = bllstaff.List_NhanVien();
            LoadGridView();
        }

        private void MessBox(string message, bool isError = false)
        {
            if (isError)
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dto_NhanVien = new DTO_NhanVien
            (
                txtMaNV.Text,
                txtHoTenNV.Text,
                Convert.ToDateTime(btnDOB.Value),
                cbxGT.SelectedValue.ToString(),
                txtDiaChi.Text,
                txtSDT.Text

            );
            if (bllstaff.insertStaff(dto_NhanVien))
            {
                dtgvNhanVien.DataSource = bllstaff.List_NhanVien();
                LoadGridView();
                MessBox("Thêm nhân viên thành công");
            }
            else
            {
                MessBox("Thêm vật tư không được", true);
            }
        }
        private void dtgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvNhanVien.Rows.Count > 0)
            {
                //btnUpdate.Enabled = true;
                // btnDelete.Enabled = true;
                txtMaNV.ReadOnly = true;
                txtMaNV.Text = dtgvNhanVien.CurrentRow.Cells[0].Value.ToString();
                txtHoTenNV.Text = dtgvNhanVien.CurrentRow.Cells[1].Value.ToString();
                btnDOB.Text = dtgvNhanVien.CurrentRow.Cells[2].Value.ToString();
                cbxGT.Text = dtgvNhanVien.CurrentRow.Cells[3].Value.ToString();
                txtDiaChi.Text = dtgvNhanVien.CurrentRow.Cells[4].Value.ToString();
                txtHoTenNV.Text = dtgvNhanVien.CurrentRow.Cells[5].Value.ToString();



            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }  
}
