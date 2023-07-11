using insertedrecodusing_jason.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace insertedrecodusing_jason.Controllers
{
    public class HomeController : Controller
    {

        private SqlConnection con;
        private void connection()
        {
            string constr = "server=.\\sqlexpress;integrated security=true;database=jason";
            con = new SqlConnection(constr);
        }
        public ActionResult Index()
        {
            return View();
        }



        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(EmpModel emp)
        {
            Adddetails(emp);
            return View();
        }

        private void Adddetails(EmpModel emp)
        {
            connection();

            SqlCommand cmd = new SqlCommand("AddEmp1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", emp.Name);
            cmd.Parameters.AddWithValue("@City", emp.City);
            cmd.Parameters.AddWithValue("@Address", emp.Address);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        [HttpPost]
        public ActionResult UpdateEmployee(EmpModel obj)
        {
            UpdateDetails(obj);

            return View();
        }
        [HttpPost]
        private void UpdateDetails(EmpModel obj)
        {
            connection();
            SqlCommand com = new SqlCommand("UpdateEmp", con);
            //addemp is the name of stored procedure
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Name", obj.Name);
            com.Parameters.AddWithValue("@City", obj.City);
            com.Parameters.AddWithValue("@Address", obj.Address);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

        }
        [HttpPost]
        public ActionResult DeleteeEmployee(EmpModel obj)
        {
            DeleteDetails(obj);

            return View();
        }
        [HttpPost]
        private void DeleteDetails(EmpModel obj)
        {
            connection();
            SqlCommand com = new SqlCommand("DeleteEmp2", con);
            //addemp is the name of stored procedure
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Name", obj.Name);
            //com.Parameters.AddWithValue("@City", obj.City);
            //com.Parameters.AddWithValue("@Address", obj.Address);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

        }

    }
}