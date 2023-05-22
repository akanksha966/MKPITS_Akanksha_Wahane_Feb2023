using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Security.Cryptography;
using System.Xml.Linq;

using System.Data.SqlClient;
using System.Data;



namespace staticconnection
{
    public static class EmployeeDetails

    {
        private static string connection = "server=.\\sqlexpress;integrated security=true;database=Trust;";
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
        }
        public static string InsertRecord(string Empno, string name, string Gender, string email, string mobileno, string city, string Dob)
        {
            SqlConnection s = GetConnection();
            string query = "insert into Employee values(@Empno,@name,@Gender,@email,@mobileno,@city,@dob) ";
            try
            {
                SqlCommand command = new SqlCommand(query, s);
                command.Parameters.AddWithValue("@Empno", Empno);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@Gender", Gender);

                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@mobileno", mobileno);
                command.Parameters.AddWithValue("@city", city);
                command.Parameters.AddWithValue("@dob", Dob);

                command.ExecuteNonQuery();
                return "inserted successfully";
            }
            catch (Exception ee)
            {
                return ee.ToString();
            }
            finally { s.Close(); }
        }
        //update
        public static string UpdateUsers(string Empno, string Empname)
        {
            SqlConnection s = GetConnection();
            string query = "update Employee set Empname=@Empno where Empno=@Empno";
            try
            {
                SqlCommand command = new SqlCommand(query, s);

                command.Parameters.AddWithValue("@Empname", Empname);
                command.Parameters.AddWithValue("@Empno", Empno);

                command.ExecuteNonQuery();
                return "updated successfully";
            }
            catch (Exception ee)
            {
                return ee.ToString();
            }
            finally { s.Close(); }
        }

        //delete
        public static string DeleteUsers(string mobileno)
        {
            SqlConnection s = GetConnection();
            string query = "delete from Employee where mobileno=@mobileno";
            try
            {
                SqlCommand command = new SqlCommand(query, s);

                command.Parameters.AddWithValue("@mobileno", mobileno);




                command.ExecuteNonQuery();
                return "delete successfully";
            }
            catch (Exception ee)
            {
                return ee.ToString();
            }
            finally { s.Close(); }
        }



        //public static SqlDataReader Getcity()//method to return cityname
        //{
        //    SqlConnection s = GetConnection();
        //    string query = "select * from City";
        //    try
        //    {
        //        SqlCommand command = new SqlCommand(query, s);
        //        //sqldatareader is used to store record returned from city table
        //        SqlDataReader dr = command.ExecuteReader();
        //        return dr;

        //    }
        //    catch (SqlException ex)
        //    {
        //        return null;
        //    }

        //}

        public static DataSet GetCity()//code on dissconnected environment mtlab open close krta hai  
        {
            SqlConnection s = GetConnection();
            string query = "select * from City";
            try
            {
                DataSet ds = new DataSet();//dataset class
                SqlDataAdapter da = new SqlDataAdapter(query, s);//sqladapter class
                da.Fill(ds, "City");//fill method to open and closed connection
                return ds;
            }
            catch (Exception ee)
            {
                return null;
            }

        }
        //grid code table
        public static DataSet getEmployeeDetails()
        {
            SqlConnection s = GetConnection();
            DataSet ds = new DataSet();
            try
            {
                string qr = "select * from Employee";
                SqlDataAdapter da = new SqlDataAdapter(qr, s);
                da.Fill(ds, "Employee");
                return ds;
            }
            catch (Exception ee)
            {
                return null;
            }
        }

        //agr serch me code kiye to vo table pe aur ex jo id 1 dale to serf id ka he row dekhega
        //code
        public static DataSet searchemployee(string Empno)
        {
            SqlConnection s = GetConnection();
            DataSet dsa= new DataSet();
            string qr = "select * from Employee where Empno=@Empno ";
            SqlDataAdapter da = new SqlDataAdapter( qr, s);
            da.SelectCommand.Parameters.AddWithValue("@Empno", Empno);
            da.Fill(dsa, "Employee");
            return dsa;
        }
        
    }
}

