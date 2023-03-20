using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_NhanVien
    {
        DAL_NhanVien dalnhanvien = new DAL_NhanVien();
        public DataTable List_NhanVien()
        {
            return dalnhanvien.ListNhanVien();
        }

        public bool insertStaff(DTO_NhanVien staff)
        {
            return dalnhanvien.insertStaff(staff);
        }
    }
}
