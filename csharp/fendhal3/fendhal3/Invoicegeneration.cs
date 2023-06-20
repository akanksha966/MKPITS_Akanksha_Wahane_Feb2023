using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Security.Principal;

namespace fendhal3
{
    public static class Invoicegeneration
    {
        private static string connection = "server=.\\sqlexpress;integrated security=true;database=Perficient;";
        public static SqlConnection GetConnection()
        {
            SqlConnection s=new SqlConnection(connection);
            try
            {
                return s;
            }
            catch { return null; }
        }
        public static DataSet getname()
        {
            SqlConnection s = GetConnection();
            string query = "select Name from COMPUTER";
            DataSet ds = new DataSet();
            SqlDataAdapter da= new SqlDataAdapter(query,s);    
            da.Fill(ds,"COMPUTER");
            return ds;  

        }
        public static DataSet getproductname(string Name) { 

            SqlConnection s = GetConnection();
            string query = "select * from COMPUTER where NAME=@Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da= new SqlDataAdapter( query,s);
            da.SelectCommand.Parameters.AddWithValue("@Name", Name);
            da.Fill(ds, "COMPUTER");
            return ds;
        }
        public static DataSet getcgst(string Name)
        {
            SqlConnection s = GetConnection();
            string query = "  select CGST,SGST from computer where Name=@Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da= new SqlDataAdapter(query,s);
            da.SelectCommand.Parameters.AddWithValue("@Name", Name);
            da.Fill(ds, "COMPUTERS");
            return ds;
        }

        //        CREATE TABLE CUSTOMER(ID INT PRIMARY KEY IDENTITY, FIRST_NAME VARCHAR(30),
        //            LAST_NAME VARCHAR(30),GENDER VARCHAR(10),
        //MOBILE VARCHAR(20),PAID_AMOUNT DECIMAL)
        public static string getcustomer(string Name,string Lname,string gender,string mobileno,decimal paid_amount) { 

            SqlConnection s = GetConnection();
            s.Open();
            string query = "insert into CUSTOMER values(@name,@lname,@gender,@mobileno,@paidamount)";
            SqlCommand cmd=new SqlCommand(query,s);
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@lname", Lname);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@mobileno", mobileno);
            cmd.Parameters.AddWithValue("@paidamount", paid_amount);
            cmd.ExecuteNonQuery();
            s.Close();

            return "inserted record successfully";
           

        }
        //  CREATE TABLE REF_SELLING(ID INT IDENTITY, CUSTOMER_ID INT, COMPUTER_ID INT, SELL_DATE DATE, SELL_QTY INT,
        //SOLD_BY_PERSON VARCHAR(50),PAYMENT_MODE VARCHAR(15),PAID_AMOUNT DECIMAL, CGST_VALUE decimal,SGST_VALUE decimal,TOTAL_AMOUNT decimal,
        public static string refselling(int customerid, int computerid, DateTime selldate, int sellqty, string soldperson, string paymentmode, decimal paidamount, decimal cgstvalue, decimal sgstvalue, decimal totalamount)
        {
            SqlConnection s = GetConnection();
            s.Open();
            try
            {
                string query = "insert into REF_SELLING values(@customerid,@computerid,@date,@sellqty,@soldperson,@paymentmode,@paidamount,@cgstvalue,@sgdtvalue,@totalamount)";
                SqlCommand c = new SqlCommand(query, s);
                c.Parameters.AddWithValue("@customerid", customerid);
                c.Parameters.AddWithValue("@computerid", computerid);
                c.Parameters.AddWithValue("@date", selldate);
                c.Parameters.AddWithValue("@sellqty", sellqty);
                c.Parameters.AddWithValue("@soldperson", soldperson);
                c.Parameters.AddWithValue("@paymentmode", paymentmode);
                c.Parameters.AddWithValue("@paidamount", paidamount);
                c.Parameters.AddWithValue("@cgstvalue", cgstvalue);
                c.Parameters.AddWithValue("@sgstvalue", sgstvalue);
                c.Parameters.AddWithValue("@totalamount", totalamount);
                c.ExecuteNonQuery();
               // s.Close();
               // return "inserted record successfully";
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally { s.Close(); }
            return  "insert successfully";
         
        }
    }
}
