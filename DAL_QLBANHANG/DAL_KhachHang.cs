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
    public class DAL_KhachHang : DbContext
    {
        public DataTable GetKhachHang()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[DANHSACHKH]";
                cmd.Connection = _conn;
                DataTable dtKH = new DataTable();
                dtKH.Load(cmd.ExecuteReader());
                return dtKH;
            }
            catch { }
            finally
            {
                _conn.Close();
            }
            return null;
        }

        public bool InsertKhachHang(DTO_KhachHang kh)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[INSERTDATAINTOKHACHHANG]";
                cmd.Parameters.AddWithValue("DIENTHOAI", kh.DienThoai);
                cmd.Parameters.AddWithValue("TENKHACH", kh.TenKhach);
                cmd.Parameters.AddWithValue("DIACHI", kh.DiaChi);
                cmd.Parameters.AddWithValue("PHAI", kh.Phai);
                cmd.Parameters.AddWithValue("EMAIL", kh.Email);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch { }
            finally { _conn.Close(); }
            return false;
        }

        public bool UpdateKhachHang(DTO_KhachHang kh)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UPDATEDATAINTOKHACHHANG";
                cmd.Parameters.AddWithValue("DIENTHOAI", kh.DienThoai);
                cmd.Parameters.AddWithValue("TENKHACH", kh.TenKhach);
                cmd.Parameters.AddWithValue("DIACHI", kh.DiaChi);
                cmd.Parameters.AddWithValue("PHAI", kh.Phai);
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

        public bool DeleteKhachHang(string dienThoai)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DELETEDATAFROMKHACHHANG";
                cmd.Parameters.AddWithValue("DIENTHOAI", dienThoai);
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

        public DataTable SearchKhachHang(string dienThoai)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SEARCHDATAFROMKHACHHANG";
                cmd.Parameters.AddWithValue("DIENTHOAI", dienThoai);
                DataTable dtkh = new DataTable();
                dtkh.Load(cmd.ExecuteReader());
                return dtkh;
            }
            catch { }
            finally { _conn.Close(); }
            return null;
        }
    }
}
