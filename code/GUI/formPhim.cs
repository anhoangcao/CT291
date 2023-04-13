using BLL;
using DAL;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class formPhim : Form
    {
        BLL_Phim bllphim = new BLL_Phim();
        DTO_Phim dto_Phim;

        public formPhim()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        // Combobox
        private void LoadComboBoxLoaiPhim()
        {
            DAL_LoaiPhim loaiphim = new DAL_LoaiPhim();
            DataTable dt = loaiphim.ListLoaiPhim();
            cbxP.DisplayMember = "TenLoaiPhim";
            cbxP.ValueMember = "MaLoaiPhim";
            cbxP.DataSource = dt;
        }

        // DataGridView
        private void LoadGridView()
        {
            dtgvPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgvPhim.Columns[0].HeaderText = "Mã phim";
            dtgvPhim.Columns[1].HeaderText = "Tên phim";
            dtgvPhim.Columns[2].HeaderText = "Mô tả";
            dtgvPhim.Columns[3].HeaderText = "Thể loại";
            dtgvPhim.Columns[4].HeaderText = "Thời lượng";
            dtgvPhim.Columns[5].HeaderText = "Sản xuất";
            dtgvPhim.Columns[6].HeaderText = "Đạo diễn";
            dtgvPhim.Columns[7].HeaderText = "Poster";
            foreach (DataGridViewColumn item in dtgvPhim.Columns)
                item.DividerWidth = 1;

        }

        private void formPhim_Load(object sender, EventArgs e)
        {
            dtgvPhim.DataSource = bllphim.List_Phim();
            LoadGridView();
            LoadComboBoxLoaiPhim();
            cbxP.SelectedIndex = -1;
        }

        private void dtgvPhim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvPhim.Rows.Count > 0)
            {
                //btnUpdate.Enabled = true;
                // btnDelete.Enabled = true;
                //txtMaNV.ReadOnly = true;
                int i;
                i = dtgvPhim.CurrentRow.Index;
                txtMaP.Text = dtgvPhim.Rows[i].Cells[0].Value.ToString();
                txtTenP.Text = dtgvPhim.Rows[i].Cells[1].Value.ToString();
                txtMoTa.Text = dtgvPhim.Rows[i].Cells[2].Value.ToString();
                cbxP.Text = dtgvPhim.Rows[i].Cells[3].Value.ToString();
                txtTL.Text = dtgvPhim.Rows[i].Cells[4].Value.ToString();
                txtSX.Text = dtgvPhim.Rows[i].Cells[5].Value.ToString();
                txtDD.Text = dtgvPhim.Rows[i].Cells[6].Value.ToString();
                picbPhim.Text = dtgvPhim.Rows[i].Cells[7].Value.ToString();
                if (picbPhim.Tag != null)
                {
                    string linkImage = picbPhim.Tag.ToString(); // Lấy đường dẫn hình ảnh từ Tag của PictureBox
                    picbPhim.Image = Image.FromFile(linkImage);
                    picbPhim.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void MessBox(string message, bool isError = false)
        {
            if (isError)
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void picbPhim_Click(object sender, EventArgs e)
        {

        }

        // Insert Film
        private void btnThemPhim_Click(object sender, EventArgs e)
        {
            dto_Phim = new DTO_Phim
            (
                txtMaP.Text,
                txtTenP.Text,
                txtMoTa.Text,
                cbxP.SelectedValue.ToString(),
                int.Parse(txtTL.Text),
                txtSX.Text,
                txtDD.Text,
                ConvertImageToByteArray(picbPhim.Image) // Chuyển hình ảnh sang dạng byte array
            );
            try
            {
                // Validate dữ liệu trước khi thực hiện thao tác
                if (string.IsNullOrEmpty(dto_Phim.MaPhim))
                {
                    throw new Exception("Mã phim không được để trống");
                }
                if (string.IsNullOrEmpty(dto_Phim.TenPhim))
                {
                    throw new Exception("Tên phim không được để trống");
                }
                if (bllphim.insertPhim(dto_Phim))
                {
                    dtgvPhim.DataSource = bllphim.List_Phim();
                    LoadGridView();
                    MessBox("Thêm phim mới thành công");
                }
                else
                {
                    MessBox("Thêm phim không thành công", true);
                }
                // Clear các trường nhập liệu để chuẩn bị nhập nhân viên mới
                txtMaP.Clear();
                txtTenP.Clear();
                txtMoTa.Clear();
                txtTL.Clear();
                txtSX.Clear();
                txtDD.Clear();
                cbxP.SelectedIndex = -1;
                picbPhim.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private byte[] ConvertImageToByteArray(Image image)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                return stream.ToArray();
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files(*.jpg;*png)|*.jpg;*png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picbPhim.Image = new Bitmap(open.FileName);
                picbPhim.SizeMode = PictureBoxSizeMode.StretchImage;
                picbPhim.Tag = open.FileName; // Sử dụng Tag của PictureBox để lưu đường dẫn hình ảnh
            }
        }

        // Update Film
        private void btnSuaPhim_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn sửa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dto_Phim = new DTO_Phim
                (
                    txtMaP.Text,
                    txtTenP.Text,
                    txtMoTa.Text,
                    cbxP.SelectedValue.ToString(),
                    int.Parse(txtTL.Text),
                    txtSX.Text,
                    txtDD.Text,
                    ConvertImageToByteArray(picbPhim.Image) // Chuyển hình ảnh sang dạng byte array
                );
                if (bllphim.updatePhim(dto_Phim))
                {
                    dtgvPhim.DataSource = bllphim.List_Phim();
                    LoadGridView();
                    MessBox("Sửa thông tin phim thành công");
                }
                else
                {
                    MessBox("Sửa thông tin phim thất bại");
                }
            }
        }

        // Delete Film
        private void btnXoaPhim_Click(object sender, EventArgs e)
        {
            string MaP = txtMaP.Text;
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MaP != null)
                {
                    bllphim.deletePhim(MaP);
                    dtgvPhim.DataSource = bllphim.List_Phim();
                    LoadGridView();
                    MessBox("Xóa phim thành công");
                }
                else
                {
                    MessBox("Xóa phim thất bại", true);
                }
                txtMaP.Clear();
                txtTenP.Clear();
                txtMoTa.Clear();
                txtTL.Clear();
                txtSX.Clear();
                txtDD.Clear();
                cbxP.SelectedIndex = -1;
                picbPhim.Image = null;
            }
        }

        private void btnResetP_Click(object sender, EventArgs e)
        {
            txtMaP.Text = null;
            txtTenP.Text = null;
            txtMoTa.Text = null;
            txtTL.Text = null;
            txtSX.Text = null;
            txtDD.Text = null;
            cbxP.SelectedIndex = -1;
            picbPhim.Image = null;
        }

        private void txtTL_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
