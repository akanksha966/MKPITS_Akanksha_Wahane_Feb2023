using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace practicestatic
{
    public static class userclass
    {

        private static string connection = "server=.\\sqlexpress;integrated security=true;database=infosis;";
        public static SqlConnection GetConnection()
        {
            SqlConnection s = new SqlConnection(connection);
            try
            {
                s.Open();
                return s;
            }
            catch (SqlException ex)
            {
                return null;
            }
            //finally { s.Close(); }  
        }

        public static string InsertRecord(string username, string password)
        {
            SqlConnection s = GetConnection();
            string query = "insert into user1 values(@username,@password) ";
            try
            {
                SqlCommand command = new SqlCommand(query, s);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);


                command.ExecuteNonQuery();
                return "inserted successfully";
            }
            catch (Exception ee)
            {
                return ee.ToString();
            }
        }

        public static string UpdateRecord(string usename, string password)
        {
            SqlConnection s = GetConnection();
            string query = "update user1 set password=@password where usename=@username";
            try
            {
                SqlCommand cos = new SqlCommand(query, s);
                cos.Parameters.AddWithValue("@password", password);
                cos.Parameters.AddWithValue("@username", usename);
                cos.ExecuteNonQuery();
                return "update successfully";
            }
            catch (Exception ee)
            {
                return ee.ToString();
            }
        }
        public static string deleterecord(string usename)
        {
            SqlConnection s = GetConnection();
            string query = "delete from user1 where usename=@usename ";
            try
            {
                SqlCommand cos = new SqlCommand(query, s);
                cos.Parameters.AddWithValue("@usename", usename);
                cos.ExecuteNonQuery();
                return "delete successfully";


            }
            catch (Exception ee)
            {
                return ee.ToString();
            }
        }
        public static DataSet getcity()
        {
            SqlConnection s = GetConnection();
            string query = "select cityname from city3";
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, s);
                da.Fill(ds, "city3");
                return ds;


            }
            catch (Exception ee)
            {
                return null;
            }
        }
        public static DataSet getstate()
        {
            SqlConnection s = GetConnection();
            string query = "select statename from state";
            DataSet ds1 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, s);
            da.Fill(ds1, "state");
            return ds1;
        }


        public static DataSet getgridview()
        {
            SqlConnection s = GetConnection();
            DataSet ds2 = new DataSet();

           
            
                string query = "select * from user1";

                SqlDataAdapter da = new SqlDataAdapter(query, s);
                da.Fill(ds2, "user1");
                return ds2;
           

        }
        public static DataSet getsearch(string usename)

        {
            SqlConnection s = GetConnection();
            string query = "select * from user1 where usename=@usename";
            DataSet ds= new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query,s);
            da.SelectCommand.Parameters.AddWithValue("@usename", usename);
            da.Fill(ds, "user1");
            return ds;


        }
    }
}




