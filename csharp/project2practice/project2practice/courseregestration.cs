using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace project2practice
{
    public static class courseregestration
    {
        private static string connection = "server=.\\sqlexpress;integrated security=true;database=Fendahl2;";

        public static SqlConnection GetConnection()
        {
            SqlConnection s=new SqlConnection(connection);
            try
            {
                return s;
            }
            catch { 
                return null; 
            }
        }
        public static DataSet getnationname()
        {
            SqlConnection s = GetConnection();
            string query = "select NationName from TableNation";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query,s);
            da.Fill(ds,"TableNation");
            return ds;  

        }
        public static DataSet getstatename(string NationName)
        {
            SqlConnection s = GetConnection();
            string query = "select p.StateID, p. StateName from TableState p inner join TableNation s on p.NationID=s.NationID where NationName=@NationName";
            DataSet ds1 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, s);
            da.SelectCommand.Parameters.AddWithValue("@NationName", NationName);
            da.Fill(ds1, "TableState");
            return ds1;  

        }
        public static DataSet getcityname(string StateName)
        {
            SqlConnection s = GetConnection();
            string query = "select  l.CityName,l.CityID from TableCity l inner join TableState p on l.StateID=p.StateID where StateName=@StateName";
            DataSet ds2=new DataSet();
            SqlDataAdapter da = new SqlDataAdapter( query, s);
            da.SelectCommand.Parameters.AddWithValue("@StateName", StateName);
            da.Fill(ds2, "CityName");
            return ds2;  
        }
    }
}
