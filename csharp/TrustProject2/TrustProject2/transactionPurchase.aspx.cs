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
    public partial class transactionPurchase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
            {
                Panel2.Visible = false;
            }
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Panel2.Visible = false;
            Panel1.Visible = true;
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = true;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string query = null;
            SqlConnection s = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=civica");

            SqlCommand cmd;
            if (RadioButton1.Checked)
            {
                try
                {
                    query = "insert into Item_Transaction1(item_id,transaction_date,department_id,quantity) values(@item_id,@transaction_date,@department_id,@quantity)";
                    cmd = new SqlCommand(query, s);
                    cmd.Parameters.AddWithValue("@item_id", DropDownList1.SelectedValue);
                    cmd.Parameters.AddWithValue("@transaction_date", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@department_id", DropDownList2.SelectedValue);
                    cmd.Parameters.AddWithValue("@quantity", TextBox2.Text);
                    s.Open();
                    cmd.ExecuteNonQuery();
                    s.Close();

                    //code to get balance_quantity from item_master table
                    int bal_qty = 0;
                    query = "select Balance_Quantity from Item_Masters where Item_Id=@Item_Id ";
                    cmd = new SqlCommand(query, s);
                    cmd.Parameters.AddWithValue("@Item_Id", DropDownList1.SelectedValue);
                    s.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())//dr open
                    {
                        bal_qty = Convert.ToInt32(dr[0].ToString());

                    }
                   

                    
                    dr.Close();//datareader closed
                    s.Close();//connection close
                    int qty = bal_qty - Convert.ToInt32(TextBox2.Text);
                    query = "update Item_Masters set Balance_Quantity=@Balance_Quantity where Item_Id=@Item_Id";
                    cmd = new SqlCommand(query, s);
                    cmd.Parameters.AddWithValue("@Balance_Quantity", qty);
                    cmd.Parameters.AddWithValue("@Item_Id", DropDownList1.SelectedValue);
                    s.Open();
                    cmd.ExecuteNonQuery();
                    Label4.Text = "item issued to department successfully";



                }
                catch (Exception ex)
                {
                    Label4.Text = ex.ToString();
                }
                finally { s.Close(); }
            }
            else if (RadioButton2.Checked)
            {
                try
                {
                    query = "insert into Item_Transaction1(item_id,transaction_date,vendor_id,quantity) values(@item_id,@transaction_date,@vendor_id,@quantity)";
                    cmd = new SqlCommand(query, s);
                    cmd.Parameters.AddWithValue("@item_id", DropDownList1.SelectedValue);
                    cmd.Parameters.AddWithValue("@transaction_date", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@vendor_id", DropDownList3.SelectedValue);
                    cmd.Parameters.AddWithValue("@quantity", TextBox2.Text);
                    s.Open();
                    cmd.ExecuteNonQuery();
                    s.Close();
                    //code to get balance_quantity from item_master table
                    int balance_qty = 0;
                    query = "select Balance_Quantity from Item_Masters where Item_Id=@Item_Id ";
                    cmd = new SqlCommand(query, s);
                    cmd.Parameters.AddWithValue("@Item_Id", DropDownList1.SelectedValue);
                    s.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())//dr open
                    {
                        balance_qty = Convert.ToInt32(dr[0].ToString());

                    }
                    dr.Close();//datareader closed
                    s.Close();//connection close
                    int qty = balance_qty + Convert.ToInt32(TextBox2.Text);
                    query = "update Item_Masters  set Balance_Quantity=@Balance_Quantity where Item_Id=@Item_Id";
                    cmd = new SqlCommand(query, s);
                    cmd.Parameters.AddWithValue("@Balance_Quantity", qty);
                    cmd.Parameters.AddWithValue("@Item_Id", DropDownList1.SelectedValue);
                    s.Open();
                    cmd.ExecuteNonQuery();
                    Label4.Text = "item purchase to vendor successfully";
                }
                catch (Exception ee)
                {
                    Label4.Text = ee.ToString();
                }
                finally { s.Close(); }

            }
        }
    }
}