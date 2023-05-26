using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Reflection;
using System.Collections;
using System.Diagnostics;

namespace fe11
{
    public static class Products
    {
        private static string connection = "server=.\\sqlexpress;integrated security=true;database=persistent;";
        public static SqlConnection GetConnection()
        {
            SqlConnection s=new SqlConnection(connection);
            try
            {
                s.Open();
                return s;
            }
            catch(Exception e)
            {
                return null;
            }
        }
        public static DataSet getproducttypename()
        {
            SqlConnection s=GetConnection();
            string query = "select * from TableProductCategory";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query,s);
            da.Fill(ds, "TableProductCategory");
            return ds;
            
            
        }

        public static DataSet getproductname(string Product_Type_Name)
        {
            SqlConnection s = GetConnection();
            string query = "select p.ProductID, p.Product_Name from TableProduct p inner join TableProductCategory t on p.Product_Category_ID = t.Product_Category_ID where t.Product_Type_Name =@Product_Type_Name";

            DataSet ds2 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, s);
            da.SelectCommand.Parameters.AddWithValue("@Product_Type_Name", Product_Type_Name);
            da.Fill(ds2, "TableProduct");
            return ds2;


        }

        public static DataSet productprice( string Product_Name)
        {
            SqlConnection s = GetConnection();
            string query = "select ProductPrice from TableProduct where @Product_Name=Product_Name";
            DataSet ds3 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, s);
            da.SelectCommand.Parameters.AddWithValue("@Product_Name", Product_Name);
            da.Fill(ds3, "TableProduct");
            return ds3; 

        }

        public static DataSet cgstdetail(string Product_Type_Name)
        {
            SqlConnection s = GetConnection();
            string query = "select a.CGST,a.SGST,a.IGST from TableProductGSTDetailss a inner join TableProductCategory b on a.Product_Gst_ID=b.Product_Gst_ID where b.Product_Type_Name=@Product_Type_Name";

            DataSet ds3 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, s);
            da.SelectCommand.Parameters.AddWithValue("@Product_Type_Name", Product_Type_Name);
            da.Fill(ds3, "TableProductGSTDetailss");
            return ds3;

        }
        public static string savetableinvoicedetails(string Customer_Name, string Customer_Contact, int Product_Category_ID, int Product_ID, int Residential_Type_ID, DateTime Invoice_Date, decimal Quantity, decimal Price, decimal CGST, decimal SGST, decimal IGST, decimal CGST_Value, decimal SGST_value, decimal IGST_Value, decimal Total_Amount)
        {


            string result = null;
            string query = "insert into TableInvoiceDetailss values (@Customer_Name,@Customer_Contact,@Product_Category_ID,@Product_ID,@Residential_Type_ID,@Invoice_Date,@Quantity,@Price,@CGST,@SGST,@IGST,@CGST_Value,@SGST_value,@IGST_Value,@Total_Amount)";

            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Customer_Name", Customer_Name);//textbox1
            cmd.Parameters.AddWithValue("@Customer_Contact", Customer_Contact);//textbox2
            cmd.Parameters.AddWithValue("@Product_Category_ID", Product_Category_ID);//combobox1
            cmd.Parameters.AddWithValue("@Product_ID", Product_ID);//combobox2
            cmd.Parameters.AddWithValue("@Residential_Type_ID", Residential_Type_ID);//nationality
            cmd.Parameters.AddWithValue("@Invoice_Date", Invoice_Date);//datetimepicker1
            cmd.Parameters.AddWithValue("@Quantity", Quantity);//textbox10
            cmd.Parameters.AddWithValue("@Price", Price);//textbox9
            cmd.Parameters.AddWithValue("@CGST", CGST);//textbox3
            cmd.Parameters.AddWithValue("@SGST", SGST);//textbox4
            cmd.Parameters.AddWithValue("@IGST", IGST);//textbox5
            cmd.Parameters.AddWithValue("@CGST_Value", CGST_Value);///textbox6
            cmd.Parameters.AddWithValue("@SGST_Value", SGST_value);// textbox7
            cmd.Parameters.AddWithValue("@IGST_Value", IGST_Value);///textbox8
            cmd.Parameters.AddWithValue("@Total_Amount", Total_Amount);///textbox11
            try
            {
                cmd.ExecuteNonQuery();
                result = "Record Successfully";
            }
            catch (Exception ex)
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

