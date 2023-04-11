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
        string stringConnect = @"Server=DESKTOP-0MK0TTK;Database=FilmDatabase1;integrated security=true";
        public DataTable ListLichChieu()
        {
            SqlConnection conn = new SqlConnection(stringConnect);
            try
            {
                conn.Open();
                SqlCommand comd = new SqlCommand("SELECT * FROM dbo.LichChieu", conn);
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
                string sql = "INSERT INTO dbo.LichChieu (MaLichChieu, MaPhim, MaPhong, NgayChieu, GiaVe) VALUES (@MaLichChieu, @MaPhim, @MaPhong, @NgayChieu, @GiaVe)";
                SqlCommand comd = new SqlCommand(sql, conn);
                comd.Parameters.AddWithValue("@MaLichChieu", lc.MaLC);
                comd.Parameters.AddWithValue("@MaPhim", lc.TenPhim);
                comd.Parameters.AddWithValue("@MaPhong", lc.MaPC);
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

        // Update Staff
        public bool updateLP(DTO_LoaiPhim lp)
        {
            SqlConnection conn = new SqlConnection(stringConnect);
            try
            {
                conn.Open();
                string sql = "UPDATE dbo.LoaiPhim SET MaLoaiPhim = @MaLoaiPhim, TenLoaiPhim = @TenLoaiPhim, MoTa = @MoTa WHERE MaLoaiPhim = @MaLoaiPhim";
                SqlCommand comd = new SqlCommand(sql, conn);
                comd.Parameters.AddWithValue("@MaLoaiPhim", lp.MaLP);
                comd.Parameters.AddWithValue("@TenLoaiPhim", lp.TenLP);
                comd.Parameters.AddWithValue("@MoTa", lp.MoTa);
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

        // Delete Staff
        public bool deleteLP(String MaLP)
        {
            SqlConnection conn = new SqlConnection(stringConnect);
            try
            {
                conn.Open();
                string query = "Delete from LoaiPhim where MaLoaiPhim = '" + MaLP + "'";
                SqlCommand command = new SqlCommand(query, conn);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("MaLP", MaLP);
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
    }
}
