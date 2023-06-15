using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Data;
namespace storelibrary
{
   public static class Dbconnection
    {
        public static SqlConnection s;
        public static SqlConnection GetConnection()
        {
            s=new SqlConnection("server=.\\sqlexpress;integrated security=true;database=civica;");
            return s;
        }
        
    }
}
