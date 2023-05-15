using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace practice_using_class_connection
{
    //static class
    public static class DatabaseConnection
    {
        private static string connect = "server=.\\sqlexpress;integrated security=true;database=connection;";
        public static SqlConnection GetConnection()//return  type sqlconnection
        {
            SqlConnection conn = new SqlConnection(connect);
            try
            {
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                return null;    

            }

        }

    }
        
    
}
