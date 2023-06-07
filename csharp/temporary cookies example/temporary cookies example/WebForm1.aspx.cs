using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace temporary_cookies_example
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //code to create temporary cookie
            HttpCookie cookie = new HttpCookie("cook");
            cookie.Values.Add("username",TextBox1.Text);
            Response.Cookies.Add(cookie);
            Label1.Text = "temporary cookie added to client machine";


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //code to retrieve cookie from client machine
            HttpCookie cookie1 = Request.Cookies["cook"];
            if (cookie1 != null)
            {
                string username = cookie1.Values["username"].ToString();
                Label1.Text = "username"+username;

            }
            else
            {
                Label1.Text = "no cookies exists";
            }
        }
    }
}