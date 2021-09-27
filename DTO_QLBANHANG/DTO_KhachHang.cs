using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBANHANG
{
    public class DTO_KhachHang
    {
        private string dienThoai;
        private string tenKhach;
        private string diaChi;
        private string phai;
        private string email;

        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string TenKhach { get => tenKhach; set => tenKhach = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Phai { get => phai; set => phai = value; }
        public string Email { get => email; set => email = value; }

        public DTO_KhachHang(string dienThoai, string tenKhach, string diaChi, string phai)
        {
            this.dienThoai = dienThoai;
            this.tenKhach = tenKhach;
            this.diaChi = diaChi;
            this.phai = phai;
        }

        public DTO_KhachHang(string dienThoai, string tenKhach, string diaChi, string phai, string email)
        {
            this.dienThoai = dienThoai;
            this.tenKhach = tenKhach;
            this.diaChi = diaChi;
            this.phai = phai;
            this.email = email;
        }
    }
}
