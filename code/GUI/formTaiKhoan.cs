using BLL;
using DAL;
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
    public partial class formTaiKhoan : Form
    {
        BLL_Account bllaccount = new BLL_Account();
        DTO_Account dto_Account;
        public formTaiKhoan()
        {
            InitializeComponent();
        }

        private void LoadComboBoxNhanVien()
        {
            DAL_NhanVien nv = new DAL_NhanVien();
            DataTable dt = nv.ListNhanVien();
            cbxMaNV.DisplayMember = "MaNhanVien";
            cbxMaNV.ValueMember = "TenNhanVien";
            cbxMaNV.DataSource = dt;
        }

        private void LoadGridView()
        {
            dtgvAccount.Columns[0].HeaderText = "Username";
            dtgvAccount.Columns[1].HeaderText = "Password";
            dtgvAccount.Columns[2].HeaderText = "Phân quyền";
            dtgvAccount.Columns[3].HeaderText = "Mã nhân viên";
            foreach (DataGridViewColumn item in dtgvAccount.Columns)
                item.DividerWidth = 1;
        }

        private void formTaiKhoan_Load(object sender, EventArgs e)
        {
            dtgvAccount.DataSource = bllaccount.List_Account();
            LoadGridView();
            LoadComboBoxNhanVien();
            cbxMaNV.SelectedIndex = -1;

        }

        private void MessBox(string message, bool isError = false)
        {
            if (isError)
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Xử lý sự kiện khi người dùng nhấn nút "Đổi mật khẩu"
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dtgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvAccount.Rows.Count > 0)
            {
                //btnUpdate.Enabled = true;
                // btnDelete.Enabled = true;
                //txtMaNV.ReadOnly = true;
                int i;
                i = dtgvAccount.CurrentRow.Index;
                txtUserName.Text = dtgvAccount.Rows[i].Cells[0].Value.ToString();
                txtPass.Text = dtgvAccount.Rows[i].Cells[1].Value.ToString();
                cbxPQ.Text = dtgvAccount.Rows[i].Cells[2].Value.ToString();
                cbxMaNV.Text = dtgvAccount.Rows[i].Cells[3].Value.ToString();

            }
        }

        // Them Tai Khoan
        private void btnInsertTK_Click(object sender, EventArgs e)
        {
            dto_Account = new DTO_Account
            (
                txtUserName.Text,
                txtPass.Text,
                cbxPQ.Text,
                cbxMaNV.Text
            );

            try
            {
                // Validate dữ liệu trước khi thực hiện thao tác
                if (string.IsNullOrEmpty(dto_Account.UserName))
                {
                    throw new Exception("Username không được để trống");
                }
                if (string.IsNullOrEmpty(dto_Account.Pass))
                {
                    throw new Exception("Mật khẩu không được để trống");
                }
                if (string.IsNullOrEmpty(dto_Account.LoaiTK))
                {
                    throw new Exception("Phân quyền người dùng không được để trống");
                }
                if (string.IsNullOrEmpty(dto_Account.MaNhanVien))
                {
                    throw new Exception("Mã nhân viên không được để trống");
                }
                if (bllaccount.insertAccount(dto_Account))
                {                   
                    dtgvAccount.DataSource = bllaccount.List_Account();
                    LoadGridView();
                    MessBox("Thêm tài khoản mới thành công");
                }
                else
                {
                    MessBox("Thêm tài khoản không thành công", true);
                }
                // Clear các trường nhập liệu để chuẩn bị nhập nhân viên mới
                txtUserName.Clear();
                txtPass.Clear();
                cbxPQ.SelectedIndex = -1;
                cbxMaNV.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateTK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn sửa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dto_Account = new DTO_Account
                (
                    txtUserName.Text,
                    txtPass.Text,
                    cbxPQ.Text,
                    cbxMaNV.Text
                );
                if (bllaccount.updateAccount(dto_Account))
                {                   
                    dtgvAccount.DataSource = bllaccount.List_Account();
                    LoadGridView();
                    MessBox("Sửa thông tin tài khoản thành công");
                }
                else
                {
                    MessBox("Sửa thông tin tài khoản thất bại");
                }
                txtUserName.Clear();
                cbxPQ.SelectedIndex = -1;
                cbxMaNV.SelectedIndex = -1;
                txtPass.Clear();
            }
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            string MaNV = cbxMaNV.Text;
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MaNV != null)
                {
                    bllaccount.deleteAccount(MaNV);
                    dtgvAccount.DataSource = bllaccount.List_Account();
                    LoadGridView();
                    MessBox("Xóa tài khoản thành công");
                }
                else
                {
                    MessBox("Xóa tài khoản thất bại", true);
                }
                txtUserName.Clear();
                cbxPQ.SelectedIndex = -1;
                cbxMaNV.SelectedIndex = -1;
                txtPass.Clear();
            }
        }

        private void btnResetTK_Click(object sender, EventArgs e)
        {
            txtUserName.Text = null;
            cbxPQ.Text = null;
            cbxMaNV.Text = null;
            txtPass.Text = null;
        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {
            formLogin flogin = new formLogin();
            this.Hide();
            flogin.ShowDialog();
            this.Show();
        }
    }
}
