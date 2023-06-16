using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel.Design;

namespace storelibrary
{
    public static class DepartmentClass
    {
      static SqlConnection conn=Dbconnection.GetConnection();
        static SqlCommand cmd=null;
        static string query = null;
        public static string insertrecord(string departmentname)
        {
            string res = null;
            try
            {
                query = "insert into  Department_Master values(@departmentname)";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@departmentname", departmentname);
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
        //get departmentid
        public static string departmentid() {

            string res = null;
            try
            {
                query = "select max( Department_Id) from Department_Master";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                int departmentid = Convert.ToInt32(cmd.ExecuteScalar());
                res=departmentid.ToString();        
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                res=ex.ToString();
            }
            finally { conn.Close(); }
            return res;
        }
        public static string updaterecord(string Depatment_Name,int Department_Id)
        {

            string res = null;
            //check whether the vendorid exists or not
            string query = "select count(*) from Department_Master where Department_Id=@Department_Id";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Department_Id", Department_Id);
            conn.Open();
               int count=Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            if (count > 0)
            {

                try
                {
                    query = "update Department_Master set Depatment_Name=@Depatment_Name where Department_Id = @Department_Id ";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Depatment_Name", Depatment_Name);
                    cmd.Parameters.AddWithValue("@Department_Id", Department_Id);
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

        public static string deleterecord( int Department_Id)
        {

            string res = null;
            //check whether the vendorid exists or not
            string query = "select count(*) from Department_Master where Department_Id=@Department_Id";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Department_Id", Department_Id);
            conn.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            if (count > 0)
            {

                try
                {
                    query = "delete from  Department_Master where Department_Id = @Department_Id ";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Department_Id", Department_Id);
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
        public static DataSet serch( int Department_Id)
        {
            query = "select * from Department_Mastes where Department_Id=@Department_Id ";
            DataSet ds=new DataSet();
            SqlDataAdapter dr=new SqlDataAdapter(query, conn);
            dr.SelectCommand.Parameters.AddWithValue("@Department_Id", Department_Id);
            dr.Fill(ds, "Deoartment_Masters");
            return ds;

        }
    }
}
