using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhongChieu
    {
        private String maPC;
        private String tenPC;
        private String soChoNgoi;
        private String tenManHinh;
        private String tinhTrang;

        public DTO_PhongChieu(String maPC, String tenPC, String soChoNgoi, String tenManHinh, String tinhTrang)
        {
            this.maPC = maPC;
            this.tenPC = tenPC;
            this.soChoNgoi = soChoNgoi;
            this.tenManHinh = tenManHinh;
            this.tinhTrang = tinhTrang;
        }
        public string MaPC { get => maPC; set => maPC = value; }
        public string TenPC { get => tenPC; set => tenPC = value; }
        public string SoCho { get => soChoNgoi; set => soChoNgoi = value; }
        public string TenManHinh { get => tenManHinh; set => tenManHinh = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
    }
   
}
