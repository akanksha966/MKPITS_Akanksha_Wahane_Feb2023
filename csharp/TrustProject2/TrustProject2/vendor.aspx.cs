using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace TrustProject2
{
    public partial class vendor : System.Web.UI.Page
    {
        SqlConnection s = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=civica");

        DataSet ds =new DataSet();
          SqlDataAdapter dr=new SqlDataAdapter();
        string query = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string query = "insert into Vendor_Masters values(@vendorid,@vendorname)";
             SqlCommand cmd = new SqlCommand(query,s);
            cmd.Parameters.AddWithValue("@vendorid",Convert.ToInt32(TextBox1.Text));
            cmd.Parameters.AddWithValue("@vendorname",(TextBox2.Text));

            s.Open();
            cmd.ExecuteNonQuery();
            s.Close();
            Label1.Text = "inserted suuccessfully";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string query = "update Vendor_Masters set Vendor_Name=@Vendor_Name where Vendor_Id=@Vendor_Id";
            SqlCommand cmd=new SqlCommand(query,s);
            cmd.Parameters.AddWithValue("Vendor_Name",TextBox2.Text);
            cmd.Parameters.AddWithValue("Vendor_Id", Convert.ToInt32(TextBox1.Text));
            s.Open();
            cmd.ExecuteNonQuery();
            s.Close();
            Label1.Text = "updated successfully";

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string query = "delete from Vendor_Masters where Vendor_Id=@Vendor_Id ";
            SqlCommand c = new SqlCommand(query,s);
            c.Parameters.AddWithValue("@Vendor_Id", Convert.ToInt32(TextBox1.Text));
            s.Open();
            c.ExecuteNonQuery();
            s.Close();
            Label1.Text ="deleted successfully";

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            query = "select  * from  Vendor_Masters where Vendor_Id=@Vendor_Id";
            dr = new SqlDataAdapter(query, s);
            dr.SelectCommand.Parameters.AddWithValue("@Vendor_Id", TextBox1.Text);

            dr.Fill(ds, "Vendor_Masters");
            TextBox2.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            Label1.Text = "Search Successfully";
        }
    }
}