using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Reflection.Emit;
using System.Diagnostics.Eventing.Reader;

namespace storelibrary
{
    public static class TransactionClass
    {
        static SqlConnection conn = Dbconnection.GetConnection();
        static SqlCommand cmd = null;
        static string query = null;
        public static string inserted(int itemid, DateTime transactiondate, int departmentid, int quantity)
        {
            string res = null;



            try
            {

                query = "insert into Item_Transaction1(item_id,transaction_date,department_id,quantity) values(@item_id,@transaction_date,@department_id,@quantity)";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@item_id", itemid);
                cmd.Parameters.AddWithValue("@transaction_date", transactiondate);
                cmd.Parameters.AddWithValue("@department_id", departmentid);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                int bal_qty = 0;
                query = "select Balance_Quantity from Item_Masters where Item_Id=@Item_Id ";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Item_Id", itemid);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())//dr open
                {
                    bal_qty = Convert.ToInt32(dr[0].ToString());

                }
                dr.Close();//datareader closed
                conn.Close();//connection close
                int qty = bal_qty - quantity;
                query = "update Item_Masters set Balance_Quantity=@Balance_Quantity where Item_Id=@Item_Id";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Balance_Quantity", qty);
                cmd.Parameters.AddWithValue("@Item_Id", itemid);
                conn.Open();
                cmd.ExecuteNonQuery();
                res = "item issued to department successfully";
            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }
            finally { conn.Close(); }

            return res;
        }
           




        


        //purchase
        public static string purinserted(int itemid, DateTime transactiondate, int vendorid, int quantity)
        {
            string res = null;



            try
            {

                query = "insert into Item_Transaction1(item_id,transaction_date,vendor_id,quantity) values(@item_id,@transaction_date,@vendor_id,@quantity)";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@item_id", itemid);
                cmd.Parameters.AddWithValue("@transaction_date", transactiondate);
                cmd.Parameters.AddWithValue("@vendor_id", vendorid);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                int bal_qty = 0;
                query = "select Balance_Quantity from Item_Masters where Item_Id=@Item_Id ";

                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Item_Id", itemid);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())//dr open
                {
                    bal_qty = Convert.ToInt32(dr[0].ToString());

                }
                dr.Close();//datareader closed
                conn.Close();//connection close
                int qty = bal_qty + quantity;
                query = "update Item_Masters set Balance_Quantity=@Balance_Quantity where Item_Id=@Item_Id";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Balance_Quantity", qty);
                cmd.Parameters.AddWithValue("@Item_Id", itemid);
                conn.Open();
                cmd.ExecuteNonQuery();
                res = "item issued to vendor successfully";
            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }
            finally { conn.Close(); }

            return res;





        }
    }


    }

