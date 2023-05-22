using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace fendahl
{
    public static class ProductStore
    {
        private static string connectionstring = "server=.\\sqlexpress;integrated security=true;database=Fendahl;";
        public static SqlConnection GetConnection()
        {
            SqlConnection con=new SqlConnection(connectionstring);
            try
            {
                //con.Open();
                return con;
            }
            catch (Exception ex)
            {
                return null;
            }
            //finally { con.Close(); }
        }

        //method to return product category
        public static DataSet Gettableproductcategory()
        {
            SqlConnection conn = GetConnection();
            string query = "select Product_Type_Name from TableProductCategory";//TableProductCategory tablename and //Product_Type_Name column name
            
                DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(ds, "TableProductCategory");
            return ds;
            //agr connected environment liye to useme sqldatareader class use krte hai



        }
        //method to return product name for given product type name
        public static DataSet Gettableproductname(string product_type_name)
        {
            SqlConnection conn = GetConnection();
            string query = "select p.product_name from TableProduct p inner join TableProductCategory t on p.Product_Category_ID=t.Product_Category_ID where t.Product_Type_Name=@Product_Type_Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query,conn);
            da.SelectCommand.Parameters.AddWithValue("@product_type_name", product_type_name);
            da.Fill(ds, "TableProduct");
            return ds;
        }
        //method to return gstdetails for given product type name
        public static DataSet GetGstDetails(string product_type_name) { 
            SqlConnection conn = GetConnection();
            string query= "select a.CGST,a.SGST,a.IGST from TableProductGSTDetailss a inner join TableProductCategory b on a.Product_Gst_ID=b.Product_Gst_ID where b.Product_Type_Name=@Product_Type_Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query,conn);
            da.SelectCommand.Parameters.AddWithValue("@product_type_name", product_type_name);
            da.Fill(ds, "TableProductGSTDetailss");
            return ds;
        }
        //method to return product price for given product_name
        public static DataSet GetProductPrice(string Product_Name)
        {
            SqlConnection conn = GetConnection();
            string query = "select ProductPrice from TableProduct where Product_Name=@Product_Name";
            DataSet ds2=new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query,conn);
            da.SelectCommand.Parameters.AddWithValue("@Product_Name", Product_Name);
            da.Fill(ds2, "TableProduct");
            return ds2;
        }




    }
}
