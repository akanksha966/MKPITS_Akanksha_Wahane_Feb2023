using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace CrudOperation.Models
{
    public class ItemDbHandler
    {
        SqlConnection con = null;
        private void connction()
        {
            string constr = "server=.\\sqlexpress;integrated security=true;database=mkpit;";

            con = new SqlConnection(constr);
        }
        public bool InsertItemModel(ItemModel item)
        {
            connction();
            string query = "insert into ItemList values('" + item.Name + "','" + item.Category + "','" + item.Price + "') ";
            SqlCommand cmd=new SqlCommand(query, con);
           con.Open();
            int i=cmd.ExecuteNonQuery();
            con.Close();
            if(i>=0) {

                return true;
            }
            else
            {
                return false;
            }

        }
        public bool UpdateinsertModel(ItemModel item) { 

            connction();
            string query = "update ItemList set Name = '" + item.Name + "', Category='" + item.Category + "', Price='" + item.Price + "' where Id= '" + item.ID + "' ";
            SqlCommand cmd=new SqlCommand(query, con);
            con.Open();
            int i=cmd.ExecuteNonQuery();
            con.Close();
            if(i>=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteinsertModel(ItemModel item) 
        {  
            
            connction();
            string query = "delete from ItemList where Id='" + item.ID + "'";
            SqlCommand cmd= new SqlCommand(query, con);
            SqlDataAdapter sql = new SqlDataAdapter(cmd);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if(i>=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<ItemModel> GetItems()
        {
            connction();
            List<ItemModel> list = new List<ItemModel>();
            string query = "select * from ItemList";
            SqlCommand md = new SqlCommand(query, con);
            SqlDataAdapter da=new SqlDataAdapter(md);
            DataTable dy = new DataTable();
            con.Open();
            da.Fill(dy);
            foreach(DataRow dr in dy.Rows)
            {
                list.Add(new ItemModel
                {
                    ID = Convert.ToInt32(dr["ID"]),
                    Name = Convert.ToString(dr["Name"]),
                    Category = Convert.ToString(dr["Category"]),
                    Price = Convert.ToInt32(dr["Price"])
                });
            }
            return list;
        }


    }
}