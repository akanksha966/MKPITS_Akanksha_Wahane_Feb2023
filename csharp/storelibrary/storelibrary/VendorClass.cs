using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace storelibrary
{
   public static class VendorClass
    {
        static SqlConnection s = Dbconnection.GetConnection();
        static string query = null;
        static SqlCommand cmd = null;
        //method too insert record in vendor table
        public static string insertvendor_master(string Vendor_Name)
        {
            string res = null;
            try
            {
                query="insert into Vendor_Master values(@Vendor_Name)";
                cmd = new SqlCommand(query, s);
                cmd.Parameters.AddWithValue("@Vendor_Name",Vendor_Name);
                s.Open();
                cmd.ExecuteNonQuery();
                res = "record saved successfully";


            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }
            finally { 
                s.Close(); 
            }  
            return res;
        }
        //method to return vendorid
        public static string getvendorid()
        {
            string res=null;


                try
                {
                    query = "select max(Vendor_Id)from Vendor_Master";
                    cmd = new SqlCommand(query, s);
                    s.Open();
                    int vendorid = Convert.ToInt32(cmd.ExecuteScalar());
                    res = vendorid.ToString();
                }
                catch (Exception ex)
                {
                    res = ex.ToString();
                }
                finally
                {
                    s.Close();
                }
            return res;
                
           
        }
        //method to update record in vendor table
        public static string updatevendor( string Vendor_Name, int Vendor_Id) 
        {
            string res2 = null;
            //check whether the vendorid exists or not
            query = "select count(*) from Vendor_Master where Vendor_Id=@Vendor_Id ";
            cmd = new SqlCommand(query, s);
            cmd.Parameters.AddWithValue("@Vendor_Id", Vendor_Id);
            s.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            s.Close();
            if (count > 0)
            {

                try
                {

                    query = "update Vendor_Master set Vendor_Name=@Vendor_Name where Vendor_Id=@Vendor_Id ";
                    cmd = new SqlCommand(query, s);
                    cmd.Parameters.AddWithValue("@Vendor_Name", Vendor_Name);
                    cmd.Parameters.AddWithValue("@Vendor_Id", Vendor_Id);
                    s.Open();
                    cmd.ExecuteNonQuery();
                    res2 = "record updated in vendor master successfully";
                }
                catch (Exception ex)
                {

                    res2 = ex.ToString();
                }
                finally { s.Close(); }
            }
            else
            {
                res2 = "unable to update";
            }

            return res2;




        }

        public static string deleted( int Vendor_Id)
        {
            string res2 = null;
            //check whether the vendorid exists or not
            query = "select count(*) from Vendor_Master where Vendor_Id=@Vendor_Id ";
            cmd = new SqlCommand(query, s);
            cmd.Parameters.AddWithValue("@Vendor_Id", Vendor_Id);
            s.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            s.Close();
            if (count > 0)
            {

                try
                {

                    query = "delete from Vendor_Master where Vendor_Id=@Vendor_Id ";
                    cmd = new SqlCommand(query, s);
                    cmd.Parameters.AddWithValue("@Vendor_Id", Vendor_Id);
                    s.Open();
                    cmd.ExecuteNonQuery();
                    res2 = "record deleted in vendor master successfully";
                }
                catch (Exception ex)
                {

                    res2 = ex.ToString();
                }
                finally { s.Close(); }
            }
            else
            {
                res2 = "unable to deleted";
            }

            return res2;




        }
        //method to search record in vendor masters
        public static DataSet searchvendor( int Vendor_Id)
        {
            query = "select * from  Vendor_Master where Vendor_Id=@Vendor_Id ";
            DataSet set = new DataSet();
            SqlDataAdapter dr=new SqlDataAdapter(query,s);
            dr.SelectCommand.Parameters.AddWithValue("@Vendor_Id", Vendor_Id);
            dr.Fill(set,"Vendor_Master");
            return set; 
        }





    }


}
                
    
        

    

