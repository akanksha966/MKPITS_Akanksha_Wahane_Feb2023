using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _2nd_project_practice
{
    public static class Courese
    {

        private static string connection = "server=.\\sqlexpress;integrated security=true;database=Fendahl2;";
        public static SqlConnection GetConnection()
        {
            SqlConnection s=new SqlConnection(connection);
            try
            {
                return s;
            }
            catch { return null; }

        }
        public static DataSet getnation()
        {
            SqlConnection s = GetConnection();
            string query = "select NationName,NationID from TableNation";//dataset ko fill krta hai sqladapter aur usko bhejte query aur connection
             DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, s);
            da.Fill(ds,"TableNation");
            return ds;  
        }
        public static DataSet getstatename(string NationName)
        {
            SqlConnection s = GetConnection();
            string query = "select p.StateID, p. StateName from TableState p inner join TableNation s on p.NationID=s.NationID where NationName=@NationName";
            DataSet ds2 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, s);
            da.SelectCommand.Parameters.AddWithValue("@NationName",NationName);
            da.Fill(ds2, "TableState");
            return ds2;


        }
        public static DataSet getcityname(string StateName)
        {
            SqlConnection s = GetConnection();
            string query = "select l.CityID, l.CityName from TableCity l inner join TableState p on l.StateID=p.StateID where StateName=@StateName";
            DataSet ds2 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter( query, s);
            da.SelectCommand.Parameters.AddWithValue("@StateName", StateName);
            da.Fill(ds2, "CityName");
            return ds2;

        }
        //TableCourseRegDetail2 4 th table---

        public static string coursereg(int catetoryid ,string fullname,int genderid)
        {
            SqlConnection s = GetConnection();
            s.Open();   
            string query = "insert into TableCourseRegDetail2 values (@categoryid,@fullname,@genderid) ";
            SqlCommand cmd = new SqlCommand(query, s);
            cmd.Parameters.AddWithValue("@categoryid", catetoryid);
            cmd.Parameters.AddWithValue("@fullname", fullname);
            cmd.Parameters.AddWithValue("@genderid", genderid);
            cmd.ExecuteNonQuery();
            s.Close();
            return "insert 1 ";

        }
        public  static  int CourseRegID=0;
        public static string regaddress(int nationid,int stateid,int cityid)
        {
            SqlConnection s = GetConnection();  
            s.Open();
            string query = "select top 1 CourseRegID from TableCourseRegDetail2 order by CourseRegID desc ";
            SqlCommand command = new SqlCommand(query, s);  
            CourseRegID=Convert.ToInt32(command.ExecuteScalar());
            query = "insert into TableRegAddress3 values(@coursereg,@nationid,@stateid,@cityid)";
            command = new SqlCommand(query, s);
            command.Parameters.AddWithValue("@coursereg", CourseRegID);
            command.Parameters.AddWithValue("@nationid", nationid);
            command.Parameters.AddWithValue("@stateid", stateid);
            command.Parameters.AddWithValue("@cityid", cityid);
            command.ExecuteNonQuery();  
            s.Close();
            return "insert 2";








        }
    }
}
