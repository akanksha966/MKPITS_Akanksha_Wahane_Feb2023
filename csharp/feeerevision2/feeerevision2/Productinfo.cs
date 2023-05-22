using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace feeerevision2
{
    public static class Productinfo
    {
        private static string connection = "server=.\\sqlexpress;integrated security=true;database=fendhal;";
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connection);
            try
            {
                return conn;
            }
            catch (Exception ee) {
            }
            return null;
        }

        public static DataSet tableproductcategory()
        {
            SqlConnection conn = GetConnection();
            string query = "select Product_Type_Name from TableProductCategory";
            DataSet ds = new DataSet();
            SqlDataAdapter da= new SqlDataAdapter(query,conn);
            da.Fill(ds, "TableProductCategory");
            return ds;  
           
        }

        public static DataSet getproductname(string Product_Type_Name)
        {
            SqlConnection conn = GetConnection();
            string query = "  select p.Product_Name from TableProduct p inner join TableProductCategory c on p.Product_Category_ID=c.Product_Category_ID where c.Product_Type_Name=@Product_Type_Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("Product_Type_Name", Product_Type_Name);
            da.Fill(ds, " TableProduct");
            return ds;

        }
        public static DataSet getprice(string Product_Name)
        {
            SqlConnection conn = GetConnection();
            string query = "select ProductPrice from TableProduct where Product_Name=@Product_Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("Product_Name", Product_Name);
            da.Fill(ds, " TableProduct");
            return ds;

        }
    }
}
