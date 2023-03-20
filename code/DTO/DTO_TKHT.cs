using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TKHT
    {
        private string tkht_Ma;
        private string tkht_Taikhoan;
        private string tkht_Matkhau;
        private string tkht_MaNV;
        public DTO_TKHT() {
        }
        public DTO_TKHT(string tkht_Ma, string tkht_Taikhoan, string tkht_Matkhau, string tkht_MaNV)
        {
            this.tkht_Ma = tkht_Ma;
            this.tkht_Taikhoan = tkht_Taikhoan;
            this.tkht_Matkhau = tkht_Matkhau;
            this.tkht_MaNV = tkht_MaNV;
        }

        public string Tkht_Ma { get => tkht_Ma; set => tkht_Ma = value; }
        public string Tkht_Taikhoan { get => tkht_Taikhoan; set => tkht_Taikhoan = value; }
        public string Tkht_Matkhau { get => tkht_Matkhau; set => tkht_Matkhau = value; }
        public string Tkht_MaNV { get => tkht_MaNV; set => tkht_MaNV = value; }
    }
}
