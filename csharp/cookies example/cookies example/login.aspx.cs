using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cookies_example
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = Request.QueryString["t1"].ToString();
            string password  = Request.QueryString["t12"].ToString();
            Response.Write("username is " + username + "<br>");
            Response.Write("password is " + password + "<br>");
            if(username=="admin" && password=="admin")
            {
                Response.Redirect("dashboard.aspx");
            }
            else
            {
                Response.Redirect("HtmlPage1.html");
            }


        }
    }
}