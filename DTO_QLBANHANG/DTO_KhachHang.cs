using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBANHANG
{
    class DTO_KhachHang
    {
        private string dienThoai;
        private string tenKhach;
        private string diaChi;
        private string phai;
        private string maNV;

        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string TenKhach { get => tenKhach; set => tenKhach = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Phai { get => phai; set => phai = value; }
        public string MaNV { get => maNV; set => maNV = value; }

        public DTO_KhachHang(string dienThoai, string tenKhach, string diaChi, string phai, string maNV)
        {
            this.dienThoai = dienThoai;
            this.tenKhach = tenKhach;
            this.diaChi = diaChi;
            this.phai = phai;
            this.maNV = maNV;
        }
    }
}
