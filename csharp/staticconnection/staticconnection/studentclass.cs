using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace staticconnection
{
    public static class studentclass
    {
        private static string Connection = "server=.\\sqlexpress;integrated security=true;database=Trust;";
        public static SqlConnection GetConnection()
        {
            SqlConnection s = new SqlConnection(Connection);
            try
            {
                return s;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static string getinserted(string studentid, string studentname, string gender, string email, string mobileno, string city, string dob)

        {
            SqlConnection s = GetConnection();
            string query = "insert into Student values(@studentid,@studentname,@gender,@email,@mobileno,@city,@dob)";
            try
            {
                SqlCommand comm = new SqlCommand(query, s);
                comm.Parameters.AddWithValue("@studentid", studentid);
                comm.Parameters.AddWithValue("@studentname", studentname);
                comm.Parameters.AddWithValue("@gender", gender);
                comm.Parameters.AddWithValue("@email", email);
                comm.Parameters.AddWithValue("@mobileno", mobileno);
                comm.Parameters.AddWithValue("@city", city);
                comm.Parameters.AddWithValue("@dob", dob);
                comm.ExecuteNonQuery();
                return "inserted suuccessfully";
            }
            catch (Exception e)
            {
                return null;

            }
        }




    }
}

