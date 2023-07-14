using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace KYC
{
    public partial class kycform : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=kyc");

        SqlCommand command;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                try
                {

                    //string qr = "insert into TableKyc values(@fname,@lname,@username,@email,@password,@contact,@address,@addressdetails,@city,@state,@zipcode)";
                    //command = new SqlCommand(qr, con);
                    command = new SqlCommand("kycpro", con);
                    command.CommandType = CommandType.StoredProcedure;
                    string state = statecb.SelectedValue.ToString();

                    command.Parameters.AddWithValue("@fname", TextBox1.Text);
                    command.Parameters.AddWithValue("@lname", TextBox2.Text);
                    command.Parameters.AddWithValue("@username", TextBox3.Text);
                    command.Parameters.AddWithValue("@email", TextBox4.Text);
                    command.Parameters.AddWithValue("@password", TextBox5.Text);
                    command.Parameters.AddWithValue("@contact", TextBox6.Text);
                    command.Parameters.AddWithValue("@address", TextBox7.Text);
                    command.Parameters.AddWithValue("@addressdetails", TextBox8.Text);
                    command.Parameters.AddWithValue("@city", TextBox9.Text);
                    command.Parameters.AddWithValue("@state", state);
                    command.Parameters.AddWithValue("@zipcode", TextBox10.Text);



                    con.Open();
                    command.ExecuteNonQuery();
                    // con.Close();
                    Label1.Text = "kyc registration successfull";
                }
                catch (Exception ee)

                {
                    Label1.Text = ee.ToString();

                }
                finally
                {
                    con.Close();
                }
                

            }
            clearall();

        }
        public void clearall()
        {
            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;
            TextBox3.Text = string.Empty;
            TextBox4.Text = string.Empty;
            TextBox5.Text = string.Empty;
            TextBox6.Text = string.Empty;
            TextBox7.Text = string.Empty;
            TextBox8.Text = string.Empty;
            TextBox9.Text = string.Empty;
            TextBox10.Text = string.Empty;



        }
    }
}