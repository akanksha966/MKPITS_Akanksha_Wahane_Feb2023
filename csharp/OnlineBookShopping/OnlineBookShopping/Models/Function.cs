using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlClient;


namespace OnlineBookShopping.Models
{
    public class Function
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string connection;
        public Function() 
        {
            connection = "server=.\\sqlexpress;integrated security=true;database=bookshop;";
            con = new SqlConnection(connection);
            cmd = new SqlCommand();
            cmd.Connection= con;    

        
        }
        public DataTable GetData(string query)
        {
            con.Open();
            dt= new DataTable();
            sda=new SqlDataAdapter(query,connection);
            sda.Fill(dt);
            con.Close();
            return dt;
           
        }
          
      

        
    }
    

}   