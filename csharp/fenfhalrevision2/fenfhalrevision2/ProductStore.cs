using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace fenfhalrevision2
{
    public static class ProductStore
    {
        private static string connection = "server=.\\sqlexpress;integrated security=true;database=fendhal;";
        public static SqlConnection GetConnection()
        {
            SqlConnection s = new SqlConnection(connection);
            try
            {
                return s;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static DataSet getproducttypename()
        {
            SqlConnection s = GetConnection();
            string query = "select Product_Type_Name from TableProductCategory ";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, s);
            da.Fill(ds, "Product_Type_Name");
            return ds;

        }
        public static DataSet getproductname(string Product_Type_Name)
        {
            SqlConnection s = GetConnection();
            string query = "select p.product_Name from TableProduct p inner join TableProductCategory v on p.Product_Category_ID=v.Product_Category_ID where v.Product_Type_Name=@Product_Type_Name";
            DataSet ds2 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, s);
            da.SelectCommand.Parameters.AddWithValue("@Product_Type_Name", Product_Type_Name);
            da.Fill(ds2, "TableProduct");
            return ds2;
        }

        public static DataSet getgttables(string Product_Type_Name)
        {
            SqlConnection s = GetConnection();
            string query = "select a.CGST,a.SGST,a.IGST from TableProductGSTDetailss a inner join TableProductCategory b on a.Product_Gst_ID=b.Product_Gst_ID where b.Product_Type_Name=@Product_Type_Name";
            DataSet ds2 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, s);
            da.SelectCommand.Parameters.AddWithValue("@Product_Type_Name", Product_Type_Name);
            da.Fill(ds2, "TableProductGSTDetailss");
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

    
