using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_TKHT
    {
        DAL_TKHTAccess kthtAccess = new DAL_TKHTAccess();
        public string CheckLogin(DTO_TKHT tkht)
        {
            // Kiểm tra nghiệp vụ
            if (tkht.Tkht_Taikhoan == "")
            {
                return "requeid_taikhoan";
            }

            if (tkht.Tkht_Matkhau == "")
            {
                return "requeid_password";
            }
            string info = kthtAccess.Checklogin(tkht);
            return info;
        }
    }
}
