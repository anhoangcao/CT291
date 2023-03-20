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
    public class BLL_KhachHang
    {
        DAL_KhachHang dalkhachhang = new DAL_KhachHang();
        public DataTable List_KhachHang()
        {
            return dalkhachhang.ListKhachHang();
        }
    }
}
