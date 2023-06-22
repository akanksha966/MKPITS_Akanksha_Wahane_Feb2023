using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace meshosites
{
    public partial class checkmobile : System.Web.UI.Page
    {
        string prodid;
        SqlConnection con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=mesho");
        SqlCommand command;
        string query;

        protected void Page_Load(object sender, EventArgs e)
        {
            prodid = Convert.ToString(Session["Prodid"]);
            Response.Write("Prodid is"+prodid); 
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string res = TextBox1.Text;
            string prodname = null;
            int prodprice = 0;
            int qty = 0;
            string sessionid = null;
            if(res=="935910") 
            {
                query = "select * from product where Prodid=@Prodid";
                command =new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Prodid", prodid);
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                while(dr.Read())
                {
                    prodname = dr["prodname"].ToString();
                    prodprice = Convert.ToInt32(dr["prodprice"].ToString());
                    qty = 1;
                    sessionid = Session.SessionID;
                }
                con.Close();
                Response.Write("prodname " + prodname + "<br>");
                Response.Write("prod price " + prodprice + "<br>");
                Response.Write("qty " + qty + "<br>");
                Response.Write("session id " + sessionid + "<br>");
                //save the product data into carttable
               // Response.Redirect("cart1.aspx");


            }
            else
            {
                Label1.Text = "invalid otp";
            }
        }
    }
}