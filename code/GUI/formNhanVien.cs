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

        // Thêm Nhân viên
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dto_NhanVien = new DTO_NhanVien
            (
                txtMaNV.Text,
                txtHoTenNV.Text,
                btnDOB.Value,
                cbxGT.Text,
                txtDiaChi.Text,
                txtSDT.Text
            );
            try
            {
                // Validate dữ liệu trước khi thực hiện thao tác
                if (string.IsNullOrEmpty(dto_NhanVien.MaNV))
                {
                    throw new Exception("Mã nhân viên không được để trống");
                }
                if (string.IsNullOrEmpty(dto_NhanVien.HoTen))
                {
                    throw new Exception("Họ tên không được để trống");
                }
                if (string.IsNullOrEmpty(dto_NhanVien.DienThoai))
                {
                    throw new Exception("Số điện thoại không được để trống");
                }
                if (bllstaff.insertStaff(dto_NhanVien))
                {
                    dtgvNhanVien.DataSource = bllstaff.List_NhanVien();
                    LoadGridView();
                    MessBox("Thêm nhân viên thành công");
                }
                else
                {
                    MessBox("Thêm nhân viên không thành công", true);
                }   
                // Clear các trường nhập liệu để chuẩn bị nhập nhân viên mới
                txtMaNV.Clear();
                txtHoTenNV.Clear();
                btnDOB.Value = DateTime.Today;
                cbxGT.SelectedIndex = -1;
                txtDiaChi.Clear();
                txtSDT.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void dtgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvNhanVien.Rows.Count > 0)
            {
                //btnUpdate.Enabled = true;
                // btnDelete.Enabled = true;
                //txtMaNV.ReadOnly = true;
                int i;
                i = dtgvNhanVien.CurrentRow.Index;
                txtMaNV.Text = dtgvNhanVien.Rows[i].Cells[0].Value.ToString();
                txtHoTenNV.Text = dtgvNhanVien.Rows[i].Cells[1].Value.ToString();
                btnDOB.Text = dtgvNhanVien.Rows[i].Cells[2].Value.ToString();
                cbxGT.Text = dtgvNhanVien.Rows[i].Cells[3].Value.ToString();
                txtDiaChi.Text = dtgvNhanVien.Rows[i].Cells[4].Value.ToString();
                txtSDT.Text = dtgvNhanVien.Rows[i].Cells[5].Value.ToString();
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            string MaNV = txtMaNV.Text;
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(MaNV != null)
                {
                    bllstaff.deleteStaff(MaNV);
                    dtgvNhanVien.DataSource = bllstaff.List_NhanVien();
                    LoadGridView();
                    MessBox("Xóa nhân viên thành công");
                }
                else
                {
                    MessBox("Xóa nhân viên thất bại", true);
                }
                txtMaNV.Clear();
                txtHoTenNV.Clear();
                btnDOB.Value = DateTime.Today;
                cbxGT.SelectedIndex = -1;
                txtDiaChi.Clear();
                txtSDT.Clear();
            }
        }

        private void btnUpdateNV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn sửa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dto_NhanVien = new DTO_NhanVien
                (
                    txtMaNV.Text,
                    txtHoTenNV.Text,
                    btnDOB.Value,
                    cbxGT.Text,
                    txtDiaChi.Text,
                    txtSDT.Text
                );
                if (bllstaff.updateStaff(dto_NhanVien))
                {
                    dtgvNhanVien.DataSource = bllstaff.List_NhanVien();
                    LoadGridView();
                    MessBox("Sửa thông tin nhân viên thành công");
                }
                else
                {
                    MessBox("Sửa thông tin nhân viên thất bại");
                }
            }
        }

        private void btnResetNV_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = null;
            txtHoTenNV.Text = null;
            //btnDOB.Value;
            cbxGT.Text = null;
            txtDiaChi.Text = null;
            txtSDT.Text = null;
        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchNV_Click(object sender, EventArgs e)
        {
            string nv = txtSearchNV.Text;
            if (nv == "")
            {
                formNhanVien_Load(sender, e);
            }
            else
            {
                DataTable table = bllstaff.searchStaff(nv);
                dtgvNhanVien.DataSource = table;
            }
        }
    }  
}
