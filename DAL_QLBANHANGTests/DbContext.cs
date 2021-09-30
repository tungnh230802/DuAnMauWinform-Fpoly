using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLBANHANG
{
    public class DbContext
    {
        protected SqlConnection _conn = 
        new SqlConnection(@"Data Source=DESKTOP-2V5F3CA\TUNGNH230802;
        Initial Catalog=QUANLYBANHANG;
        Integrated Security=True;Persist Security Info=False;
        Pooling=False;MultipleActiveResultSets=False;
        Encrypt=False;TrustServerCertificate=False");
    }
}
