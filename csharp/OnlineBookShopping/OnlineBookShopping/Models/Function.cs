using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace OnlineBookShopping.Models
{
    public class Function
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string constr;
        public Function() 
        {
            constr = @"Data Source=.\sqlexpress;Initial Catalog=bookshop;Integrated Security=True";
            con = new SqlConnection(constr);
            cmd = new SqlCommand();
            cmd.Connection= con;    

        
        }
        public DataTable GetData(string query)
        {
            con.Open();
            dt= new DataTable();
            sda=new SqlDataAdapter(query,constr);
            sda.Fill(dt);
            con.Close();
            return dt;
           
        }
        public int setdata(string query)
        {
            int cnt = 0;
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandText = query;
            cnt=cmd.ExecuteNonQuery();
            con.Close() ;
            return cnt;
        }
          
      

        
    }
    

}   