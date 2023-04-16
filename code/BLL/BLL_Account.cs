using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Account
    {
        DAL_Account dalaccount = new DAL_Account();
        public DataTable List_Account()
        {
            return dalaccount.ListAccount();
        }

        public bool insertAccount(DTO_Account acc)
        {
            return dalaccount.insertAccount(acc);
        }

        public bool updateAccount(DTO_Account acc)
        {
            return dalaccount.updateAccount(acc);
        }

        public bool deleteAccount(String MaNV)
        {
            return dalaccount.deleteAccount(MaNV);
        }
    }
}
