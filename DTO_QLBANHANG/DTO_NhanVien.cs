using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBANHANG
{
    public class DTO_NhanVien
    {
        private string tenNv;
        private string email;
        private string diaChi;
        private string vaiTro;
        private string matKhau;
        private string tinhTrang;

        public string TenNv { get => tenNv; set => tenNv = value; }
        public string Email { get => email; set => email = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string VaiTro { get => vaiTro; set => vaiTro = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }

        public DTO_NhanVien()
        {
        }

        public DTO_NhanVien(string tenNv, string email, string diaChi, string vaiTro, string matKhau, string tinhTrang)
        {
            this.tenNv = tenNv;
            this.email = email;
            this.diaChi = diaChi;
            this.vaiTro = vaiTro;
            this.matKhau = matKhau;
            this.tinhTrang = tinhTrang;
        }

        public DTO_NhanVien(string tenNv, string email, string diaChi, string vaiTro, string tinhTrang)
        {
            this.tenNv = tenNv;
            this.email = email;
            this.diaChi = diaChi;
            this.vaiTro = vaiTro;
            this.tinhTrang = tinhTrang;
        }
    }
}
