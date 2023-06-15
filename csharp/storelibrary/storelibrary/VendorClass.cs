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
            string res = null;
            try
            {
                query = "select max(Vendor_Id)from Vendor_Master";
                cmd = new SqlCommand(query, s);
                s.Open();
                int vendorid = Convert.ToInt32(cmd.ExecuteScalar());
                res = vendorid.ToString();
            }
            catch(Exception ex)
            {
                res=ex.ToString();
            }
            finally { 
                s.Close();
            }
            return res;
        }
        public static string updatevendor( string Vendor_Name, int Vendor_Id) 
        {
            string abc = null;
           
            try
            {
               
                query = "update Vendor_Master set Vendor_Name=@Vendor_Name where Vendor_Id=@Vendor_Id ";
                cmd = new SqlCommand(query, s);
                cmd.Parameters.AddWithValue("@Vendor_Name",Vendor_Name);
                cmd.Parameters.AddWithValue("@Vendor_Id",Vendor_Id);
                s.Open();
                cmd.ExecuteNonQuery();
                abc = "record updated in vendor master successfully";
            }
            catch(Exception ex)
            { 

              abc= ex.ToString();
            }
            finally { s.Close(); }

            return abc;




        }


       
}
   

    }
                
    
        

    

