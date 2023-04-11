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
    public class BLL_Phim
    {
        DAL_Phim dalphim = new DAL_Phim();
        public DataTable List_Phim()
        {
            return dalphim.ListPhim();
        }

        public bool insertPhim(DTO_Phim p)
        {
            return dalphim.insertPhim(p);
        }

        public bool updatePhim(DTO_Phim p)
        {
            return dalphim.updatePhim(p);
        }

        public bool deletePhim(String MaPhim)
        {
            return dalphim.deletePhim(MaPhim);
        }
    }
}
