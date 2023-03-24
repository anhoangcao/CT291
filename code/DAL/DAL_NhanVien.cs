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
    public class DAL_NhanVien
    {
        string stringConnect = @"Server=DESKTOP-0MK0TTK;Database=FilmDatabase;integrated security=true";

        public DataTable ListNhanVien()
        {
            SqlConnection conn = new SqlConnection(stringConnect);
            try
            {
                conn.Open();
                SqlCommand comd = new SqlCommand("SELECT * FROM dbo.NhanVien", conn);
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

        // Insert Staff
        public bool insertStaff(DTO_NhanVien staff)
        {
            SqlConnection conn = new SqlConnection(stringConnect);
            try
            {
                conn.Open();
                string sql = "INSERT INTO dbo.NhanVien (MaNhanVien, TenNhanVien, NgaySinh, GioiTinh, DiaChi, DienThoai) VALUES (@MaNhanVien, @TenNhanVien, @NgaySinh, @GioiTinh, @DiaChi, @DienThoai)";
                SqlCommand comd = new SqlCommand(sql, conn);
                comd.Parameters.AddWithValue("@MaNhanVien", staff.MaNV);
                comd.Parameters.AddWithValue("@TenNhanVien", staff.HoTen);
                comd.Parameters.AddWithValue("@NgaySinh", staff.NgaySinh);
                comd.Parameters.AddWithValue("@GioiTinh", staff.GioiTinh);               
                comd.Parameters.AddWithValue("@DiaChi", staff.DiaChi);               
                comd.Parameters.AddWithValue("@DienThoai", staff.DienThoai);
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
        public bool updateStaff(DTO_NhanVien staff)
        {
            SqlConnection conn = new SqlConnection(stringConnect);
            try
            {
                conn.Open();
                string sql = "UPDATE dbo.NhanVien SET MaNhanVien = @MaNhanVien, TenNhanVien = @TenNhanVien, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, DiaChi = @DiaChi, DienThoai = @DienThoai WHERE MaNhanVien = @MaNhanVien";
                SqlCommand comd = new SqlCommand(sql, conn);
                comd.Parameters.AddWithValue("@MaNhanVien", staff.MaNV);
                comd.Parameters.AddWithValue("@TenNhanVien", staff.HoTen);
                comd.Parameters.AddWithValue("@NgaySinh", staff.NgaySinh);
                comd.Parameters.AddWithValue("@GioiTinh", staff.GioiTinh);
                comd.Parameters.AddWithValue("@DiaChi", staff.DiaChi);
                comd.Parameters.AddWithValue("@DienThoai", staff.DienThoai);
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
        public bool deleteStaff(String MaNV)
        {
            SqlConnection conn = new SqlConnection(stringConnect);
            try
            {
                conn.Open();
                string query = "Delete from NhanVien where MaNhanVien = '" + MaNV + "'";
                SqlCommand command = new SqlCommand(query, conn);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("MaNV", MaNV);
                if (command.ExecuteNonQuery() > 0)
                    return true;
                else 
                    return false;
            }
            catch(Exception)
            {

            }
            finally 
            { 
                conn.Close(); 
            }
            return false;
        }

        // Search Staff
        public DataTable searchStaff(String nv)
        {
            SqlConnection conn = new SqlConnection(stringConnect);
            try
            {
                conn.Open();
                string query = "SELECT * FROM NhanVien WHERE TenNhanVien LIKE '%" + nv + "%' ";
                SqlCommand comd = new SqlCommand(query, conn);
                comd.CommandType = CommandType.Text;
                comd.Parameters.AddWithValue("HoTen", nv);
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
