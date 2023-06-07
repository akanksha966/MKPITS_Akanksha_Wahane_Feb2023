using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace querystringexample_using_asp
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //code to retrieve query string value //jo uname query me dale hai vo 
            string username = Request.QueryString["uname"].ToString();
            Label1.Text = username;// string username 
        }
    }
}