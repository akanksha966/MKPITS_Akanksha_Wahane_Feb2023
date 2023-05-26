using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace examfendhal
{
    public static class Product
    {
        private static string connection = "server=.\\sqlexpress;integrated security=true;database=persistent;";
        public static SqlConnection GetConnection()
        {
            SqlConnection s = new SqlConnection(connection);
            try
            {
                s.Open();
                return s;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static DataSet getproductname()
        {
            SqlConnection s = GetConnection();
            string query = "select * from TableProductCategory";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, s);
            da.Fill(ds, "TableProductCategory");
            return ds;
        }

        public static DataSet getname(string Product_Type_Name)
        {
            SqlConnection s = GetConnection();
            string query = "  select p.ProductID, p.Product_Name from TableProduct p inner join TableProductCategory s on p.Product_Category_ID=s.Product_Category_ID where s.Product_Type_Name=@Product_type_Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, s);
            da.SelectCommand.Parameters.AddWithValue("@Product_Type_Name", Product_Type_Name);
            da.Fill(ds, "TableProduct");
            return ds;
        }

        public static DataSet getprice(string Product_Name)
        {
            SqlConnection s = GetConnection();
            string query = "  select ProductPrice from TableProduct where Product_Name=@Product_Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, s);
            da.SelectCommand.Parameters.AddWithValue("@Product_Name", Product_Name);
            da.Fill(ds, "TableProduct");
            return ds;
        }
        public static DataSet getgstdetails(string Product_Type_Name)
        {
            SqlConnection s = GetConnection();
            string query = "select a.CGST,a.SGST,a.IGST from TableProductGSTDetailss a inner join TableProductCategory b on a.Product_Gst_ID=b.Product_Gst_ID where b.Product_Type_Name=@Product_Type_Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, s);
            da.SelectCommand.Parameters.AddWithValue("@Product_Type_Name", Product_Type_Name);
            da.Fill(ds, "TableProductGSTDetailss");
            return ds;

        }
        public static string saveinvoicedetails(string Customer_Name, string Customet_Contact, int Product_Category_ID, int Product_ID, int Residential_Type_ID, DateTime Invoice_Date, decimal Quantity, decimal Price, decimal CGST, decimal SGST, decimal IGST, decimal CGST_Value, decimal SGST_value, decimal IGST_Value, decimal Total_Amount)
        {
            string result = null;
            string query = "insert into TableInvoiceDetailss values(@Customer_Name,@Customet_Contact,@Product_Category_ID,@Product_ID,@Residential_Type_ID,@Invoice_Date,@Quantity,@Price,@CGST,@SGST,@IGST,@CGST_Value,@SGST_value,@IGST_Value,@Total_Amount)";
            SqlConnection s = GetConnection();
            SqlCommand comd=new SqlCommand(query, s);
            comd.Parameters.AddWithValue("@Customer_Name", Customer_Name);
            comd.Parameters.AddWithValue("Customet_Contact", Customet_Contact);
            comd.Parameters.AddWithValue("Product_Category_ID", Product_Category_ID);
            comd.Parameters.AddWithValue("@Product_ID", Product_ID);
            comd.Parameters.AddWithValue("@Residential_Type_ID", Residential_Type_ID);
            comd.Parameters.AddWithValue("@Invoice_Date", Invoice_Date);
            comd.Parameters.AddWithValue("@Quantity", Quantity);
            comd.Parameters.AddWithValue("@Price",Price);
            comd.Parameters.AddWithValue("@CGST", CGST);
            comd.Parameters.AddWithValue("@SGST", SGST);
            comd.Parameters.AddWithValue("@IGST", IGST);
            comd.Parameters.AddWithValue("@CGST_Value", CGST_Value);
            comd.Parameters.AddWithValue("@SGST_value", SGST_value);
            comd.Parameters.AddWithValue("@IGST_value", IGST_Value);
            comd.Parameters.AddWithValue("@Total_Amount", Total_Amount);
            try
            {
                comd.ExecuteNonQuery();
                result = "inserted successfully";
            }
            catch(Exception ex)
            {
                result = ex.ToString();
            }
            finally
            {
                s.Close();
            }
            return result;















        }

    }
}
