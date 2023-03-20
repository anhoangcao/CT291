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

        // Thêm nhân viên
        public bool insertStaff(DTO_NhanVien staff)
        {
            SqlConnection conn = new SqlConnection(stringConnect);
            try
            {
                conn.Open();
                SqlCommand comd = new SqlCommand("InsertofStaff", conn);
                comd.CommandType = CommandType.StoredProcedure;
                comd.Parameters.AddWithValue("manv", staff.MaNV);
                comd.Parameters.AddWithValue("tennv", staff.HoTen);
                comd.Parameters.AddWithValue("ngaysinh", staff.NgaySinh);
                comd.Parameters.AddWithValue("gioitinh", staff.GioiTinh);               
                comd.Parameters.AddWithValue("diachi", staff.DiaChi);               
                comd.Parameters.AddWithValue("dienthoai", staff.DienThoai);
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

    }
    
}
