using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LichChieu
    {
        private String maLC;
        private String tenPhim;
        private String maPC;
        private DateTime ngayChieu;
        private float giaVe;

        public DTO_LichChieu(String maLC, String tenPhim, String maPC, DateTime ngayChieu, float giaVe)
        {
            this.maLC = maLC;
            this.tenPhim = tenPhim;
            this.maPC = maPC;
            this.ngayChieu = ngayChieu;
            this.giaVe = giaVe;
        }
        public string MaLC { get => maLC; set => maLC = value; }
        public string TenPhim { get => tenPhim; set => tenPhim = value; }
        public string MaPC { get => maPC; set => maPC = value; }
        public DateTime NgayChieu { get => ngayChieu; set => ngayChieu = value; }
        public float GiaVe { get => giaVe; set => giaVe = value; }
    }
}
