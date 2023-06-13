using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace execute_and_methods
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("hello from webform1 page" +"<br>");
            Server.Execute("webform2.aspx");
            Response.Write("welcome back to webform1 page");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write("hello from webform1 page" + "<br>");
            Server.Transfer("webform2.aspx");
            Response.Write("welcome back to webform1 page");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Write(Server.HtmlEncode("<h1> is an example of a heading tag </h1>" +"<br>"));

            ///////////////////or withut using htmlencode 
            Response.Write("<h1> is an example of a heading tag </h1> " + "<br>");


        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Write(Server.UrlEncode("http://localhost/code/map.aspx" +"<br>" + "<br>"));

            ////////////////or     without using urlencode
            Response.Write("http://localhost/code/map.aspx" + "<br>");

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string name = Server.UrlEncode("ashu wahane");
            Response.Redirect("WebForm3.aspx?name= " + name);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string name = ("akanksha wahane");
            Response.Redirect("WebForm3.aspx?name= " + name);
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            string name2 = Server.UrlEncode("ashu wahane");
            Response.Redirect("WebForm3.aspx?name=" +name2);
            //string password2 = Server.UrlEncode("ashu");

            //Response.Redirect("WebForm3.aspx?password=" + password2);


        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Write("<br>");
            Response.Write(Server.MapPath("WebForm3.aspx"));
        }
    }
}