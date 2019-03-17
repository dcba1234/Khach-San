using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnect
    {
        protected SqlConnection con = new SqlConnection(@"Data Source = (local); Initial Catalog = QLKS; Integrated Security = True");
        public void openC()
        {
            if(con.State != ConnectionState.Open)
           con.Open();
          
        }
        public void closeC()
        {
            if (con.State == ConnectionState.Open)
            con.Close();

           
        }
    }
}
