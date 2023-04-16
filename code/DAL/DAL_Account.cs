using DTO;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Account
    {
        string stringConnect = @"Server=DESKTOP-0MK0TTK;Database=tesst;integrated security=true";

        public DataTable ListAccount()
        {
            SqlConnection conn = new SqlConnection(stringConnect);
            try
            {
                conn.Open();
                SqlCommand comd = new SqlCommand("SELECT * FROM dbo.TaiKhoan", conn);
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

        // Insert Account
        public bool insertAccount(DTO_Account acc)
        {
            SqlConnection conn = new SqlConnection(stringConnect);
            try
            {
                conn.Open();
                string sql = "INSERT INTO dbo.TaiKhoan (UserName, Pass, LoaiTK, MaNhanVien) VALUES (@UserName, @Pass, @LoaiTK, @MaNhanVien)";
                SqlCommand comd = new SqlCommand(sql, conn);
                comd.Parameters.AddWithValue("@UserName", acc.UserName);
                comd.Parameters.AddWithValue("@Pass", acc.Pass);
                comd.Parameters.AddWithValue("@LoaiTK", acc.LoaiTK);
                comd.Parameters.AddWithValue("@MaNhanVien", acc.MaNhanVien);
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

        // Update Account
        public bool updateAccount(DTO_Account acc)
        {
            SqlConnection conn = new SqlConnection(stringConnect);
            try
            {
                conn.Open();
                string sql = "UPDATE dbo.TaiKhoan SET UserName = @UserName, Pass = @Pass, LoaiTK = @LoaiTK, MaNhanVien = @MaNhanVien WHERE MaNhanVien = @MaNhanVien";
                SqlCommand comd = new SqlCommand(sql, conn);
                comd.Parameters.AddWithValue("@UserName", acc.UserName);
                comd.Parameters.AddWithValue("@Pass", acc.Pass);
                comd.Parameters.AddWithValue("@LoaiTK", acc.LoaiTK);
                comd.Parameters.AddWithValue("@MaNhanVien", acc.MaNhanVien);
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
        public bool deleteAccount(String MaNV)
        {
            SqlConnection conn = new SqlConnection(stringConnect);
            try
            {
                conn.Open();
                string query = "Delete from TaiKhoan where MaNhanVien = '" + MaNV + "'";
                SqlCommand command = new SqlCommand(query, conn);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("MaNV", MaNV);
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
