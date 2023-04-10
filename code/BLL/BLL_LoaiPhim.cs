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
    public class BLL_LoaiPhim
    {
        DAL_LoaiPhim dalloaiphim = new DAL_LoaiPhim();
        public DataTable List_LoaiPhim()
        {
            return dalloaiphim.ListLoaiPhim();
        }

        public bool insertLP(DTO_LoaiPhim lp)
        {
            return dalloaiphim.insertLP(lp);
        }

        public bool updateLP(DTO_LoaiPhim lp)
        {
            return dalloaiphim.updateLP(lp);
        }

        public bool deleteLP(String MaLP)
        {
            return dalloaiphim.deleteLP(MaLP);
        }
    }
}
