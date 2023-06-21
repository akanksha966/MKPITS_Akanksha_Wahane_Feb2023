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
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection s=new SqlConnection("server=.\\sqlexpress;integrated security=true;database=drivenit");
        SqlCommand cmd = null;
        string query = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {


                query = "insert into Transaction1 values(@ItemId,@TransType,@TransQty,@TransDate)";
                cmd = new SqlCommand(query, s);
                cmd.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);
                string transaction = null;

                if (RadioButton1.Checked)
                {
                    transaction = "I";
                }
                else if (RadioButton2.Checked)
                {
                    transaction = "R";
                }
                cmd.Parameters.AddWithValue("@TransType", transaction);
                cmd.Parameters.AddWithValue("@TransQty", Convert.ToInt32(TextBox1.Text));
                cmd.Parameters.AddWithValue("@TransDate", TextBox2.Text);
                s.Open();
                cmd.ExecuteNonQuery();
                query = "select max (BalQty) from Itemmaster where ItemId=@ItemId";
                cmd = new SqlCommand(query, s);
                cmd.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);
                int balanceqty=Convert.ToInt32(cmd.ExecuteScalar());    
                if(transaction=="I")
                {
                    balanceqty = balanceqty - Convert.ToInt32(TextBox1.Text);

                }

                else if (transaction == "R")
                {
                    balanceqty = balanceqty + Convert.ToInt32(TextBox1.Text);

                }
            }
            catch(Exception ex)
            {
                Label1.Text = ex.ToString();
            }
            finally
            {
                s.Close();  
            }


        }
    }
}