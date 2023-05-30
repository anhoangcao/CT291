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
    public partial class formKhachHang : Form
    {
        BLL_KhachHang bllclient = new BLL_KhachHang();
        DTO_KhachHang dto_KhachHang;

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
            formMainNV fMain = new formMainNV();
            this.Hide();
            fMain.ShowDialog();
            this.Show();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dtgvKhachHang.Rows.Count > 0)
            {
                //btnUpdate.Enabled = true;
                // btnDelete.Enabled = true;
                //txtMaNV.ReadOnly = true;
                int i;
                i = dtgvKhachHang.CurrentRow.Index;
                txtMaKH.Text = dtgvKhachHang.Rows[i].Cells[0].Value.ToString();
                txtTenKH.Text = dtgvKhachHang.Rows[i].Cells[1].Value.ToString();
                txtDiaChi.Text = dtgvKhachHang.Rows[i].Cells[2].Value.ToString();
                txtSDT.Text = dtgvKhachHang.Rows[i].Cells[3].Value.ToString();
            }
        }

        // DataGridView
        private void LoadGridView()
        {
            dtgvKhachHang.Columns[0].HeaderText = "Mã khách hàng";
            dtgvKhachHang.Columns[1].HeaderText = "Tên khách hàng";
            dtgvKhachHang.Columns[2].HeaderText = "Địa chỉ";
            dtgvKhachHang.Columns[3].HeaderText = "Điện thoại";
            foreach (DataGridViewColumn item in dtgvKhachHang.Columns)
                item.DividerWidth = 1;

        }

        private void dtgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void formKhachHang_Load_1(object sender, EventArgs e)
        {
            txtMaKH.ReadOnly = true;
            DAL_NuaMua nuamua = new DAL_NuaMua();
            txtMaKH.Text = nuamua.CreateNewID("SELECT MAX(MaKhachHang) AS Largest_ma_nv FROM KHACHHANG");
            dtgvKhachHang.DataSource = bllclient.List_KhachHang();
            LoadGridView();
        }

        private void MessBox(string message, bool isError = false)
        {
            if (isError)
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Insert Customer
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            dto_KhachHang = new DTO_KhachHang
            (
                txtMaKH.Text,
                txtTenKH.Text,
                txtDiaChi.Text,
                txtSDT.Text
            );
            try
            {
                // Validate dữ liệu trước khi thực hiện thao tác
                if (string.IsNullOrEmpty(dto_KhachHang.MaKH))
                {
                    throw new Exception("Mã khách hàng không được để trống");
                }
                if (string.IsNullOrEmpty(dto_KhachHang.HoTen))
                {
                    throw new Exception("Họ tên không được để trống");
                }
                if (string.IsNullOrEmpty(dto_KhachHang.DienThoai))
                {
                    throw new Exception("Số điện thoại không được để trống");
                }
                if (bllclient.insertCustomer(dto_KhachHang))
                {
                    txtMaKH.ReadOnly = true;
                    DAL_NuaMua nuamua = new DAL_NuaMua();
                    txtMaKH.Text = nuamua.CreateNewID("SELECT MAX(MaKhachHang) AS Largest_ma_nv FROM KHACHHANG");
                    dtgvKhachHang.DataSource = bllclient.List_KhachHang();
                    LoadGridView();
                    MessBox("Thêm khách hàng thành công");
                }
                else
                {
                    MessBox("Thêm khách hàng không thành công", true);
                }
                // Clear các trường nhập liệu để chuẩn bị nhập nhân viên mới
                txtTenKH.Clear();
                txtDiaChi.Clear();
                txtSDT.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Update Customer
        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn sửa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dto_KhachHang = new DTO_KhachHang
                (
                    txtMaKH.Text,
                    txtTenKH.Text,
                    txtDiaChi.Text,
                    txtSDT.Text
                );
                if (bllclient.updateCustomer(dto_KhachHang))
                {
                    txtMaKH.ReadOnly = true;
                    DAL_NuaMua nuamua = new DAL_NuaMua();
                    txtMaKH.Text = nuamua.CreateNewID("SELECT MAX(MaKhachHang) AS Largest_ma_nv FROM KHACHHANG");
                    dtgvKhachHang.DataSource = bllclient.List_KhachHang();
                    LoadGridView();
                    MessBox("Sửa thông tin khách hàng thành công");
                }
                else
                {
                    MessBox("Sửa thông tin khách hàng thất bại");
                }
                // Clear các trường nhập liệu để chuẩn bị nhập nhân viên mới
                txtTenKH.Clear();
                txtDiaChi.Clear();
                txtSDT.Clear();
            }
        }

        // Delete Customer
        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            string MaKH = txtMaKH.Text;
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MaKH != null)
                {
                    bllclient.deleteCustomer(MaKH);
                    txtMaKH.ReadOnly = true;
                    DAL_NuaMua nuamua = new DAL_NuaMua();
                    txtMaKH.Text = nuamua.CreateNewID("SELECT MAX(MaKhachHang) AS Largest_ma_nv FROM KHACHHANG");
                    dtgvKhachHang.DataSource = bllclient.List_KhachHang();
                    LoadGridView();
                    MessBox("Xóa khách hàng thành công");
                }
                else
                {
                    MessBox("Xóa khách hàng thất bại", true);
                }
                txtTenKH.Clear();
                txtDiaChi.Clear();
                txtSDT.Clear();
            }
        }

        // Reset Customer
        private void btnResetKH_Click(object sender, EventArgs e)
        {
            txtMaKH.ReadOnly = true;
            DAL_NuaMua nuamua = new DAL_NuaMua();
            txtMaKH.Text = nuamua.CreateNewID("SELECT MAX(MaKhachHang) AS Largest_ma_nv FROM KHACHHANG");
            txtTenKH.Text = null;
            txtDiaChi.Text = null;
            txtSDT.Text = null;
        }

        private void iconSearchKH_Click(object sender, EventArgs e)
        {
            string kh = txtSearchKH.Text;
            if (kh == "")
            {
                formKhachHang_Load(sender, e);
            }
            else
            {
                DataTable table = bllclient.searchCustomer(kh);
                dtgvKhachHang.DataSource = table;
            }
        }

        private void txtSearchKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
