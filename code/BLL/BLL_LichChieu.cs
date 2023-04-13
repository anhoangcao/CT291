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
    public class BLL_LichChieu
    {
        DAL_LichChieu dallichchieu = new DAL_LichChieu();
        public DataTable List_LichChieu()
        {
            return dallichchieu.ListLichChieu();
        }

        public bool insertLC(DTO_LichChieu lc)
        {
            return dallichchieu.insertLC(lc);
        }

        public bool updateLC(DTO_LichChieu lc)
        {
            return dallichchieu.updateLC(lc);
        }

        public bool deleteLC(String MaLC)
        {
            return dallichchieu.deleteLC(MaLC);
        }

        public DataTable searchLC(string lc)
        {
            return dallichchieu.searchLC(lc);
        }
    }
}
