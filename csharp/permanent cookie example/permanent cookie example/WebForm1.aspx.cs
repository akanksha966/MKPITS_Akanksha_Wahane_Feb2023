using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace permanent_cookie_example
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //code to create temporary cookie
            HttpCookie cookie = new HttpCookie("cook1");
            cookie.Values.Add("username", TextBox1.Text);
            cookie.Values.Add("email",TextBox2.Text);
            DateTime dt= DateTime.Now;//server date
            TimeSpan ts=new TimeSpan(0,2,0);
            cookie.Expires= dt.Add(ts);
            Label1.Text = "permanent cookie added to client machine";
            Response.Cookies.Add(cookie);   

            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //code to retrieve cookie from client machine
            HttpCookie cookie = Request.Cookies[0];
            if(cookie != null)
            {
                string username= cookie.Values[" username "].ToString();
                string email = cookie.Values[" email "].ToString();
                Label1.Text = " username " +   username;
                Label2.Text= "  email /" +   email;

            }
            else
            {
                Label1.Text = "no permanent cookie exists";
            }
        }
    }
}