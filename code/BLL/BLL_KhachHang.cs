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
        // Trả ra CSDL
        DAL_KhachHang dalkhachhang = new DAL_KhachHang();
        public DataTable List_KhachHang()
        {
            return dalkhachhang.ListKhachHang();
        }

        // Insert Customer
        public bool insertCustomer(DTO_KhachHang client)
        {
            return dalkhachhang.insertCustomer(client);
        }

        // Update Customer
        public bool updateCustomer(DTO_KhachHang client)
        {
            return dalkhachhang.updateCustomer(client);
        }

        // Delete Customer
        public bool deleteCustomer(String MaKH)
        {
            return dalkhachhang.deleteCustomer(MaKH);
        }

        // Search Customer
        public DataTable searchCustomer(string kh)
        {
            return dalkhachhang.searchCustomer(kh);
        }
    }
}
