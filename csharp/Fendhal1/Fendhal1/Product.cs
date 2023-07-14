using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Fendhal1
{
   public static class Product
    {
        private static string ConnectionString = "server=.\\sqlexpress;integrated security=true;database=FendhalM;";
        public static SqlConnection GetConnection()
        {
            SqlConnection Con=new SqlConnection(ConnectionString);
            try
            {
                return Con;
                //con.Open();
            }
            catch (Exception ee)
            {
                return null;
            }
        }
        public static DataSet GetTableProductCategory()
        {
            SqlConnection Con=GetConnection();
            string Query = "select * from TableProductCategory";
            DataSet Ds=new DataSet();
            SqlDataAdapter Adapter = new SqlDataAdapter(Query,Con);
            Adapter.Fill(Ds, "TableProductCategory");
            return Ds;

        }
        public static DataSet GetProductName(string Product_Type_Name)
        {
            SqlConnection Con=GetConnection();
            string query = "select p.ProductID,p.Product_Name from TableProduct p inner join TableProductCategory s on p. Product_Category_ID =s.Product_Category_ID  where s.Product_Type_Name= @Product_Type_Name";
            DataSet Ds1= new DataSet();
            SqlDataAdapter Adapter = new SqlDataAdapter(query,Con);
            Adapter.SelectCommand.Parameters.AddWithValue("@Product_Type_Name", Product_Type_Name);
            Adapter.Fill(Ds1 ,"TableProduct");
            return Ds1;
        }
       public static DataSet GetProductPrice(string Product_Name)
        {
            SqlConnection Con=GetConnection();
            string query = "select  ProductPrice  from TableProduct where Product_Name=@Product_Name";
            DataSet Ds2= new DataSet();
            SqlDataAdapter Adapter = new SqlDataAdapter( query,Con);
            Adapter.SelectCommand.Parameters.AddWithValue("@Product_Name", Product_Name);
            Adapter.Fill(Ds2, "TableProduct");
            return Ds2;

        }


    }
}
