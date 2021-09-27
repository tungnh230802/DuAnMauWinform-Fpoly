using DAL_QLBANHANG;
using DTO_QLBANHANG;
using System;
using System.Collections.Generic;
using System.Data;
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
            byte[] encrypt;
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            UTF8Encoding encode = new UTF8Encoding();
            encrypt = md5.ComputeHash(encode.GetBytes(passwork));
            StringBuilder encryptdata = new StringBuilder();
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
        }

        public bool NhanVienQuenMk(string email)
        {
            return dal_nhanvien.NhanVienQuenMk(email);
        }

        public bool TaoMoiMatKhau(string email, string matKhauMoi)
        {
            return dal_nhanvien.TaoMauKhauMoi(email, matKhauMoi);
        }

        public bool VaiTroNhanVien(string email)
        {
            return dal_nhanvien.VaiTroNhanVien(email);
        }

        public bool DoiMatKhau(string email, string oddPass, string newPass)
        {
            return dal_nhanvien.DoiMatKhau(email, oddPass, newPass);
        }

        public DataTable getNhanVien()
        {
            return dal_nhanvien.getNhanVien();
        }

        public bool InsertNhanVien(DTO_NhanVien nv)
        {
            return dal_nhanvien.InsertNhanVien(nv);
        }

        public bool UpdateNhanVien(DTO_NhanVien nv)
        {
            return dal_nhanvien.UpdateNhanVien(nv);
        }

        public bool DeleteNhanVien(string email)
        {
            return dal_nhanvien.DeleteNhanVien(email);
        }

        public DataTable SearchNhanVien(string tenNv)
        {
            return dal_nhanvien.SearchNhanVien(tenNv);
        }
    }
}