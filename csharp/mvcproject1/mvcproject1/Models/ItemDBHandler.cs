namespace mvcproject1.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Configuration;
    public class ItemDBHandler
    {
        SqlConnection con = null;
        public void connection()
        {
            string constr = "server=.\\sqlexpress;integrated security=true;database=formshop";
            con=new SqlConnection(constr);
        }
        //insert insertitem to insert record itemlist table
        public bool InsertItem(ItemModel Ilist)
        {
            connection();//connection method called
            string query= "insert into ItemList values('" + Ilist.Name + "','" + Ilist.Category + "','" + Ilist.Price + "')";
            SqlCommand cmd=new SqlCommand(query, con);
            con.Open();
            int i=cmd.ExecuteNonQuery();
            con.Close();
            if(i>=1)
            {
                return true;    
            }
            else
            {
                return false;
            }
        }

    }
}
