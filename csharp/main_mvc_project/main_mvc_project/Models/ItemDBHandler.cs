using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

using System.Configuration;
using System.Collections;

namespace main_mvc_project.Models
{
    public class ItemDBHandler
    {
        public SqlConnection con;
        private void connection()
        {


            string constring = ConfigurationManager.ConnectionStrings["CompShopConString"].ToString();
            con=new SqlConnection(constring);
        }

        ///////get all itemlist-----
        ///list generic class to create collection of itemmodel object

        public List<ItemModel> getitemlist()
        {
            connection();
            List<ItemModel> iList = new List<ItemModel>();
            string query = "select * from  ItemList";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            adapter.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                iList.Add(new ItemModel
                {
                    ID = Convert.ToInt32(dr["ID"]),
                    Name = Convert.ToString(dr["Name"]),
                    Category = Convert.ToString(dr["Category"]),
                    Price = Convert.ToDecimal(dr["Price"])
                });
            }
            return iList;
        }

        public bool InsertItem(ItemModel item)
        {
            connection();
            string query = "insert into ItemList values('" + item.Name + "','" +item.Category + "','" + item.Price + "')";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
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


