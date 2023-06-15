using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace TrustProject2
{
    public partial class productdetails : System.Web.UI.Page
    {
        SqlConnection s = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=civica");
        DataSet ds = new DataSet();
        SqlDataAdapter dr = new SqlDataAdapter();
        string query = null;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            query = "insert into  Item_Masters values(@itemname,@category,@rate,@balancequantity)";
            SqlCommand cmd = new SqlCommand(query, s);
            cmd.Parameters.AddWithValue("@itemname",TextBox4.Text);
            cmd.Parameters.AddWithValue("@category", DropDownList1.SelectedValue);

            cmd.Parameters.AddWithValue("@rate", Convert.ToInt32(TextBox3.Text));
            cmd.Parameters.AddWithValue("@balancequantity", Convert.ToInt32(TextBox2.Text));

            s.Open();
            cmd.ExecuteNonQuery();
            s.Close();
            Label1.Text = "inserted successfully";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            query = "update Item_Masters set Item_Name= @itemname,Balance_Quantity=@balancequantity,Rate=@rate where Category=@category";
            SqlCommand cmd = new SqlCommand(query, s);
            cmd.Parameters.AddWithValue("@itemname", TextBox4.Text);
            cmd.Parameters.AddWithValue("@balancequantity", Convert.ToInt32(TextBox2.Text));
            cmd.Parameters.AddWithValue("@rate", Convert.ToInt32(TextBox3.Text));
            cmd.Parameters.AddWithValue("@category", DropDownList1.SelectedValue);

            s.Open();
            cmd.ExecuteNonQuery();
            s.Close();
            Label1.Text = "updated successfully";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            query = "delete from Item_Masters where Category=@category";
            SqlCommand cmd = new SqlCommand(query, s);
            cmd.Parameters.AddWithValue("@itemname", TextBox4.Text);
            cmd.Parameters.AddWithValue("@balancequantity", Convert.ToInt32(TextBox2.Text));
            cmd.Parameters.AddWithValue("@rate", Convert.ToInt32(TextBox3.Text));
            cmd.Parameters.AddWithValue("@category", DropDownList1.SelectedValue);

            s.Open();
            cmd.ExecuteNonQuery();
            s.Close();
            Label1.Text = "deleted successfully";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            query = "select * from  Item_Masters where Item_Name=@itemname ";
            dr = new SqlDataAdapter(query, s);
            dr.SelectCommand.Parameters.AddWithValue("@itemname",TextBox4.Text);
            dr.Fill(ds, "Item_Masters");
            TextBox2.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            TextBox3.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();


        }
    }
}