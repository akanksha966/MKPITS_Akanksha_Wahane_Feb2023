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
                    Id = Convert.ToInt32(dr["Id"]),
                    Name = Convert.ToString(dr["Name"]),
                    Adreess = Convert.ToString(dr["Adreess"]),
                    date = Convert.ToDateTime(dr["date"]),
                });
               



            }
            return emp;
        }

       public bool insertemployee(EmployeeModel model)
        {
            connection();
            string query = "insert into EmployeeDetail values('" + model.Id + "','" + model.Name + "','" + model.Adreess + "','" + model.date + "')";
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

    }
}