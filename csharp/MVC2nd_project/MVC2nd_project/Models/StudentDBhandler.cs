using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MVC2nd_project.Models
{
    public class StudentDBhandler
    {
        public SqlConnection con;
        private void connection()
        {


            string constring = ConfigurationManager.ConnectionStrings["CompShopConString"].ToString();
            con = new SqlConnection(constring);

        }



        public List<StudentModel> GetStudents()
        {
            connection();
            List<StudentModel> list = new List<StudentModel>();
            string query = "select * from StudentDetail";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            adapter.Fill(dt);
            con.Close();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new StudentModel
                {
                    ID = Convert.ToInt32(dr["ID"]),
                    SName = Convert.ToString(dr["SName"]),
                    Address = Convert.ToString(dr["Address"]),
                    City = Convert.ToString(dr["City"]),
                    Course = Convert.ToString(dr["Course"]),
                    AddmissionFee = Convert.ToInt32(dr["Fees"]),
                    Duration = Convert.ToString(dr["Duration"]),
                    date = Convert.ToDateTime(dr["AdmissionDate"]),
                    phoneno = Convert.ToInt32(dr["phoneno"])



                });

            }
            return list;
        }
        public bool StudentList(StudentModel student)
        {
            connection();
            string query = "insert into StudentDetail  values('" + student.SName + "','" + student.Address + "','" + student.City + "','" + student.Course + "','" + student.AddmissionFee + "','" + student.Duration + "','" + student.date + "','" + student.phoneno + "')";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool studentupdate(StudentModel student)
        {
            connection();
            string query = "update StudentDetail set SName=' " + student.SName + " ', Duration= '" + student.Duration + "',Course='" + student.Course + "' where id = '" + student.ID+"'";
            SqlCommand cmd=new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool DeleteItem(StudentModel model)
        {
            connection();

            string query = "delete from StudentDetail where id= '" + model.ID + "'";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
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
