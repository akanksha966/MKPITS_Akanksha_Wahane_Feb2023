using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace meshosites
{
    public partial class _Default : Page
    {
        SqlConnection s=new SqlConnection("server=.\\sqlexpress;integrated security=true;database=mesho");
        SqlDataAdapter da;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                da=new SqlDataAdapter("select * from product", s);
                ds=new DataSet();
                da.Fill(ds,"product");
                //show datalist
                DataList1.DataSource = ds.Tables["product"].DefaultView;
                DataList1.DataBind();
            }
        }
    }
}