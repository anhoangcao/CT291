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
            dtgvLC.Columns[2].HeaderText = "Số chỗ ngồi";
            dtgvLC.Columns[3].HeaderText = "Tên màn hình";
            dtgvLC.Columns[4].HeaderText = "Tình trạng";
            foreach (DataGridViewColumn item in dtgvLC.Columns)
                item.DividerWidth = 1;

        }

        private void formLichChieu_Load(object sender, EventArgs e)
        {

        }
    }
}
