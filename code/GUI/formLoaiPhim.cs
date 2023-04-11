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
    public partial class formLoaiPhim : Form
    {
        BLL_LoaiPhim bllloaiphim = new BLL_LoaiPhim();
        DTO_LoaiPhim dto_LoaiPhim;
        public formLoaiPhim()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void txtMaLoai_TextChanged(object sender, EventArgs e)
        {

        }

        // DataGridView
        private void LoadGridView()
        {
            dtgvLP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgvLP.Columns[0].HeaderText = "Mã loại phim";
            dtgvLP.Columns[1].HeaderText = "Tên loại phim";
            dtgvLP.Columns[2].HeaderText = "Mô tả";
            foreach (DataGridViewColumn item in dtgvLP.Columns)
                item.DividerWidth = 1;

        }

        private void formLoaiPhim_Load(object sender, EventArgs e)
        {
            dtgvLP.DataSource = bllloaiphim.List_LoaiPhim();
            LoadGridView();
        }

        private void dtgvLP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvLP.Rows.Count > 0)
            {
                //btnUpdate.Enabled = true;
                // btnDelete.Enabled = true;
                //txtMaNV.ReadOnly = true;
                int i;
                i = dtgvLP.CurrentRow.Index;
                txtMaLoai.Text = dtgvLP.Rows[i].Cells[0].Value.ToString();
                txtTenLoai.Text = dtgvLP.Rows[i].Cells[1].Value.ToString();
                txtMoTa.Text = dtgvLP.Rows[i].Cells[2].Value.ToString();
            }
        }

        private void MessBox(string message, bool isError = false)
        {
            if (isError)
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Thêm Loại Phim
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            dto_LoaiPhim = new DTO_LoaiPhim
            (
                txtMaLoai.Text,
                txtTenLoai.Text,
                txtMoTa.Text
            );
            try
            {
                // Validate dữ liệu trước khi thực hiện thao tác
                if (string.IsNullOrEmpty(dto_LoaiPhim.MaLP))
                {
                    throw new Exception("Mã loại phim không được để trống");
                }
                if (string.IsNullOrEmpty(dto_LoaiPhim.TenLP))
                {
                    throw new Exception("Tên loại phim không được để trống");
                }
                if (bllloaiphim.insertLP(dto_LoaiPhim))
                {
                    dtgvLP.DataSource = bllloaiphim.List_LoaiPhim();
                    LoadGridView();
                    MessBox("Thêm phòng thành công");
                }
                else
                {
                    MessBox("Thêm phòng không thành công", true);
                }
                // Clear các trường nhập liệu để chuẩn bị nhập nhân viên mới
                txtMaLoai.Clear();
                txtTenLoai.Clear();
                txtMoTa.Clear();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Sửa Loại Phim
        private void btnSuaLP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn sửa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dto_LoaiPhim = new DTO_LoaiPhim
                (
                    txtMaLoai.Text,
                    txtTenLoai.Text,
                    txtMoTa.Text
                );
                if (bllloaiphim.updateLP(dto_LoaiPhim))
                {
                    dtgvLP.DataSource = bllloaiphim.List_LoaiPhim();
                    LoadGridView();
                    MessBox("Sửa thông tin loại phim thành công");
                }
                else
                {
                    MessBox("Sửa thông tin loại phim thất bại");
                }
            }
        }

        // Xóa Loại Phim
        private void btnXoaLP_Click(object sender, EventArgs e)
        {
            string MaLP = txtMaLoai.Text;
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MaLP != null)
                {
                    bllloaiphim.deleteLP(MaLP);
                    dtgvLP.DataSource = bllloaiphim.List_LoaiPhim();
                    LoadGridView();
                    MessBox("Xóa loại phim thành công");
                }
                else
                {
                    MessBox("Xóa Loại phim thất bại", true);
                }
                txtMaLoai.Clear();
                txtTenLoai.Clear();
                txtMoTa.Clear();
            }
        }

        // Reset
        private void btnResetLP_Click(object sender, EventArgs e)
        {
            txtMaLoai.Text = null;
            txtTenLoai.Text = null;
            txtMoTa.Text = null;
        }
    }
}
