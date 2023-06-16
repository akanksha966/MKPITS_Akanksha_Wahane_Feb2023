using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace storelibrary
{
    public static class ItemClass
    {
       static SqlConnection conn=Dbconnection.GetConnection();
        static SqlCommand cmd=null;
        static string query = null;
        public static string insertrecord(string itemname,string category,int rate,int balancequantity)
        {
            string res = null;
            try
            {
                query = "insert into Item_Masters values(@itemname,@category,@rate,@balancequantity)";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@itemname",itemname);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@rate", rate);
                cmd.Parameters.AddWithValue("@balancequantity", balancequantity);

                conn.Open();
                cmd.ExecuteNonQuery();
                res = "record saves successfully";
            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }
            finally
            {
                conn.Close();
            }
            return res;
        }


        //////////////////////////////////
        //get departmentid
        public static string itemid()
        {

            string res = null;
            try
            {
                query = "select max(Item_Id) from Item_Masters";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                int itemid = Convert.ToInt32(cmd.ExecuteScalar());
                res = itemid.ToString();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }
            finally { conn.Close(); }
            return res;
        }
        public static string updaterecord(string Item_Name,int Rate,int Balance_Quantity, int Item_Id)
        {

            string res = null;
            //check whether the vendorid exists or not
            string query = "select count(*) from Item_Masters where Item_Id=@itemid";
            cmd = new SqlCommand(query, conn);
            //cmd.Parameters.AddWithValue("@itemname",Item_Name);
            //cmd.Parameters.AddWithValue("@category",Category);
            //cmd.Parameters.AddWithValue("@Rate", Rate);
            //cmd.Parameters.AddWithValue("@balancequantity", Balance_Quantity);
            cmd.Parameters.AddWithValue("@itemid", Item_Id);




            conn.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            if (count > 0)
            {

                try
                {
                    query = "update Item_Masters set Item_Name=@itemname,Rate=@Rate,Balance_Quantity=@balancequantity where Item_Id=@itemid";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@itemname",Item_Name);
                    cmd.Parameters.AddWithValue("@Rate", Rate);
                    cmd.Parameters.AddWithValue("@balancequantity", Balance_Quantity);
                    cmd.Parameters.AddWithValue("@itemid", Item_Id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    res = "updated successfully";


                }
                catch (Exception ex)
                {
                    res = ex.ToString();
                }
                finally { conn.Close(); }
            }
            else
            {
                res = "unable to update";
            }

            return res;





        }

        ////////////////////////
        public static string delete( int Item_Id)
        {

            string res = null;
            //check whether the vendorid exists or not
            string query = "select count(*) from Item_Masters where Item_Id=@itemid";
            cmd = new SqlCommand(query, conn);
            //cmd.Parameters.AddWithValue("@itemname",Item_Name);
            //cmd.Parameters.AddWithValue("@category",Category);
            //cmd.Parameters.AddWithValue("@Rate", Rate);
            //cmd.Parameters.AddWithValue("@balancequantity", Balance_Quantity);
            cmd.Parameters.AddWithValue("@itemid", Item_Id);




            conn.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            if (count > 0)
            {

                try
                {
                    query = "delete from Item_Masters where Item_Id=@itemid";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@itemid", Item_Id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    res = "deleted successfully";


                }
                catch (Exception ex)
                {
                    res = ex.ToString();
                }
                finally { conn.Close(); }
            }
            else
            {
                res = "unable to delete";
            }

            return res;





        }


        public static DataSet serch(int Item_Id)
        {
            query = "select * from Item_Masters where Item_Id=@Item_Id ";
            DataSet ds = new DataSet();
            SqlDataAdapter dr = new SqlDataAdapter(query, conn);
            dr.SelectCommand.Parameters.AddWithValue("@Item_Id", Item_Id);
            dr.Fill(ds, " Item_Masters");
            return ds;

        }
        

    }
}
