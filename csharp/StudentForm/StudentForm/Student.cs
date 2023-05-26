using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StudentForm
{
    public static class Student
    {
        private static string connection = "server=.\\sqlexpress;integrated security=true;database=mkpit;";
        public static SqlConnection GetConnection()
        {
            SqlConnection s=new SqlConnection(connection);
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
        public static DataSet getcoursename()
        {
            SqlConnection s=GetConnection();
            string query = "select CourseName from CourseFind";
            DataSet ds=new DataSet();
            SqlDataAdapter da= new SqlDataAdapter(query,s);
            da.Fill(ds, "CourseFind");
            return ds;  
        }
        public static DataSet getcountryname()
        {
            SqlConnection s = GetConnection();
            string query = "select CountryName from country2";
            DataSet ds2 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, s);
            da.Fill(ds2, "country2");
            return ds2;
        }
        public static DataSet getstatename(string CountryName)
        {
            SqlConnection s=GetConnection();
            string query = "select s.StateName from State s inner join country2 p on  s.CountryId=p.CountryId where CountryName=@CountryName";
            DataSet ds2 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, s);
            da.SelectCommand.Parameters.AddWithValue("@CountryName", CountryName);
            da.Fill(ds2, "State");
            return ds2; 
        }

        public static DataSet getcityname(string StateName)
        {
            SqlConnection s=GetConnection();
            string query = "select v.CityName from City v inner join State s on v.StateId =s.StateId where StateName=@StateName";
            DataSet ds3 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, s);
            da.SelectCommand.Parameters.AddWithValue("@StateName", StateName);
            da.Fill(ds3, "City");
            return ds3;
        }

        public static DataSet getfees(string CourseName)
        {
            SqlConnection s=GetConnection();
            string query = "select Fees from CourseFind where CourseName =@CourseName";
            DataSet ds4 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query,s);
            da.SelectCommand.Parameters.AddWithValue("CourseName", CourseName);
            da.Fill(ds4, "CourseFind");
            return ds4;
        }
        public static string save(string Full_Name,string CourseName,DateTime Invoice_Date,string CountryName,string StateName,string City,decimal Total_Fees,decimal Paid_Amount,decimal Total_Balance)
        {
            SqlConnection s=GetConnection();
            string result = null;
            string query = "insert into TableinvoiceDetail values(@Full_Name,@CourseName,@Invoice_Date,@CountryName,@StateName,@City,@Total_Fees,@Paid_Amount,@Total_Balance)";
            SqlCommand cmd = new SqlCommand(query, s);
            cmd.Parameters.AddWithValue("@Full_Name", Full_Name);
            cmd.Parameters.AddWithValue("@CourseName", CourseName);
            cmd.Parameters.AddWithValue("@Invoice_Date", Invoice_Date);
            cmd.Parameters.AddWithValue("@CountryName", CountryName);
            cmd.Parameters.AddWithValue("@StateName", StateName);
            cmd.Parameters.AddWithValue("@City", City);
            cmd.Parameters.AddWithValue("@Total_Fees", Total_Fees);
            cmd.Parameters.AddWithValue("@Paid_Amount", Paid_Amount);
            cmd.Parameters.AddWithValue("@Total_Balance", Total_Balance);
            try
            {
                cmd.ExecuteNonQuery();
                result= "successfullt inserted";
            }
            catch (Exception ex)
            {
                result.ToString();
            }
            finally { s.Close(); }  
            return result;







        }




    }
}
