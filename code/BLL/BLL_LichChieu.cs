using DAL;
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
    }
}
