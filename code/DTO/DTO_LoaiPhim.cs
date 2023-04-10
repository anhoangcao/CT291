using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LoaiPhim
    {
        private String maLP;
        private String tenLP;
        private String moTa;

        public DTO_LoaiPhim(String maLP, String tenLP, String moTa)
        {
            this.maLP = maLP;
            this.tenLP = tenLP;
            this.moTa = moTa;
        }

        public string MaLP { get => maLP; set => maLP = value; }
        public string TenLP { get => tenLP; set => tenLP = value; }
        public string MoTa { get => moTa; set => moTa = value; }
    }
}
