using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class nguoiDungDAL:DBConnect
    {
        public int dangNhap(string id, string pass)
        {
            openC();
            SqlCommand cmd = new SqlCommand("checkLogin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@user", id));
            cmd.Parameters.Add(new SqlParameter("@pass", pass));
            int kq = (int)cmd.ExecuteScalar();
            closeC();
            return kq;
        }
    }
}
