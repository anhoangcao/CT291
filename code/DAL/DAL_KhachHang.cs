using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhachHang
    {
        string stringConnect = @"Server=DESKTOP-0MK0TTK;Database=tesst;integrated security=true";

        public DataTable ListKhachHang()
        {
            SqlConnection conn = new SqlConnection(stringConnect);
            try
            {
                conn.Open();
                SqlCommand comd = new SqlCommand("SELECT * FROM dbo.KhachHang", conn);
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


        // Insert Customer
        public bool insertCustomer(DTO_KhachHang client)
        {
            SqlConnection conn = new SqlConnection(stringConnect);
            try
            {
                conn.Open();
                string sql = "INSERT INTO dbo.KhachHang (MaKhachHang, TenKhachHang, DiaChi, DienThoai) VALUES (@MaKhachHang, @TenKhachHang, @DiaChi, @DienThoai)";
                SqlCommand comd = new SqlCommand(sql, conn);
                comd.Parameters.AddWithValue("@MaKhachHang", client.MaKH);
                comd.Parameters.AddWithValue("@TenKhachHang", client.HoTen);
                comd.Parameters.AddWithValue("@DiaChi", client.DiaChi);
                comd.Parameters.AddWithValue("@DienThoai", client.DienThoai);
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

        // Update Customer
        public bool updateCustomer(DTO_KhachHang client)
        {
            SqlConnection conn = new SqlConnection(stringConnect);
            try
            {
                conn.Open();
                string sql = "UPDATE dbo.KhachHang SET MaKhachHang = @MaKhachHang, TenKhachHang = @TenKhachHang, DiaChi = @DiaChi, DienThoai = @DienThoai WHERE MaKhachHang = @MaKhachHang";
                SqlCommand comd = new SqlCommand(sql, conn);
                comd.Parameters.AddWithValue("@MaKhachHang", client.MaKH);
                comd.Parameters.AddWithValue("@TenKhachHang", client.HoTen);
                comd.Parameters.AddWithValue("@DiaChi", client.DiaChi);
                comd.Parameters.AddWithValue("@DienThoai", client.DienThoai);
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

        // Delete Customer
        public bool deleteCustomer(String MaKH)
        {
            SqlConnection conn = new SqlConnection(stringConnect);
            try
            {
                conn.Open();
                string query = "Delete from KhachHang where MaKhachHang = '" + MaKH + "'";
                SqlCommand command = new SqlCommand(query, conn);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("MaKH", MaKH);
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

        // Search Customer
        public DataTable searchCustomer(String kh)
        {
            SqlConnection conn = new SqlConnection(stringConnect);
            try
            {
                conn.Open();
                string query = "SELECT * FROM KhachHang WHERE TenKhachHang LIKE '%" + kh + "%' or DiaChi LIKE '%" + kh + "%' or DienThoai LIKE '%" + kh + "%' ";
                SqlCommand comd = new SqlCommand(query, conn);
                comd.CommandType = CommandType.Text;
                comd.Parameters.AddWithValue("TenKH", kh);
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
