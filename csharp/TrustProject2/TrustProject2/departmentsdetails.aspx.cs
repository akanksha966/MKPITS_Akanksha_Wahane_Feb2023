using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection.Emit;

namespace TrustProject2
{
    public partial class departmentsdetails : System.Web.UI.Page
    {
        SqlConnection s = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=civica");
        DataSet ds = new DataSet();
        SqlDataAdapter dr = new SqlDataAdapter();
        string query = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            query = "insert into Department_Masterrs values(@Department_Id,@Depatment_Name)";
            SqlCommand cmd = new SqlCommand(query, s);
            cmd.Parameters.AddWithValue("@Department_Id", TextBox6.Text);
            cmd.Parameters.AddWithValue("@Depatment_Name", TextBox5.Text);


            s.Open();
            cmd.ExecuteNonQuery();
            s.Close();
            Label1.Text = "inserted successfully";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            query = "update Department_Masterrs set Depatment_Name=@Depatment_Name where Department_Id =@Department_Id ";
            SqlCommand cmd = new SqlCommand(query, s);
            cmd.Parameters.AddWithValue("@Department_Id", TextBox6.Text);
            cmd.Parameters.AddWithValue("@Depatment_Name",(TextBox5.Text));
            
            s.Open();
            cmd.ExecuteNonQuery();
            s.Close();
            Label1.Text = "updated successfully";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            query = "delete from Department_Masterrs where Department_Id =@Department_Id ";
            SqlCommand cmd = new SqlCommand(query, s);
            cmd.Parameters.AddWithValue("@Department_Id", TextBox6.Text);

            s.Open();
            cmd.ExecuteNonQuery();
            s.Close();
            Label1.Text = "deleted successsfully";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            query = "select * from  Department_Masterrs where Department_Id=@Department_Id ";
            dr = new SqlDataAdapter(query, s);
            dr.SelectCommand.Parameters.AddWithValue("@Department_Id", TextBox6.Text);

            dr.Fill(ds, "Department_Masterrs");
            TextBox5.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            Label1.Text = "Search Siccessfully";
        }
    }
}