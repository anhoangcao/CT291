using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace GUI
{
    public partial class fromDatVe : Form
    {
        public fromDatVe()
        {
            InitializeComponent();
        }

        private void panelMainNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            formPhim formPhim = new formPhim();
            panelMain.Controls.Clear();
            formPhim.TopLevel = false;
            formPhim.Dock = DockStyle.Fill;
            panelMain.Controls.Add(formPhim);
            formPhim.Show();
        }

        private void btnLC_Click(object sender, EventArgs e)
        {
            formLichChieu formLichChieu = new formLichChieu();
            panelMain.Controls.Clear();
            formLichChieu.TopLevel = false;
            formLichChieu.Dock = DockStyle.Fill;
            panelMain.Controls.Add(formLichChieu);
            formLichChieu.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            formLichChieu formLichChieu = new formLichChieu();
            panelMain.Controls.Clear();
            formLichChieu.TopLevel = false;
            formLichChieu.Dock = DockStyle.Fill;
            panelMain.Controls.Add(formLichChieu);
            formLichChieu.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            formPhongChieu formPhongChieu = new formPhongChieu();
            panelMain.Controls.Clear();
            formPhongChieu.TopLevel = false;
            formPhongChieu.Dock = DockStyle.Fill;
            panelMain.Controls.Add(formPhongChieu);
            formPhongChieu.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            formLoaiPhim formLoaiPhim = new formLoaiPhim();
            panelMain.Controls.Clear();
            formLoaiPhim.TopLevel = false;
            formLoaiPhim.Dock = DockStyle.Fill;
            panelMain.Controls.Add(formLoaiPhim);
            formLoaiPhim.Show();
        }
    }
}
