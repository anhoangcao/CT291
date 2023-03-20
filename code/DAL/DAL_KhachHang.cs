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
        string stringConnect = @"Server=DESKTOP-0MK0TTK;Database=FilmDatabase;integrated security=true";

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
    }
}
