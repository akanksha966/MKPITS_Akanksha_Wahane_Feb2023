using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace execute_and_methods
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           string n = Request.QueryString["name"].ToString();
            Response.Write("name is " + n);
            Response.Write("<br>");


            string nn = Request.QueryString["name"].ToString();
            Response.Write("name is " + nn);
            Response.Write("<br>");

        }
    }
}