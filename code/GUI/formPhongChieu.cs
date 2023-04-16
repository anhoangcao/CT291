using BLL;
using DAL;
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
    public partial class formPhongChieu : Form
    {
        BLL_PhongChieu bllphongchieu = new BLL_PhongChieu();
        DTO_PhongChieu dto_PhongChieu;
        public formPhongChieu()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        // DataGridView
        private void LoadGridView()
        {
            dtgvPhongChieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtgvPhongChieu.Columns[0].HeaderText = "Mã phòng chiếu";
            dtgvPhongChieu.Columns[1].HeaderText = "Tên phòng chiếu";
            dtgvPhongChieu.Columns[2].HeaderText = "Số chỗ ngồi";
            dtgvPhongChieu.Columns[3].HeaderText = "Tên màn hình";
            dtgvPhongChieu.Columns[4].HeaderText = "Tình trạng";
            foreach (DataGridViewColumn item in dtgvPhongChieu.Columns)
                item.DividerWidth = 1;

        }
        private void formPhongChieu_Load(object sender, EventArgs e)
        {
            txtMaPC.ReadOnly = true;
            DAL_NuaMua nuamua = new DAL_NuaMua();
            txtMaPC.Text = nuamua.CreateNewID("SELECT MAX(MaPhongChieu) AS Largest_ma_nv FROM PHONGCHIEU");
            dtgvPhongChieu.DataSource = bllphongchieu.List_PhongChieu();
            LoadGridView();
        }

        private void dtgvPhongChieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvPhongChieu.Rows.Count > 0)
            {
                //btnUpdate.Enabled = true;
                // btnDelete.Enabled = true;
                //txtMaNV.ReadOnly = true;
                int i;
                i = dtgvPhongChieu.CurrentRow.Index;
                txtMaPC.Text = dtgvPhongChieu.Rows[i].Cells[0].Value.ToString();
                txtTenPC.Text = dtgvPhongChieu.Rows[i].Cells[1].Value.ToString();
                txtSoCho.Text = dtgvPhongChieu.Rows[i].Cells[2].Value.ToString();
                txtTenMH.Text = dtgvPhongChieu.Rows[i].Cells[3].Value.ToString();
                guna2TextBox2.Text = dtgvPhongChieu.Rows[i].Cells[4].Value.ToString();
            }
        }

        private void MessBox(string message, bool isError = false)
        {
            if (isError)
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Thêm Phòng
        private void btnThemPC_Click(object sender, EventArgs e)
        {
            dto_PhongChieu = new DTO_PhongChieu
            (
                txtMaPC.Text,
                txtTenPC.Text,
                txtSoCho.Text,
                txtTenMH.Text,
                guna2TextBox2.Text
            );
            try
            {
                // Validate dữ liệu trước khi thực hiện thao tác
                if (string.IsNullOrEmpty(dto_PhongChieu.MaPC))
                {
                    throw new Exception("Mã phòng không được để trống");
                }
                if (string.IsNullOrEmpty(dto_PhongChieu.TenPC))
                {
                    throw new Exception("Tên phòng không được để trống");
                }
                if (string.IsNullOrEmpty(dto_PhongChieu.TinhTrang))
                {
                    throw new Exception("Tình trạng phòng không được để trống");
                }
                if (bllphongchieu.insertPC(dto_PhongChieu))
                {
                    txtMaPC.ReadOnly = true;
                    DAL_NuaMua nuamua = new DAL_NuaMua();
                    txtMaPC.Text = nuamua.CreateNewID("SELECT MAX(MaPhongChieu) AS Largest_ma_nv FROM PHONGCHIEU");
                    dtgvPhongChieu.DataSource = bllphongchieu.List_PhongChieu();
                    LoadGridView();
                    MessBox("Thêm phòng thành công");
                }
                else
                {
                    MessBox("Thêm phòng không thành công", true);
                }
                // Clear các trường nhập liệu để chuẩn bị nhập nhân viên mới
                txtTenPC.Clear();
                txtSoCho.Clear();
                txtTenMH.Clear();
                guna2TextBox2.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Sua Phong
        private void btnSuaPC_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn sửa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dto_PhongChieu = new DTO_PhongChieu
                (
                    txtMaPC.Text,
                    txtTenPC.Text,
                    txtSoCho.Text,
                    txtTenMH.Text,
                    guna2TextBox2.Text
                );
                if (bllphongchieu.updatePC(dto_PhongChieu))
                {
                    txtMaPC.ReadOnly = true;
                    DAL_NuaMua nuamua = new DAL_NuaMua();
                    txtMaPC.Text = nuamua.CreateNewID("SELECT MAX(MaPhongChieu) AS Largest_ma_nv FROM PHONGCHIEU");
                    dtgvPhongChieu.DataSource = bllphongchieu.List_PhongChieu();
                    LoadGridView();
                    MessBox("Sửa thông tin phòng thành công");
                }
                else
                {
                    MessBox("Sửa thông tin phòng thất bại");
                }
                txtTenPC.Clear();
                txtSoCho.Clear();
                txtTenMH.Clear();
                guna2TextBox2.Clear();
            }
        }

        // Xoa Phong
        private void btnXoaPC_Click(object sender, EventArgs e)
        {
            string MaPC = txtMaPC.Text;
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MaPC != null )
                {
                    bllphongchieu.deletePC(MaPC);
                    txtMaPC.ReadOnly = true;
                    DAL_NuaMua nuamua = new DAL_NuaMua();
                    txtMaPC.Text = nuamua.CreateNewID("SELECT MAX(MaPhongChieu) AS Largest_ma_nv FROM PHONGCHIEU");
                    dtgvPhongChieu.DataSource = bllphongchieu.List_PhongChieu();
                    LoadGridView();
                    MessBox("Xóa phòng thành công");
                    
                }
                else
                {
                    MessBox("Xóa phòng thất bại", true);
                }
                txtTenPC.Clear();
                txtSoCho.Clear();
                txtTenMH.Clear();
                guna2TextBox2.Clear();
            }
        }

        // Reset
        private void btnResetPC_Click(object sender, EventArgs e)
        {
            txtMaPC.ReadOnly = true;
            DAL_NuaMua nuamua = new DAL_NuaMua();
            txtMaPC.Text = nuamua.CreateNewID("SELECT MAX(MaPhongChieu) AS Largest_ma_nv FROM PHONGCHIEU");
            txtTenPC.Text = null;
            txtSoCho.Text = null;
            txtTenMH.Text = null;
            guna2TextBox2.Text = null;
        }
    }
}
