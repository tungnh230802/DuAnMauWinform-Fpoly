using DAL_QLBANHANG;
using DTO_QLBANHANG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLBANHANG
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dal_nhanvien = new DAL_NhanVien();

        public bool NhanVienDangNhap(DTO_NhanVien nv)
        {
            return dal_nhanvien.NhanVienDangNhap(nv);
        }

        public string encryption(string passwork)
        {
            string str_md5 = "";
            byte[] mang = System.Text.Encoding.UTF8.GetBytes(passwork);

            MD5CryptoServiceProvider my_md5 = new MD5CryptoServiceProvider();
            mang = my_md5.ComputeHash(mang);

            foreach (byte b in mang)
            {
                str_md5 += b.ToString("X2");
            }

            return str_md5;
        }

        public bool NhanVienQuenMk(string email)
        {
            return dal_nhanvien.NhanVienQuenMk(email);
        }

        public bool TaoMoiMatKhau(string email, string matKhauMoi)
        {
            return dal_nhanvien.TaoMauKhauMoi(email, matKhauMoi);
        }
    }
}
