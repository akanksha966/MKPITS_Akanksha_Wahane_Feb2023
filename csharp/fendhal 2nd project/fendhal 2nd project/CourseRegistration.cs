using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace fendhal_2nd_project
{
    public static class CourseRegistration
    {
        private static string connection = "server=.\\sqlexpress;integrated security=true;database=Fendahl2;";
        public static SqlConnection GetConnection()
        {
            SqlConnection s=new SqlConnection(connection);
            try
            {
                // s.Open();
                return s;
            }
            catch { 
                return null; 
            }

        }
        public static DataSet getnationname()//databse store the data in the form of table
        {
            SqlConnection s = GetConnection();
            string query = "select NationName from TableNation";//dataset ko fill krta hai sqladapter aur usko bhejte query aur connection
            DataSet ds= new DataSet();
            SqlDataAdapter da=new SqlDataAdapter(query,s);
            da.Fill(ds,"NationName");
            return ds;  //return type dataset
        }
        public static DataSet getstatename(string NationName)
        {
            SqlConnection s = GetConnection();
            string query = "select p. StateName from TableState p inner join TableNation s on p.NationID=s.NationID where NationName=@NationName";
            DataSet ds1 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, s);
            da.SelectCommand.Parameters.AddWithValue("@NationName", NationName);
            da.Fill(ds1, "TableState");
            return ds1;
        }



        public static DataSet getcityname(string StateName)
        {
            SqlConnection s = GetConnection();
            string query = "select l.CityName from TableCity l inner join TableState p on l.StateID=p.StateID where StateName=@StateName";
            DataSet ds2= new DataSet();
            SqlDataAdapter da=new SqlDataAdapter(query,s);
            da.SelectCommand.Parameters.AddWithValue("@StateName", StateName);
            da.Fill(ds2, "TableCity");
            return ds2; 
        }
    }
}
