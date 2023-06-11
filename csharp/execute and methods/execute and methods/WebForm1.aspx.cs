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
    }
}