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
        private int vaiTro;
        private string matKhau;
        private int tinhTrang;

        public string TenNv { get => tenNv; set => tenNv = value; }
        public string Email { get => email; set => email = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public int VaiTro { get => vaiTro; set => vaiTro = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public int TinhTrang { get => tinhTrang; set => tinhTrang = value; }

        public DTO_NhanVien()
        {
        }

        public DTO_NhanVien(string tenNv, string email, string diaChi, int vaiTro, string matKhau, int tinhTrang)
        {
            this.tenNv = tenNv;
            this.email = email;
            this.diaChi = diaChi;
            this.vaiTro = vaiTro;
            this.matKhau = matKhau;
            this.tinhTrang = tinhTrang;
        }

        public DTO_NhanVien(string tenNv, string email, string diaChi, int vaiTro, int tinhTrang)
        {
            this.tenNv = tenNv;
            this.email = email;
            this.diaChi = diaChi;
            this.vaiTro = vaiTro;
            this.tinhTrang = tinhTrang;
        }
    }
}
