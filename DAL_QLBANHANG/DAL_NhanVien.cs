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
            catch
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
            }catch { }
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
            }catch { }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool VaiTroNhanVien(string email)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LayVaiTroNhanVien";
                cmd.Parameters.AddWithValue("email", email);
                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                    return true;
            }
            catch {}
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool DoiMatKhau(string email, string oddPass, string newPass)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DOIMK";
                cmd.Parameters.AddWithValue("EMAIL", email);
                cmd.Parameters.AddWithValue("@ODDPASS", oddPass);
                cmd.Parameters.AddWithValue("@NEWPASS", newPass);

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

        public DataTable GetNhanVien()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[DANHSACHNV]";
                cmd.Connection = _conn;
                DataTable dtNV = new DataTable();
                dtNV.Load(cmd.ExecuteReader());
                return dtNV;
            }
            catch {  }
            finally
            {
                _conn.Close();
            }
			return null;
        }

        public bool InsertNhanVien(DTO_NhanVien nv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[INSERTDATAINTONHANVIEN]";
                cmd.Parameters.AddWithValue("EMAIL", nv.Email);
                cmd.Parameters.AddWithValue("TENNV", nv.TenNv);
                cmd.Parameters.AddWithValue("DIACHI", nv.DiaChi);
                cmd.Parameters.AddWithValue("VAITRO", nv.VaiTro);
                cmd.Parameters.AddWithValue("TINHTRANG", nv.TinhTrang);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch { }
            finally { _conn.Close(); }
            return false;
        }

        public bool UpdateNhanVien(DTO_NhanVien nv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UPDATEDATAINTONHANVIEN";
                cmd.Parameters.AddWithValue("EMAIL", nv.Email);
                cmd.Parameters.AddWithValue("TENNV", nv.TenNv);
                cmd.Parameters.AddWithValue("DIACHI", nv.DiaChi);
                cmd.Parameters.AddWithValue("VAITRO", nv.VaiTro);
                cmd.Parameters.AddWithValue("TINHTRANG", nv.TinhTrang);
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

        public bool DeleteNhanVien(string email)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DELETEDATAFROMNHANVIEN";
                cmd.Parameters.AddWithValue("email", email);
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

        public DataTable SearchNhanVien(string tenNv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SEARCHDATAFROMNHANVIEN";
                cmd.Parameters.AddWithValue("tennv", tenNv);
                DataTable dtNv = new DataTable();
                dtNv.Load(cmd.ExecuteReader());
                return dtNv;
            }
            catch {  }
            finally { _conn.Close(); }
            return null;
        }
    }
}
