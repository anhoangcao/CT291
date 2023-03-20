using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class SqlConnectionData
    {
        public static SqlConnection Connect()
        {
            string stringConnect = @"Server=DESKTOP-0MK0TTK;Database=FilmDatabase;integrated security=true";
            SqlConnection conn = new SqlConnection(stringConnect);
            return conn;
        }
    }

    public class DAL_TKHT
    {
        public static string CheckloginDTO(DTO_TKHT tkht)
        {
            string user = null;
            // Hàm kết nối tới CSDL
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("proc_login",conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@user", tkht.Tkht_Taikhoan);
            command.Parameters.AddWithValue("@pass", tkht.Tkht_Matkhau);
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    user = reader.GetString(0);
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "Tài khoản hoặc mật khẩu không đúng!";
            }
            return user;
        }
    }

    
}
