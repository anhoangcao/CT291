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
    public class BLL_PhongChieu
    {
        DAL_PhongChieu dalphongchieu = new DAL_PhongChieu();
        public DataTable List_PhongChieu()
        {
            return dalphongchieu.ListPhongChieu();
        }

        public bool insertPC(DTO_PhongChieu pc)
        {
            return dalphongchieu.insertPC(pc);
        }

        public bool updatePC(DTO_PhongChieu pc)
        {
            return dalphongchieu.updatePC(pc);
        }

        public bool deletePC(String MaPC)
        {
            return dalphongchieu.deletePC(MaPC);
        }
    }
}
