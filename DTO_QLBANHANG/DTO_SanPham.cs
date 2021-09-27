using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBANHANG
{
    public class DTO_SanPham
    {
        private int maHang;
        private string tenHang;
        private int soLuong;
        private float donGiaBan;
        private float donGiaNhap;
        private string hinhAnh;
        private string ghiChu;
        private string email;

        public string TenHang { get => tenHang; set => tenHang = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public float DonGiaBan { get => donGiaBan; set => donGiaBan = value; }
        public float DonGiaNhap { get => donGiaNhap; set => donGiaNhap = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string Email { get => email; set => email = value; }
        public int MaHang { get => maHang; set => maHang = value; }

        public DTO_SanPham(string tenHang, int soLuong, float donGiaBan, float donGiaNhap, string hinhAnh, string ghiChu, string email)
        {
            this.tenHang = tenHang;
            this.soLuong = soLuong;
            this.donGiaBan = donGiaBan;
            this.donGiaNhap = donGiaNhap;
            this.hinhAnh = hinhAnh;
            this.ghiChu = ghiChu;
            this.email = email;
        }

        public DTO_SanPham(int maHang,string tenHang, int soLuong, float donGiaBan, float donGiaNhap, string hinhAnh, string ghiChu)
        {
            this.maHang = maHang;
            this.tenHang = tenHang;
            this.soLuong = soLuong;
            this.donGiaBan = donGiaBan;
            this.donGiaNhap = donGiaNhap;
            this.hinhAnh = hinhAnh;
            this.ghiChu = ghiChu;
        }
    }
}
