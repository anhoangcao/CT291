using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_LichChieu
    {
        string stringConnect = @"Server=DESKTOP-0MK0TTK;Database=tesst;integrated security=true";
        public DataTable ListLichChieu()
        {
            SqlConnection conn = new SqlConnection(stringConnect);
            try
            {
                conn.Open();
                SqlCommand comd = new SqlCommand("SELECT a.MaLichChieu, b.TenPhongChieu, c.TenPhim, a.NgayChieu, a.GiaVe FROM dbo.LichChieu as a, dbo.PhongChieu as b, dbo.Phim as c where a.MaPhongChieu = b.MaPhongChieu and a.MaPhim = c.MaPhim", conn);
                comd.CommandType = CommandType.Text;
                DataTable data = new DataTable();
                data.Load(comd.ExecuteReader());
                return data;
            }
            finally
            {
                conn.Close();
            }
        }

        // Insert Lich Chieu
        public bool insertLC(DTO_LichChieu lc)
        {
            SqlConnection conn = new SqlConnection(stringConnect);
            try
            {
                conn.Open();
                string sql = "INSERT INTO dbo.LichChieu (MaLichChieu, MaPhim, MaPhongChieu, NgayChieu, GiaVe) VALUES (@MaLichChieu, @TenPhim, @MaPhong, @NgayChieu, @GiaVe)";
                SqlCommand comd = new SqlCommand(sql, conn);
                comd.Parameters.AddWithValue("@MaLichChieu", lc.MaLC);
                comd.Parameters.AddWithValue("@TenPhim", lc.TenPhim);
                comd.Parameters.AddWithValue("@MaPhong", lc.MaPC);
                comd.Parameters.AddWithValue("@NgayChieu", lc.NgayChieu);
                comd.Parameters.AddWithValue("@GiaVe", lc.GiaVe);
                // comd.Parameters.AddWithValue("@TrangThai", lc.TrangThai);

                if (comd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }

            return false;
        }

        // Update Lich Chieu
        public bool updateLC(DTO_LichChieu lc)
        {
            SqlConnection conn = new SqlConnection(stringConnect);
            try
            {
                conn.Open();
                string sql = "UPDATE dbo.LichChieu SET MaLichChieu = @MaLichChieu, MaPhim = @TenPhim, MaPhongChieu = @MaPhongChieu, NgayChieu = @NgayChieu, GiaVe = @GiaVe WHERE MaLichChieu = @MaLichChieu";
                SqlCommand comd = new SqlCommand(sql, conn);
                comd.Parameters.AddWithValue("@MaLichChieu", lc.MaLC);
                comd.Parameters.AddWithValue("@TenPhim", lc.TenPhim);
                comd.Parameters.AddWithValue("@MaPhongChieu", lc.MaPC);
                comd.Parameters.AddWithValue("@NgayChieu", lc.NgayChieu);
                comd.Parameters.AddWithValue("@GiaVe", lc.GiaVe);
                if (comd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }

            return false;
        }

        // Delete Lich Chieu
        public bool deleteLC(String MaLC)
        {
            SqlConnection conn = new SqlConnection(stringConnect);
            try
            {
                conn.Open();
                string query = "Delete from LichChieu where MaLichChieu = '" + MaLC + "'";
                SqlCommand command = new SqlCommand(query, conn);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("MaLP", MaLC);
                if (command.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        // Search LichChieu
        public DataTable searchLC(string lc)
        {
            SqlConnection conn = new SqlConnection(stringConnect);
            try
            {
                conn.Open();
                string query = "SELECT a.MaLichChieu, b.TenPhongChieu, c.TenPhim, a.NgayChieu, a.GiaVe " +
                               "FROM dbo.LichChieu as a " +
                               "JOIN dbo.PhongChieu as b ON a.MaPhongChieu = b.MaPhongChieu " +
                               "JOIN dbo.Phim as c ON a.MaPhim = c.MaPhim " +
                               "WHERE c.TenPhim LIKE '%' + @lc + '%' OR CONVERT(NVARCHAR(10), a.NgayChieu, 103) LIKE '%' + @lc + '%' OR b.TenPhongChieu LIKE '%' + @lc + '%'";
                SqlCommand comd = new SqlCommand(query, conn);
                comd.CommandType = CommandType.Text;
                comd.Parameters.AddWithValue("@lc", lc);
                DataTable data = new DataTable();
                data.Load(comd.ExecuteReader());
                return data;
            }
                finally
            {
                conn.Close();
            }

        }

    }
}
