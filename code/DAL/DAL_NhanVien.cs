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

    }
    
}
