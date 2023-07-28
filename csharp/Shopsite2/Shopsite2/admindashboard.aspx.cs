using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Shopsite2
{
    public partial class admindashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string imgname = "";
            if (FileUpload1.HasFile)
            {
                imgname = FileUpload1.FileName;
                ///upload file code
                FileUpload1.SaveAs(Server.MapPath("~/images/" + FileUpload1.FileName));
            }
            //Get connection string from web.config file
            string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            //create new sqlconnection and connection to database by using connection string from web.config file
            SqlConnection con = new SqlConnection(strcon);
            string str = "insert into  Product1 values(@prodname,@proddescription,@prodimage,@prodprice)";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@prodname", TextBox1.Text);
            command.Parameters.AddWithValue("@proddescription", TextBox2.Text);

            command.Parameters.AddWithValue("@prodimage", imgname);
            command.Parameters.AddWithValue("@prodprice", Convert.ToInt32(TextBox3.Text));


            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            TextBox1.Text = "";
            TextBox2.Text = "";
            Label2.Text = "product added successfully";
        }
    }
}