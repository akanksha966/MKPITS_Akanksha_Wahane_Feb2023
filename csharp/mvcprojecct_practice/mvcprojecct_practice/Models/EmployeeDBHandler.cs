using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace mvcprojecct_practice.Models
{
    public class EmployeeDBHandler
    {
        public SqlConnection con;
        private void connection()
        {
            string constr= ConfigurationManager.ConnectionStrings["comshop"].ToString();
            con=new SqlConnection(constr);      
        }

        public List<EmployeeModel>GetEmployees()
        {
            connection();
            List<EmployeeModel> emp = new List<EmployeeModel>();
            string query = "select * from EmployeeDetail";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt=new DataTable();
            con.Open();
            dataAdapter.Fill(dt);   
            con.Close();
            foreach(DataRow dr in dt.Rows)
            {
                emp.Add(new EmployeeModel
                {
                    Id = Convert.ToInt32(dr["ID"]),
                    EName = Convert.ToString(dr["EName"]),
                    Addres = Convert.ToString(dr["Addres"]),
                    date = Convert.ToDateTime(dr["Date"]),
                });
               



            }
            return emp;
        }

       public bool insertemployee(EmployeeModel model)
        {
            connection();
            string query = "insert into EmployeeDetail values('" + model.EName + "','" + model.Addres + "','" + model.date + "')";
           SqlCommand cmd=new SqlCommand(query, con);   
           con.Open();
            int i=cmd.ExecuteNonQuery();
            con.Close() ;
            if(i>=1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool updateemployee(EmployeeModel model)
        {
            connection() ;
            string query = "update  EmployeeDetail set EName= '" + model.EName + "',Addres ='" + model.Addres + "' where ID='" + model.Id + "'";
            SqlCommand cmd=new SqlCommand (query, con); 
            con.Open();
            int i=cmd.ExecuteNonQuery();
            con.Close();
            if(i>=1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool deleteitem(EmployeeModel model)
        {
            connection();
            string query = "delete from EmployeeDetail where id='" + model.Id + "'";
            SqlCommand cmd=new SqlCommand(query,con);
            con.Open();
            int i=cmd.ExecuteNonQuery();    
            con.Close();
            if(i>=1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        

    }
    
}