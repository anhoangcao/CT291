using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHang
    {
        private String maKH;
        private String hoTen;
        private String diaChi;
        private String dienThoai;

        public DTO_KhachHang(String maKH, String hoTen, String diaChi, String dienThoai)
        {
            this.maKH = maKH;
            this.hoTen = hoTen;            
            this.diaChi = diaChi;
            this.dienThoai = dienThoai;
        }

        public string MaKH { get => maKH; set => maKH = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
    }
}
