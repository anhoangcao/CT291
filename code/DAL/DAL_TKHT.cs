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
            string stringConnect = @"Server=DESKTOP-0MK0TTK;Database=tesst;integrated security=true";
            SqlConnection conn = new SqlConnection(stringConnect);
            return conn;
        }
    }

    public class DAL_TKHT
    {
        
    }

    
}
