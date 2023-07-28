using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Shopsite2
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            //create new sqlconnection and connection to database by using connection string from web.config file
            SqlConnection con = new SqlConnection(strcon);
            string str = "select * from users where username=@username and password=@password";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@username", TextBox1.Text);
            command.Parameters.AddWithValue("@password", TextBox2.Text);
            con.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Session["username"] = dr["username"].ToString();
                    string r = dr["roll"].ToString();
                    if (r == "user")
                    {
                        Response.Redirect("default.aspx");
                    }
                    else if (r == "admin")
                    {
                        Response.Redirect("admindashboard.aspx");
                    }
                }

            }
            else
            {
                Label1.Text = "invalid username or password try again";
            }
            con.Close();

        }
    }
}