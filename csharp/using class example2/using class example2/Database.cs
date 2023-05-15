using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace using_class_example2
{
    public static class Database
    {
        private static string connect = "server=.\\sqlexpress;integrated security=true;database=abcd;";
        public static SqlConnection GetConnection()
        {
            SqlConnection s=new SqlConnection(connect);
            try
            {
                s.Open();
                return s;
            }
            catch(Exception e) 
            {
                return null;
            }
        }
    }
}
