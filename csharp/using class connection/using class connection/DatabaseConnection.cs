using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace using_class_connection
{
    //static class
    public static class DatabaseConnection
    {
        //static variable
        private static string ConnectionString = "server=.\\sqlexpress;integrated security=true;database=abcd;";
        public static SqlConnection GetConnection()
           
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            try
            {
                con.Open();
                return con;
            }
            catch(SqlException ee)
            {
                return null;
            }

        }

    }
}
