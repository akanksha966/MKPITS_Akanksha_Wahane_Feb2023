using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace fendhalna
{
    public static class Product
    {
        private static string connection = "server=.\\sqlexpress;integrated security=true;database=fendhal";
        public static SqlConnection GetConnection()
        {
            SqlConnection s=new SqlConnection(connection);
            try
            {
                //s.Open();
                return s;
            }
            catch(Exception e)
            {
                return null;
            }
            
        }
        public static DataSet getname()
        {
            SqlConnection s=GetConnection();
            string query = "select * from TableProductCategory";
            DataSet ds=new DataSet();

           SqlDataAdapter da=new SqlDataAdapter(query,s);
            da.Fill(ds,"TableProductCategory");
            return ds;
        }
       
        public static DataSet gerre(string Product_Type_Name)
        {
            SqlConnection s=GetConnection() ;
            string query = "select p.ProductID,p.product_name from TableProduct p inner join TableProductCategory t on p.Product_Category_ID=t.Product_Category_ID where t.Product_Type_Name=@Product_Type_Name";
            DataSet d=new DataSet();    
            SqlDataAdapter da=new SqlDataAdapter( query,s);
            da.SelectCommand.Parameters.AddWithValue("@Product_Type_Name",Product_Type_Name);
            da.Fill(d,"TableProduct");
            return d;


        }
    }
}
