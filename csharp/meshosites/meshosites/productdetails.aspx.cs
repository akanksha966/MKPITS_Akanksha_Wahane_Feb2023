using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Newtonsoft.Json;

namespace meshosites
{
    public partial class productdetails : System.Web.UI.Page
    {
        SqlConnection con=new SqlConnection("server=.\\sqlexpress;integrated security=true;database=mesho");
        SqlDataAdapter da;
        DataSet ds;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string proid = Request.QueryString["prodid"].ToString();
           // Response.Write(proid);
            da = new SqlDataAdapter("select * from product where prodid=@prodid", con);
            da.SelectCommand.Parameters.AddWithValue("prodid", proid);
            ds = new DataSet();
            da.Fill(ds,"productdetails");
            //Response.Write(ds.Tables[0].Rows[0].ItemArray[1].ToString());
            DataList1.DataSource = ds.Tables["productdetails"].DefaultView;
            DataList1.DataBind();


          
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}