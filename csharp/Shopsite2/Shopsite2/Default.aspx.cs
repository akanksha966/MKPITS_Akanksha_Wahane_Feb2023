using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shopsite2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            //create new sqlconnection and connection to database by using connection string from web.config file
            SqlConnection con = new SqlConnection(strcon);
            string str = "select * from Product1";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            da.Fill(ds, "Product1");

            DataList1.DataSource = ds.Tables["Product1"];
            DataList1.DataBind();
            // Response.Write("connected");

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            ImageButton Button1 = (ImageButton)sender;

           
            DataListItem item = (DataListItem)Button1.Parent;
            //find controls in the parent

            Label l = (Label)item.FindControl("lblprodid");
            // Response.Write(l.Text);
            string pid = l.Text;
            Response.Redirect("proddetails.aspx?prodid=" + pid);

        }


        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {

        }


        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}