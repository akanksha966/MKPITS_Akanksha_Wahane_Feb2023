﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace revision_again
{
    public static class ProductDetail
    {
        private static string connection = "server=.\\sqlexpress;integrated security=true;database=fendhal;";
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connection);
            try
            {
                return conn;
            }
            catch(Exception ex) { 
                return null;
            }
        }

        public static DataSet getproducttypename()
        {
            SqlConnection conn = GetConnection();
            string query = "select Product_Type_Name from TableProductCategory";
            DataSet ds= new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query,conn);
            da.Fill(ds, "TableProductCategory");
            return ds;

        }

        public static DataSet getproductname(string Product_Type_Name)
        {
            SqlConnection conn = GetConnection();
            string query = "select p. Product_Name from TableProduct p inner join TableProductCategory v on p.Product_Category_ID=v.Product_Category_ID where v.Product_Type_Name=@Product_Type_Name";
            DataSet ds2= new DataSet();
            SqlDataAdapter da=new SqlDataAdapter(query,conn);
            da.SelectCommand.Parameters.AddWithValue("@Product_Type_Name", Product_Type_Name);
            da.Fill(ds2, "TableProduct");
            return ds2;
        }
        public static DataSet GetProductPrice(string Product_Name)
        {
            SqlConnection conn = GetConnection();
            string query = "select ProductPrice from TableProduct where Product_Name=@Product_Name";
            DataSet ds2 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@Product_Name", Product_Name);
            da.Fill(ds2, "TableProduct");
            return ds2;
        }


    }
}
