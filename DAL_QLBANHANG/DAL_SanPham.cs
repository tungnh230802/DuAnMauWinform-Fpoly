using DTO_QLBANHANG;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLBANHANG
{
    public class DAL_SanPham : DbContext
    {
         public DataTable GetSanPham()
         {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[DachSachHang]";
                cmd.Connection = _conn;
                DataTable dtSP = new DataTable();
                dtSP.Load(cmd.ExecuteReader());
                return dtSP;
            }
            catch { }
            finally
            {
                _conn.Close();
            }
            return null;
        }

        public bool InsertSanPham(DTO_SanPham sp)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[InsertDataIntoHang]";
                cmd.Parameters.AddWithValue("tenHang", sp.TenHang);
                cmd.Parameters.AddWithValue("soLuong", sp.SoLuong);
                cmd.Parameters.AddWithValue("donGiaBan", sp.DonGiaBan);
                cmd.Parameters.AddWithValue("donGiaNhap", sp.DonGiaNhap);
                cmd.Parameters.AddWithValue("hinhAnh", sp.HinhAnh);
                cmd.Parameters.AddWithValue("GhiChu", sp.GhiChu);
                cmd.Parameters.AddWithValue("Email", sp.Email);


                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch { }
            finally { _conn.Close(); }
            return false;
        }

        public bool UpdateSanPham(DTO_SanPham sp)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateDataIntoHang";
                cmd.Parameters.AddWithValue("tenHang", sp.TenHang);
                cmd.Parameters.AddWithValue("soLuong", sp.SoLuong);
                cmd.Parameters.AddWithValue("donGiaBan", sp.DonGiaBan);
                cmd.Parameters.AddWithValue("donGiaNhap", sp.DonGiaNhap);
                cmd.Parameters.AddWithValue("hinhAnh", sp.HinhAnh);
                cmd.Parameters.AddWithValue("GhiChu", sp.GhiChu);
                cmd.Parameters.AddWithValue("maHang", sp.MaHang);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch { }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool DeleteSanPham(int maHang)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteDataFromHang";
                cmd.Parameters.AddWithValue("maHang", maHang);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch { }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public DataTable SearchSanPham(string tenHang)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SearchDataFromHang";
                cmd.Parameters.AddWithValue("tenHang", tenHang);
                DataTable dtSP = new DataTable();
                dtSP.Load(cmd.ExecuteReader());
                return dtSP;
            }
            catch { }
            finally { _conn.Close(); }
            return null;
        }
    }
}
