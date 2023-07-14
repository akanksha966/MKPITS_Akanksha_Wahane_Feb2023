using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace FendhalM1
{
    public static class ProductStore
    {
        private static string connection = "server=.\\sqlexpress;integrated security=true;database=fendhal";
        public static SqlConnection GetConnection()

        {
            SqlConnection Con = new SqlConnection(connection);
            try
            {
                //Con.Open();
                return Con;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static DataSet GetTableProductCategory()
        {
            SqlConnection Con = GetConnection();
            string Query = "select * from TableProductCategory ";
            DataSet Ds = new DataSet();
            SqlDataAdapter Da = new SqlDataAdapter(Query, Con);
            Da.Fill(Ds, "TableProductCategory");
            return Ds;

        }

    }
}
