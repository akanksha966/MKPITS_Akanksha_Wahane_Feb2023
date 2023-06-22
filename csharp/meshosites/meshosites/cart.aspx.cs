using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace meshosites
{
    public partial class cart : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=mesho");
        SqlDataAdapter da;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            string prodid = Request.QueryString["prodid"].ToString();
            Session["prodid"]=prodid;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("checkmobile.aspx");
        }
    }
}