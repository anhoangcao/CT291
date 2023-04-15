using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_PhongChieu
    {
        string stringConnect = @"Server=DESKTOP-0MK0TTK;Database=tesst;integrated security=true";
        public DataTable ListPhongChieu()
        {
            SqlConnection conn = new SqlConnection(stringConnect);
            try
            {
                conn.Open();
                SqlCommand comd = new SqlCommand("SELECT * FROM dbo.PhongChieu", conn);
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

        // Insert Phong Chieu
        public bool insertPC(DTO_PhongChieu pc)
        {
            SqlConnection conn = new SqlConnection(stringConnect);
            try
            {
                conn.Open();
                string sql = "INSERT INTO dbo.PhongChieu (MaPhongChieu, TenPhongChieu, SoChoNgoi, TenMangHinh, TinhTrang) VALUES (@MaPhongChieu, @TenPhongChieu, @SoChoNgoi, @TenMangHinh, @TinhTrang)";
                SqlCommand comd = new SqlCommand(sql, conn);
                comd.Parameters.AddWithValue("@MaPhongChieu", pc.MaPC);
                comd.Parameters.AddWithValue("@TenPhongChieu", pc.TenPC);
                comd.Parameters.AddWithValue("@SoChoNgoi", pc.SoCho);
                comd.Parameters.AddWithValue("@TenMangHinh", pc.TenManHinh);
                comd.Parameters.AddWithValue("@TinhTrang", pc.TinhTrang);
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
        public bool updatePC(DTO_PhongChieu pc)
        {
            SqlConnection conn = new SqlConnection(stringConnect);
            try
            {
                conn.Open();
                string sql = "UPDATE dbo.PhongChieu SET MaPhongChieu = @MaPhongChieu, TenPhongChieu = @TenPhongChieu, SoChoNgoi = @SoChoNgoi, TenMangHinh = @TenMangHinh, TinhTrang = @TinhTrang WHERE MaPhongChieu = @MaPhongChieu";
                SqlCommand comd = new SqlCommand(sql, conn);
                comd.Parameters.AddWithValue("@MaPhongChieu", pc.MaPC);
                comd.Parameters.AddWithValue("@TenPhongChieu", pc.TenPC);
                comd.Parameters.AddWithValue("@SoChoNgoi", pc.SoCho);
                comd.Parameters.AddWithValue("@TenMangHinh", pc.TenManHinh);
                comd.Parameters.AddWithValue("@TinhTrang", pc.TinhTrang);
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
        public bool deletePC(String MaPC)
        {
            SqlConnection conn = new SqlConnection(stringConnect);
            try
            {
                conn.Open();
                string query = "Delete from PhongChieu where MaPhongChieu = '" + MaPC + "'";
                SqlCommand command = new SqlCommand(query, conn);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("MaPC", MaPC);
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
