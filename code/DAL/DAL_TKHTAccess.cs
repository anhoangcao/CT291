using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_TKHTAccess:DAL_TKHT
    {
        public string Checklogin(DTO_TKHT tkht)
        {
            string info = CheckloginDTO(tkht);
            return info;
        }
    }
}
