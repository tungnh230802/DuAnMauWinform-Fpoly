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
    public class BUS_KhachHang
    {
        DAL_KhachHang dal_KhachHang = new DAL_KhachHang();
        public DataTable GetKhachHang()
        {
            return dal_KhachHang.GetKhachHang();
        }

        public bool InsertKhachHang(DTO_KhachHang kh)
        {
            return dal_KhachHang.InsertKhachHang(kh);
        }

        public bool UpdateKhachHang(DTO_KhachHang kh)
        {
            return dal_KhachHang.UpdateKhachHang(kh);
        }

        public bool DeleteKhachHang(string dienthoai)
        {
            return dal_KhachHang.DeleteKhachHang(dienthoai);
        }

        public DataTable SearchKhachHang(string dienthoai)
        {
            return dal_KhachHang.SearchKhachHang(dienthoai);
        }
    }
}
