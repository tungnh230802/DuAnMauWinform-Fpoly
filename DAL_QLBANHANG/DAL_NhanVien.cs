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
    public class DAL_NhanVien:DbContext
    {
        //login
        public bool NhanVienDangNhap(DTO_NhanVien nv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DANGNHAP";
                cmd.Parameters.AddWithValue("EMAIL", nv.Email);
                cmd.Parameters.AddWithValue("MATKHAU", nv.MatKhau);
                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                    return true;
            }
            catch(Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool NhanVienQuenMk(string email)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "QUENMATKHAU";
                cmd.Parameters.AddWithValue("EMAIL", email);
                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                    return true;
            }catch(Exception e) { }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool TaoMauKhauMoi(string email, string matKhauMoi)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TAOMOIMATKHAU";
                cmd.Parameters.AddWithValue("EMAIL", email);
                cmd.Parameters.AddWithValue("MATKHAU", matKhauMoi);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }catch(Exception e) { }
            finally
            {
                _conn.Close();
            }
            return false;
        }
    }
}
