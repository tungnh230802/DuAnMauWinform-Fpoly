using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL_QLBANHANG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLBANHANG;

namespace DAL_QLBANHANG.Tests
{
    [TestClass()]
    public class DAL_NhanVienTests
    {
        [TestMethod()]
        public void NhanVienDangNhapTest001()
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            DAL_NhanVien login = new DAL_NhanVien();

            nv.Email = "";
            nv.MatKhau = "1234";
            bool result = login.NhanVienDangNhap(nv);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void NhanVienDangNhapTest002()
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            DAL_NhanVien login = new DAL_NhanVien();

            nv.Email = "tungnh230802@gmail.com";
            nv.MatKhau = "";
            bool result = login.NhanVienDangNhap(nv);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void NhanVienDangNhapTest003()
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            DAL_NhanVien login = new DAL_NhanVien();

            nv.Email = "tungnh230802@gmail.com";
            nv.MatKhau = "1292201552198220877194054219216496220885";
            bool result = login.NhanVienDangNhap(nv);
            Assert.IsTrue(result);
        }
    }
}