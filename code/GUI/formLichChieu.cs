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

        // DataGridView
        private void LoadGridView()
        {
            dtgvLC.Columns[0].HeaderText = "Mã lịch chiếu";
            dtgvLC.Columns[1].HeaderText = "Tên phim";
            dtgvLC.Columns[2].HeaderText = "Phòng chiếu";
            dtgvLC.Columns[3].HeaderText = "Ngày chiếu";
            dtgvLC.Columns[4].HeaderText = "Giá vé";
            foreach (DataGridViewColumn item in dtgvLC.Columns)
                item.DividerWidth = 1;

        }

        private void formLichChieu_Load(object sender, EventArgs e)
        {
            dtgvLC.DataSource = blllichchieu.List_LichChieu();
            LoadGridView();
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
            }
        }
    }
}
