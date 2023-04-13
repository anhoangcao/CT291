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
    public partial class formLichChieu : Form
    {
        BLL_LichChieu blllichchieu = new BLL_LichChieu();
        DTO_LichChieu dto_LichChieu;

        public formLichChieu()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        // Combobox
        private void LoadComboBoxTenPhim()
        {
            DAL_Phim phim = new DAL_Phim();
            DataTable dt = phim.ListPhim();
            cbxPhim.DisplayMember = "TenPhim";
            cbxPhim.ValueMember = "MaPhim";
            cbxPhim.DataSource = dt;
        }

        private void LoadComboBoxPhongChieu()
        {
            DAL_PhongChieu phong = new DAL_PhongChieu();
            DataTable dt = phong.ListPhongChieu();
            cbxLPC.DisplayMember = "TenPhongChieu";
            cbxLPC.ValueMember = "MaPhongChieu";
            cbxLPC.DataSource = dt;
        }

        // DataGridView
        private void LoadGridView()
        {
            dtgvLC.Columns[0].HeaderText = "Mã lịch chiếu";
            dtgvLC.Columns[1].HeaderText = "Tên phim";
            dtgvLC.Columns[2].HeaderText = "Tên phòng";
            dtgvLC.Columns[3].HeaderText = "Ngày chiếu";
            dtgvLC.Columns[4].HeaderText = "Giá vé";
            //dtgvLC.Columns[5].HeaderText = "Trạng thái";
            foreach (DataGridViewColumn item in dtgvLC.Columns)
                item.DividerWidth = 1;

        }

        private void formLichChieu_Load(object sender, EventArgs e)
        {
            dtgvLC.DataSource = blllichchieu.List_LichChieu();
            LoadGridView();
            LoadComboBoxTenPhim();
            LoadComboBoxPhongChieu();
        }

        private void dtgvLC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvLC.Rows.Count > 0)
            {
                //btnUpdate.Enabled = true;
                // btnDelete.Enabled = true;
                //txtMaNV.ReadOnly = true;
                int i;
                i = dtgvLC.CurrentRow.Index;
                txtMaLC.Text = dtgvLC.Rows[i].Cells[0].Value.ToString();
                cbxPhim.Text = dtgvLC.Rows[i].Cells[1].Value.ToString();
                cbxLPC.Text = dtgvLC.Rows[i].Cells[2].Value.ToString();
                cbxDOBLC.Text = dtgvLC.Rows[i].Cells[3].Value.ToString();
                txtGV.Text = dtgvLC.Rows[i].Cells[4].Value.ToString();
                //txtTT.Text = dtgvLC.Rows[i].Cells[5].Value.ToString();
            }
        }

        private void MessBox(string message, bool isError = false)
        {
            if (isError)
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Insert LichChieu
        private void btnThemLC_Click(object sender, EventArgs e)
        {
            dto_LichChieu = new DTO_LichChieu
            (
                txtMaLC.Text,
                cbxPhim.SelectedValue.ToString(),
                cbxLPC.SelectedValue.ToString(),
                cbxDOBLC.Value,
                float.Parse(txtGV.Text)
            );
            
            try
            {
                // Validate dữ liệu trước khi thực hiện thao tác
                if (string.IsNullOrEmpty(dto_LichChieu.MaLC))
                {
                    throw new Exception("Mã lịch chiếu phim không được để trống");
                }
                if (string.IsNullOrEmpty(dto_LichChieu.TenPhim))
                {
                    throw new Exception("Tên phim không được để trống");
                }
                if (string.IsNullOrEmpty(dto_LichChieu.MaPC))
                {
                    throw new Exception("Phòng chiếu không được để trống");
                }
                if (blllichchieu.insertLC(dto_LichChieu))
                {

                    dtgvLC.DataSource = blllichchieu.List_LichChieu();
                    LoadGridView();
                    MessBox("Thêm lịch chiếu phim thành công");
                }
                else
                {
                    MessBox("Thêm lịch chiếu phim không thành công", true);
                }
                // Clear các trường nhập liệu để chuẩn bị nhập nhân viên mới
                txtMaLC.Clear();
                cbxPhim.SelectedIndex = -1;
                cbxDOBLC.Value = DateTime.Today;
                cbxLPC.SelectedIndex = -1;
                txtGV.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Update LichChieu
        private void btnSuaLC_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn sửa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dto_LichChieu = new DTO_LichChieu
                (
                    txtMaLC.Text,
                    cbxPhim.SelectedValue.ToString(),
                    cbxLPC.SelectedValue.ToString(),
                    cbxDOBLC.Value,
                    float.Parse(txtGV.Text)

                );
                if (blllichchieu.updateLC(dto_LichChieu))
                {
                    dtgvLC.DataSource = blllichchieu.List_LichChieu();
                    LoadGridView();
                    MessBox("Sửa thông tin lịch chiếu thành công");
                }
                else
                {
                    MessBox("Sửa thông tin lịch chiếu thất bại");
                }
            }
        }

        private void cbxDOBLC_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnXoaLC_Click(object sender, EventArgs e)
        {
            string MaLC = txtMaLC.Text;
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MaLC != null)
                {
                    blllichchieu.deleteLC(MaLC);
                    dtgvLC.DataSource = blllichchieu.List_LichChieu();
                    LoadGridView();
                    MessBox("Xóa lịch chiếu thành công");
                }
                else
                {
                    MessBox("Xóa lịch chiếu thất bại", true);
                }
                txtMaLC.Clear();
                cbxPhim.SelectedIndex = -1;
                cbxDOBLC.Value = DateTime.Today;
                cbxLPC.SelectedIndex = -1;
                txtGV.Clear();
            }
        }

        private void btnSearchLC_Click(object sender, EventArgs e)
        {
            string lc = txtSearchLC.Text;
            if (lc == "")
            {
                formLichChieu_Load(sender, e);
            }
            else
            {
                DataTable table = blllichchieu.searchLC(lc);
                dtgvLC.DataSource = table;
            }
        }

        private void btnResetLC_Click(object sender, EventArgs e)
        {
            txtMaLC.Text = null;
            cbxPhim.SelectedIndex = -1;
            cbxDOBLC.Value = DateTime.Today;
            cbxLPC.SelectedIndex = -1;
            txtGV.Text = null;
        }
    }
}
