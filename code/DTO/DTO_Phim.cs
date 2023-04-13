using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Phim
    {
        private String maPhim;
        private String tenPhim;
        private String moTa;
        private String maLP;
        private int thoiLuong;
        private String sanXuat;
        private String daoDien;
        private byte[] hinhAnh;

        public DTO_Phim(String maPhim, String tenPhim, String moTa, String maLP, int thoiLuong, String sanXuat, String daoDien, byte[] hinhAnh)
        {
            this.maPhim = maPhim;
            this.tenPhim = tenPhim;
            this.moTa = moTa;
            this.maLP = maLP;
            this.thoiLuong = thoiLuong;
            this.sanXuat = sanXuat;
            this.daoDien = daoDien;
            this.hinhAnh = hinhAnh;

        }
        public string MaPhim { get => maPhim; set => maPhim = value; }
        public string TenPhim { get => tenPhim; set => tenPhim = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public string MaLP { get => maLP; set => maLP = value; }
        public int ThoiLuong { get => thoiLuong; set => thoiLuong = value; }
        public string SanXuat { get => sanXuat; set => sanXuat = value; }
        public string DaoDien { get => daoDien; set => daoDien = value; }
        public byte[] PosTer { get => hinhAnh; set => hinhAnh = value; }
    }
}
