using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace DrivenItProject
{
    public partial class Item : System.Web.UI.Page
    {
        SqlConnection s = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=drivenit");

        SqlCommand cmd = null;
        string query = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {


                query = "insert into Itemmaster values(@itemdescription,@balqty,@createddate)";
                cmd = new SqlCommand(query,s);
                cmd.Parameters.AddWithValue("@itemdescription", DropDownList1.SelectedValue);
                cmd.Parameters.AddWithValue("@balqty", Convert.ToInt32(TextBox1.Text));
                cmd.Parameters.AddWithValue("@createddate", TextBox2.Text);
                s.Open();
                cmd.ExecuteNonQuery();
                Label1.Text = "insert successfully";


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
                query = "update Itemmaster set BalQty=@BalQty where ItemDescr=@ItemDescr";
                cmd=new SqlCommand(query,s);
                cmd.Parameters.AddWithValue("@BalQty", Convert.ToInt32(TextBox1.Text));
                cmd.Parameters.AddWithValue("@ItemDescr",DropDownList1.SelectedValue);
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
                query = "delete from Itemmaster where ItemDescr=@ItemDescr";
                cmd = new SqlCommand(query, s);
                cmd.Parameters.AddWithValue("@ItemDescr", DropDownList1.SelectedValue);
                s.Open();
                cmd.ExecuteNonQuery();
                Label1.Text = "delete successfully";


            }
            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }
            finally { s.Close(); }
        }
    }
    }
