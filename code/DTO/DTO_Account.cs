using System; // Thêm namespace System
using System.Collections.Generic; // Thêm namespace System.Collections.Generic
using System.Linq; // Thêm namespace System.Linq
using System.Text; // Thêm namespace System.Text
using System.Threading.Tasks; // Thêm namespace System.Threading.Tasks

namespace DTO
{
    public class DTO_Account
    {
        private String userName;
        private String passWord;
        private String loaiTK;
        private String maNV;

        public DTO_Account(String userName, String passWord, String loaiTK, String maNV)
        {
            this.userName = userName;
            this.passWord = passWord;
            this.loaiTK = loaiTK;
            this.maNV = maNV;
        }

        public string UserName { get => userName; set => userName = value; }
        public string Pass { get => passWord; set => passWord = value; }
        public string LoaiTK { get => loaiTK; set => loaiTK = value; }
        public string MaNhanVien { get => maNV; set => maNV = value; }
    }
}
