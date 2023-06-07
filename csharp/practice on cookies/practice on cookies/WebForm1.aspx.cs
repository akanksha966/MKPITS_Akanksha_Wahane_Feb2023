using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practice_on_cookies
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            HttpCookie cookie = new HttpCookie("cookie1");
            cookie.Values.Add("username" ,TextBox1.Text);
            cookie.Values.Add("address", TextBox2.Text);
            Response.Cookies.Add(cookie);
            Label1.Text = "temporary cookie stored";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies[0];
            if(cookie != null )
            {
                string username = cookie.Values["username"].ToString();
                string address = cookie.Values["address"].ToString();
                Label1.Text = username;
               Label2.Text = address;   
                
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            HttpCookie coo = new HttpCookie("cook2");
            coo.Values.Add("username" ,TextBox1.Text);
            coo.Values["address"] = TextBox2.Text;
            DateTime dt= DateTime.Now;
            TimeSpan s= new TimeSpan(0,3,0);
            coo.Expires=dt.Add(s);
            Response.Cookies.Add(coo);
            Label1.Text = "permanent data store";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            HttpCookie cookie= Request.Cookies[0];
            if(cookie != null )
            {
                string username = cookie.Values["username"].ToString();
                Label1.Text= username;

                string address = cookie.Values["address"].ToString(); 
                Label2.Text = address;
            }
        }
    }
}