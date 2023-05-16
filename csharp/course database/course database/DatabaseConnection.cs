using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace course_database
{
    public static class DatabaseConnection
    {
        private static string ConnectionString = "server=.\\sqlexpress;integrated security=true;database=connection;";

        public static SqlConnection GetConnection()
        {
            SqlConnection S = new SqlConnection(ConnectionString);
            try
            {
                S.Open();
                return S;
            }
            catch (Exception ex)
            {
                return null;
            }

        }


        ///////inserted the record
        public static string InsertRecord(string RollNo, string Name, string lastname, string Course, string city)
        {
            SqlConnection s = GetConnection();
            string query = "insert into Students values(@RollNo,@Name,@lastname,@Course,@city)";
            try
            {
                SqlCommand command = new SqlCommand(query, s);
                command.Parameters.AddWithValue("@RollNo", RollNo);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@lastname", lastname);
                command.Parameters.AddWithValue("@Course", Course);
                command.Parameters.AddWithValue("@city", city);
                command.ExecuteNonQuery();
                return "successfully inserted";
            }
            catch (Exception ex)

            {
                return ex.ToString();
            }

            finally { s.Close(); }
        }









            

        

    }
}
