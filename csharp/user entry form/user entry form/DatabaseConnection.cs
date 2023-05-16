﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace user_entry_form
{
    public static class DatabaseConnection//static class
    {
        //static variable to create connection
        private static string ConnectionString = "server=.\\sqlexpress;integrated security=true;database=connection;";
        public static SqlConnection GetConnection()
        //creating a static method sqlconnection return type
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            try
            {
                con.Open();
                return con;
            }
            catch (SqlException ee)
            {
                return null;
            }


        }

        //creating a static method to insert record into a table
        public static string InsertRecord(string username, string password)
        {
            SqlConnection con = GetConnection();
            //creating a insert command

            string query = "insert into userdetail values(@username,@password)";
            //@username and @password are sqlparameters
            try
            {
                //create an object of sqlcommand(sqlcommand is classname)and command is variable()
                SqlCommand command = new SqlCommand(query, con);
                //defianing sql parameter
                command.Parameters.AddWithValue("@username ", username);
                command.Parameters.AddWithValue("@password ", password);
                //executing the command using executenonquery method
                command.ExecuteNonQuery();
                return "record inserted successfully";

            }
            catch (Exception ee)
            {
                return ee.ToString();

            }
            finally
            {
                con.Close();
            }
        }

        //creating a static method to update record into users table
        public static string UpdateUsers(string username, string password)
        {
            SqlConnection con = GetConnection();
            //creating a insert command
            string query = "update userdetail set password=@password where username=@username";
            //@username and @password are sqlparameters
            try
            {
                //creating an object of sqlcommand class
                SqlCommand command = new SqlCommand(query, con);
                //defining sqlparameters

                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@username", username);
                //executing the command using executenonquery method
                command.ExecuteNonQuery();
                return "record updated successfully";
            }
            catch (Exception ee)
            {
                return ee.ToString();
            }
            finally
            {
                con.Close();
            }

        }

        public static string DeleteUsers(string username)
        {
            SqlConnection con = GetConnection();
            //creating a insert command
            string query = "delete from userdetail  where username=@username";
            //@username and @password are sqlparameters
            try
            {
                //creating an object of sqlcommand class
                SqlCommand command = new SqlCommand(query, con);
                //defining sqlparameters


                command.Parameters.AddWithValue("@username", username);
                //executing the command using executenonquery method
                command.ExecuteNonQuery();
                return "record deleted successfully";
            }
            catch (Exception ee)
            {
                return ee.ToString();
            }
            finally
            {
                con.Close();
            }

        }


    }
}