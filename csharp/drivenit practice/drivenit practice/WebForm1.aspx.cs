using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
    

namespace drivenit_practice
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection s=new SqlConnection("server=.\\sqlexpress;integrated security=true;database=drivenit");
        SqlCommand cmd = null;
        string query = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            try
            {


                query = "insert into Itemmaster values(@ItemDescr,@BalQty,@CreatedOn)";
                cmd = new SqlCommand(query, s);
                cmd.Parameters.AddWithValue("@ItemDescr", DropDownList1.SelectedValue);
                cmd.Parameters.AddWithValue("@BalQty", Convert.ToInt32(TextBox1.Text));
                cmd.Parameters.AddWithValue("@CreatedOn", TextBox2.Text);
                s.Open();
                cmd.ExecuteNonQuery();
                Label1.Text = "inserted successfully";
            }
            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }
            finally { s.Close(); }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {


                query = "update  Itemmaster set BalQty=@BalQty where ItemDescr=@ItemDescr";
                cmd = new SqlCommand(query, s);
                cmd.Parameters.AddWithValue("@BalQty", Convert.ToInt32(TextBox1.Text));
                cmd.Parameters.AddWithValue("@ItemDescr", DropDownList1.SelectedValue);

                s.Open();
                cmd.ExecuteNonQuery();
                Label1.Text = "update successfully";
            }
            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }
            finally { s.Close(); }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {


                query = "delete from  Itemmaster where ItemDescr=@ItemDescr";
                cmd = new SqlCommand(query, s);
                cmd.Parameters.AddWithValue("@ItemDescr", DropDownList1.SelectedValue);

                s.Open();
                cmd.ExecuteNonQuery();
                Label1.Text = "deleted successfully";
            }
            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }
            finally { s.Close(); }
        }
    }
}