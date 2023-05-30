using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace fendhal3
{
    public static class Invoicegeneration
    {
        private static string connection = "server=.\\sqlexpress;integrated security=true;database=Perficient;";
        public static SqlConnection GetConnection()
        {
            SqlConnection s=new SqlConnection(connection);
            try
            {
                return s;
            }
            catch { return null; }
        }
        public static DataSet getname()
        {
            SqlConnection s = GetConnection();
            string query = "select Name from COMPUTER";
            DataSet ds = new DataSet();
            SqlDataAdapter da= new SqlDataAdapter(query,s);    
            da.Fill(ds,"COMPUTER");
            return ds;  

        }
        public static DataSet getproductname(string Name) { 

            SqlConnection s = GetConnection();
            string query = "select * from COMPUTER where NAME=@Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da= new SqlDataAdapter( query,s);
            da.SelectCommand.Parameters.AddWithValue("@Name", Name);
            da.Fill(ds, "COMPUTER");
            return ds;
        }
        public static DataSet getcgst(string Name)
        {
            SqlConnection s = GetConnection();
            string query = "  select CGST,SGST from computer where Name=@Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da= new SqlDataAdapter(query,s);
            da.SelectCommand.Parameters.AddWithValue("@Name", Name);
            da.Fill(ds, "COMPUTERS");
            return ds;
        }
    }
}
