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
        private static string connection = "server=.\\sqlexpress;integrated security=true;database=tcs;";

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
            string query = "select NationName,NationID from TableNation";
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
            string query = "select l.CityID, l.CityName from TableCity l inner join TableState p on l.StateID=p.StateID where StateName=@StateName";
            DataSet ds2 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, s);
            da.SelectCommand.Parameters.AddWithValue("@StateName", StateName);
            da.Fill(ds2, "TableCity");
            return ds2;
        }
        //TableCourseRegDetail2 4th table---

        public static string TableCourseReg(int categoryid,string fullname, int genderid)
        {
            SqlConnection s = GetConnection();
            s.Open();
            string query = "insert into TableCourseRegDetail2 values(@categoryid,@fullname,@genderid)";
             SqlCommand cmd = new SqlCommand(query, s);
            cmd.Parameters.AddWithValue("@categoryid", categoryid);
            cmd.Parameters.AddWithValue("@fullname", fullname);
            cmd.Parameters.AddWithValue("@genderid", genderid);
            cmd.ExecuteNonQuery();
            s.Close();
            return "inserted successfully";

        }
        ///// 5 th table TableRegAddress.......
        public static int CourseRegID = 0;
        public static string regaddress(int nationid,int stateid,int cityid)
        {
            SqlConnection s = GetConnection();
            s.Open();
            string query = "SELECT top 1 CourseRegID FROM TableCourseRegDetail2 ORDER BY CourseRegID DESC";
            SqlCommand cmd=new SqlCommand(query, s);
            CourseRegID=Convert.ToInt32(cmd.ExecuteScalar());
            query = "insert into  TableRegAddress3 values(@courseregid,@nationid,@stateid,@cityid)";
            cmd=new SqlCommand(query, s);
            cmd.Parameters.AddWithValue("@courseregid", CourseRegID);
            cmd.Parameters.AddWithValue("@nationid", nationid);
            cmd.Parameters.AddWithValue("@stateid", stateid);
            cmd.Parameters.AddWithValue("@cityid", cityid);
            cmd.ExecuteNonQuery();
            s.Close();
            return "inserted  TableRegAddress3 data successfully";


        }

        
        public static string tablefeedateil2(double totalamount,double minper,double paidamount,double balamount,DateTime paiddate)
        {
            SqlConnection s = GetConnection();
            s.Open();
            string query = "insert into TableFeeDetail2 values(@courseregid,@totalamount,@minper,@paidamount,@balamount,@paiddate) ";
            SqlCommand c = new SqlCommand(query, s);
            c.Parameters.AddWithValue("@courseregid", CourseRegID);
            c.Parameters.AddWithValue("@totalamount", totalamount);
            c.Parameters.AddWithValue("@minper", minper);
            c.Parameters.AddWithValue("@paidamount", paidamount);
            c.Parameters.AddWithValue("@balamount", balamount);
            c.Parameters.AddWithValue("@paiddate", paiddate);
            c.ExecuteNonQuery();
            s.Close();
            return "inserted successfully table 5 record";





        }

    }
}
