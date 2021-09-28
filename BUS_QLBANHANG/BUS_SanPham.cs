using DAL_QLBANHANG;
using DTO_QLBANHANG;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLBANHANG
{
    public class BUS_SanPham
    {
        DAL_SanPham dal_SanPham = new DAL_SanPham();
        public DataTable GetSanPham()
        {
            return dal_SanPham.GetSanPham();
        }

        public bool InsertSanPham(DTO_SanPham sp)
        {
            return dal_SanPham.InsertSanPham(sp);
        }

        public bool UpdateSanPham(DTO_SanPham sp)
        {
            return dal_SanPham.UpdateSanPham(sp);
        }

        public bool DeleteSanPham(int maHang)
        {
            return dal_SanPham.DeleteSanPham(maHang);
        }

        public DataTable SearchSanPham(string tenHang)
        {
            return dal_SanPham.SearchSanPham(tenHang);
        }

        public DataTable ThongKeHang()
        {
            return dal_SanPham.ThongKeHang();
        }

        public DataTable ThongKeHangTonKho()
        {
            return dal_SanPham.ThongKeHangTonKho();
        }
    }
}