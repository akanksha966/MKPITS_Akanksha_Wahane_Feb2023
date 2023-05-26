using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Reflection.Emit;

namespace fe3
{
    public static class product
    {
        private static string connection = "server=.\\sqlexpress;integrated security=true;database=persistent;";
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connection);

            try
            {
                conn.Open();
                return conn;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public static DataSet gettablecategoryname()
        {
            SqlConnection conn = GetConnection();
            string Query = "select * from TableProductCategory";
            DataSet ds=new DataSet();
            SqlDataAdapter da= new SqlDataAdapter(Query,conn);
            da.Fill(ds, "TableProductCategory");
            return ds;


        }

        public static DataSet productname(string Product_Type_Name)
        {
            SqlConnection conn = GetConnection();
            string query = "select p.ProductID, p.product_name from TableProduct p inner join TableProductCategory t on p.Product_Category_ID=t.Product_Category_ID where t.Product_Type_Name=@Product_Type_Name";
            DataSet ds2= new DataSet();
            SqlDataAdapter da= new SqlDataAdapter(query,conn);
            da.SelectCommand.Parameters.AddWithValue("@Product_Type_Name", Product_Type_Name);
            da.Fill(ds2, "Product_Name");
            return ds2; 


        }

        public static DataSet getprice(string Product_Name)
        {
            SqlConnection conn = GetConnection();
            string query = "select ProductPrice from TableProduct where Product_Name=@Product_Name";
            DataSet ds2 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@Product_Name", Product_Name);
            da.Fill(ds2, "TableProduct");
            return ds2;



        }

        public static DataSet getdetails( string Product_Type_Name)
        {
            SqlConnection conn = GetConnection();
            string query = "select a.CGST,a.SGST,a.IGST from TableProductGSTDetailss a inner join TableProductCategory b on a.Product_Gst_ID=b.Product_Gst_ID where b.Product_Type_Name=@Product_Type_Name";
            DataSet ds3= new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@Product_Type_Name", Product_Type_Name);
            da.Fill(ds3, "TableProductGSTDetailss");
            return ds3;



        }
        public static string getsavedetail(string Customer_Name, string Customer_Contact, int Product_Category_ID, int Product_ID, int Residential_Type_ID, DateTime Invoice_Date, decimal Quantity, decimal Price, decimal CGST, decimal SGST, decimal IGST, decimal CGST_Value, decimal SGST_value, decimal IGST_Value, decimal Total_Amount)
        {
            string result = null;
            string query = "insert into TableInvoiceDetailss values(@Customer_Name,@Customer_Contact,@Product_Category_ID,@Product_ID,@Residential_Type_ID,@Invoice_Date,@Quantity,@Price,@CGST,@SGST,@IGST,@CGST_Value,@SGST_value,@IGST_Value,@Total_Amount)";

            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Customer_Name", Customer_Name);
            cmd.Parameters.AddWithValue("@Customer_Contact", Customer_Contact);
            cmd.Parameters.AddWithValue("@Product_Category_ID", Product_Category_ID);
            cmd.Parameters.AddWithValue("@Product_ID", Product_ID);
            cmd.Parameters.AddWithValue("@Residential_Type_ID", Residential_Type_ID);
            cmd.Parameters.AddWithValue("@Invoice_Date", Invoice_Date);
            cmd.Parameters.AddWithValue("@Quantity", Quantity);
            cmd.Parameters.AddWithValue("@Price", Price);
            cmd.Parameters.AddWithValue("@CGST",CGST);
            cmd.Parameters.AddWithValue("@SGST", SGST);
            cmd.Parameters.AddWithValue("@IGST", IGST);
            cmd.Parameters.AddWithValue("@CGST_Value", CGST_Value);
            cmd.Parameters.AddWithValue("@SGST_value", SGST_value);
            cmd.Parameters.AddWithValue("@IGST_Value", IGST_Value);
            cmd.Parameters.AddWithValue("@Total_Amount", Total_Amount);
            try
            {
                cmd.ExecuteNonQuery();
                result = "inserted successfully";
            }
            catch(Exception ex)
            {
                result = ex.ToString();
            }
            finally
            {
                conn.Close();
            }
            return result;














        }

    }
}
