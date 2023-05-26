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
            string query = "select NationName,NationID from TableNation";//dataset ko fill krta hai sqladapter aur usko bhejte query aur connection
            DataSet ds= new DataSet();
            SqlDataAdapter da=new SqlDataAdapter(query,s);
            da.Fill(ds,"NationName");
            return ds;  //return type dataset
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
            DataSet ds2= new DataSet();
            SqlDataAdapter da=new SqlDataAdapter(query,s);
            da.SelectCommand.Parameters.AddWithValue("@StateName", StateName);
            da.Fill(ds2, "TableCity");
            return ds2; 
        }
        ///////4 th table----TableCourseRegDetail2 data insert the table------
       public static string savetablecourseregdetail(int CategoryID,string FullName,int GenderID )
        {
            SqlConnection s = GetConnection();
            s.Open();
            string query = "insert into TableCourseRegDetail2 values(@categoryid,@fullname,@genderid)";
            SqlCommand cmd = new SqlCommand(query,s);
            cmd.Parameters.AddWithValue("@categoryid", CategoryID);
            cmd.Parameters.AddWithValue("@fullname", FullName);
            cmd.Parameters.AddWithValue("@genderid", GenderID);
            cmd.ExecuteNonQuery();
            s.Close();
            return "record saved in TableCourseRegDetail2 successfully";
        }
        ///////5th //method to save record in TableRegAddress2--
        static int CourseRegID = 0;
        public static string savetablereg(int NationID,int StateID,int CityID)
        {
            SqlConnection s = GetConnection();
            s.Open();
            string query = " SELECT top 1 CourseRegID FROM TableCourseRegDetail2 ORDER BY CourseRegID DESC";
            SqlCommand cmd=new SqlCommand(query,s);
            CourseRegID=Convert.ToInt32(cmd.ExecuteScalar());//return single value
            query = "insert into TableRegAddress3 values (@CourseRegID,@NationID,@StateID,@CityId)";
            cmd = new SqlCommand(query,s);
            cmd.Parameters.AddWithValue("@CourseRegID", CourseRegID);
            cmd.Parameters.AddWithValue("@NationID", NationID);
            cmd.Parameters.AddWithValue("@StateID", StateID);
            cmd.Parameters.AddWithValue("@CityId", CityID);
            cmd.ExecuteNonQuery();
            s.Close();
            return "record save in TableRegAddress3 ";


        }
        // method to save record TableFeeDetail--
        public static string savetablefeedetails(double totalamount,double minper,double paidamount,double balamount,DateTime PaidDate)
        {
            SqlConnection s = GetConnection();
            s.Open();
            string query = "insert into TableFeeDetail2 values(@CourseRegID,@totalamount,@minper,@paidamount,@balamount,@paidDate)";
            SqlCommand c = new SqlCommand(query,s);
            c.Parameters.AddWithValue("@CourseRegID", CourseRegID);
            c.Parameters.AddWithValue("@totalamount", totalamount);
            c.Parameters.AddWithValue("@minper", minper);
            c.Parameters.AddWithValue("@paidamount", paidamount);
            c.Parameters.AddWithValue("@balamount", balamount);
            c.Parameters.AddWithValue("@paidDate", PaidDate);
            c.ExecuteNonQuery();
            s.Close();
            return "record saved in TableFeeDetail2";



        }





    }
}
