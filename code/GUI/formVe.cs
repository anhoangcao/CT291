using BLL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class formVe : Form
    {
        

           
        public formVe()
        {
            InitializeComponent();

        }      

        private void buttonDatVe_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Xóa tất cả các button hiện tại trên flowLayoutPanel2
            flowLayoutPanel2.Controls.Clear();

            // Lấy danh sách các ghế từ CSDL
            List<string> seats = new List<string>();
            string connectionString = @"Server=DESKTOP-0MK0TTK;Database=tesst;integrated security=true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT MaGheNgoi FROM Ve WHERE MaLichChieu=@MaLichChieu", connection);
                command.Parameters.AddWithValue("@MaLichChieu", cbxShowtimeIdTextBox.Text);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string seatNumber = reader.GetString(0);
                    seats.Add(seatNumber);
                }
                connection.Close();
            }

            // Tạo các button đại diện cho các ghế
            foreach (string seatNumber in seats)
            {
                Button seat = new Button();
                seat.Text = seatNumber;
                seat.BackColor = Color.Empty;
                seat.ForeColor = Color.White;
                seat.Width = 40;
                seat.Height = 40;
                seat.Click += new EventHandler(Seat_Click);

                flowLayoutPanel2.Controls.Add(seat);
            }
        }

        

        private void formVe_Load(object sender, EventArgs e)
        {
            LoadComboBoxMaKH();
            LoadComboBoxMaLC();
        }

        


        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        string connectionString = @"Server=DESKTOP-0MK0TTK;Database=tesst;integrated security=true";
        private void Seat_Click(object sender, EventArgs e)
        {
            Button seat = sender as Button;

            // Kiểm tra xem ghế đã bán hay chưa
            if (seat.BackColor == Color.Red)
            {
                MessageBox.Show("Ghế này đã được bán. Vui lòng chọn ghế khác!");
                return;
            }

            // Kiểm tra xem ghế đã được đặt hay chưa
            string seatNumber = seat.Text;
            int count = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Ve WHERE MaLichChieu=@MaLichChieu AND MaGheNgoi=@MaGheNgoi", connection);
                    command.Parameters.AddWithValue("@MaLichChieu", cbxShowtimeIdTextBox.Text);
                    command.Parameters.AddWithValue("@MaGheNgoi", seatNumber);

                    connection.Open();
                    count = (int)command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            // Đánh dấu ghế được chọn
            seat.BackColor = Color.Blue;
        }

        private void gunaDV_Click(object sender, EventArgs e)
        {
            // Lấy thông tin về ghế được chọn
            List<string> seatNumbers = new List<string>();
            foreach (Control control in flowLayoutPanel2.Controls)
            {
                if (control.BackColor == Color.Blue)
                {
                    seatNumbers.Add(control.Text);
                }
            }

            // Kiểm tra xem người dùng đã chọn ghế hay chưa
            if (seatNumbers.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế để đặt vé!");
                return;
            }

            string customerId = cbxCustomerIdTextBox.Text;
            if (string.IsNullOrEmpty(customerId))
            {
                MessageBox.Show("Vui lòng chọn khách hàng!");
                return;
            }

            bool customerExists = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM KhachHang WHERE MaKhachHang=@MaKhachHang", connection))
                    {
                        command.Parameters.AddWithValue("@MaKhachHang", customerId);
                        int count = (int)command.ExecuteScalar();
                        if (count > 0)
                        {
                            customerExists = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (!customerExists)
            {
                MessageBox.Show("Khách hàng không tồn tại. Vui lòng kiểm tra lại!");
                return;
            }

            // Hỏi người dùng xác nhận đặt vé
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đặt " + seatNumbers.Count + " vé?", "Xác nhận đặt vé", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                
                // Thực hiện thêm thông tin đặt vé vào CSDL
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    foreach (string seatNumber in seatNumbers)
                    {
                        SqlCommand command = new SqlCommand("UPDATE Ve SET MaKhachHang=@MaKhachHang WHERE MaLichChieu=@MaLichChieu AND MaGheNgoi=@MaGheNgoi", connection);
                        command.Parameters.AddWithValue("@MaKhachHang", customerId);
                        command.Parameters.AddWithValue("@MaLichChieu", cbxShowtimeIdTextBox.Text);
                        command.Parameters.AddWithValue("@MaGheNgoi", seatNumber);
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }

                MessageBox.Show("Đặt vé thành công!");
                // Đặt màu đỏ cho các ghế đã đặt và không cho phép đặt lại
                foreach (Control control in flowLayoutPanel2.Controls)
                {
                    if (control.BackColor == Color.Blue)
                    {
                        control.BackColor = Color.Red;
                        control.Enabled = false;
                        
                    }
                    
                }

                //// Reset lại
                //CustomerIdTextBox.Text = "";
                //foreach (Control control in flowLayoutPanel2.Controls)
                //{
                //    control.BackColor = Color.Empty;
                //}
            }

            // Khai báo biến tính tổng tiền
            decimal totalPrice = 0;

            // Tìm Giá vé của Lịch chiếu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT Giave FROM LichChieu WHERE MaLichChieu=@MaLichChieu", connection);
                command.Parameters.AddWithValue("@MaLichChieu", cbxShowtimeIdTextBox.Text);
                decimal price = (decimal)command.ExecuteScalar();

                connection.Close();

                // Tính tổng tiền dựa trên giá vé của Lịch chiếu
                totalPrice = price * seatNumbers.Count;
            }

            // Hiển thị thông tin tổng tiền cho người dùng
            totalPriceTextBox.Text = totalPrice.ToString("#,##0") + " đ";

        }

        private void cbxCustomerIdTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadComboBoxMaKH()
        {
            DAL_KhachHang kh = new DAL_KhachHang();
            DataTable dt = kh.ListKhachHang();
            cbxCustomerIdTextBox.DisplayMember = "MaKhachHang"; 
            cbxCustomerIdTextBox.ValueMember = "TenKhachHang";
            cbxCustomerIdTextBox.DataSource = dt;
        }

        private void LoadComboBoxMaLC()
        {
            DAL_LichChieu kh = new DAL_LichChieu();
            DataTable dt = kh.ListLichChieu();
            cbxShowtimeIdTextBox.DisplayMember = "MaLichChieu";
            cbxShowtimeIdTextBox.ValueMember = "";
            cbxShowtimeIdTextBox.DataSource = dt;
        }

        private void cbxShowtimeIdTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            if (cbxShowtimeIdTextBox.SelectedItem != null)
            {
                // Lấy mã lịch chiếu từ ComboBox
                string ma = cbxShowtimeIdTextBox.Text;

                // Tạo câu truy vấn
                string query = "SELECT b.TenPhim, b.HinhAnh, a.GiaVe FROM LichChieu AS a INNER JOIN Phim AS b ON a.MaPhim = b.MaPhim WHERE MaLichChieu = @ma";

                // Tạo đối tượng SqlCommand và thêm tham số @ma
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ma", ma);

                // Mở kết nối
                connection.Open();

                // Thực thi câu truy vấn và đọc dữ liệu trả về
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    // Lấy thông tin phim đầu tiên trả về
                    reader.Read();
                    txtHienPhim.Text = reader["TenPhim"].ToString();
                    txtHienGiaVe.Text = reader["GiaVe"].ToString();
                    // Kiểm tra nếu có hình ảnh phim, hiển thị hình ảnh
                    if (!reader.IsDBNull(reader.GetOrdinal("HinhAnh")))
                    {
                        byte[] imageBytes = (byte[])reader["HinhAnh"];
                        MemoryStream memoryStream = new MemoryStream(imageBytes);
                        picHienAnh.Image = Image.FromStream(memoryStream);
                    }
                    else
                    {
                        picHienAnh.Image = null;
                    }
                    while (reader.Read())
                    {
                        // Lấy thông tin mã ghế ngồi
                        string maGheNgoi = reader["MaGheNgoi"].ToString();

                        // Tạo đối tượng Button để hiển thị mã ghế ngồi
                        Button btn = new Button();
                        btn.Text = maGheNgoi;

                        // Thêm sự kiện click cho Button
                        btn.Click += Btn_Click;

                        // Thêm Button vào flowLayoutPanel2
                        flowLayoutPanel2.Controls.Add(btn);
                    }

                }
                else
                {
                    // Nếu không có dữ liệu trả về, xóa nội dung của txtHienPhim và txtHienGiaVe
                    txtHienPhim.Text = "";
                    txtHienGiaVe.Text = "";
                    picHienAnh.Image = null;
                }

                // Đóng kết nối và đối tượng SqlDataReader
                reader.Close();
                connection.Close();

                // Reset giá trị của MaGheNgoi
                flowLayoutPanel2.ResetText();
            }
            else
            {
                // Nếu không có lựa chọn, xóa nội dung của txtHienPhim và txtHienGiaVe
                txtHienPhim.Text = "";
                txtHienGiaVe.Text = "";
            }

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            // Cast object to Button type
            Button btn = (Button)sender;

            // Do something with the button, like display the seat number or select it for purchase
            MessageBox.Show("Selected seat: " + btn.Text);
        }

        private void txtHienPhim_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtHienGiaVe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
