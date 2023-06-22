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
            string transaction = null;

            try
            {


                query = "insert into Transaction1 values(@ItemId,@TransType,@TransQty,@TransDate)";
                cmd = new SqlCommand(query, s);
                cmd.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);

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
                query = "update Itemmaster set BalQty=@BalQty where ItemId=@ItemId ";
                cmd = new SqlCommand(query, s);
                cmd.Parameters.AddWithValue("@BalQty", balanceqty);
                cmd.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);
                cmd.ExecuteNonQuery();
                Label1.Text = "inserted successfully";
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
        static int transid = 0;
        static int oldwuantity = 0;
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //fill textbox 1
            TextBox1.Text = GridView1.SelectedRow.Cells[4].Text;

            /////////////////////////////////////////////////////
            oldwuantity=Convert.ToInt32(TextBox1.Text);
            //fill date 
            DateTime dd = Convert.ToDateTime(GridView1.SelectedRow.Cells[5].Text);
            TextBox2.Text= dd.ToString("yyyy-MM-dd");
            //fill dropdown list box using select button
            DropDownList1.SelectedValue = GridView1.SelectedRow.Cells[2].Text;
            string res = GridView1.SelectedRow.Cells[3].Text;
            if(res=="I")
            {
                RadioButton1.Checked = true;
                RadioButton2.Checked = false;
            }
            else if(res=="R")
            {
                RadioButton1.Checked = false;
                RadioButton2.Checked = true;
            }
            transid = Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text);



        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // int updatedqty=Convert.ToInt32(TextBox1.Text)-oldwuantity;
            //Response.Write("updated qty is" + updatedqty);
           

            try
            {


                query = "update Transaction1 set ItemId=@ItemId,TransType=@TransType,TransQty=@transQty,TransDate=@TransDate where TransID=@TransID";
                cmd = new SqlCommand(query, s);
                string transaction = null;
                if (RadioButton1.Checked)
                {
                    transaction = "I";
                }
                else if (RadioButton2.Checked)
                {
                    transaction = "R";
                }
                cmd.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);

                cmd.Parameters.AddWithValue("@transType", transaction);
                cmd.Parameters.AddWithValue("@TransQty", Convert.ToInt32(TextBox1.Text));
                cmd.Parameters.AddWithValue("@TransDate", TextBox2.Text);
                cmd.Parameters.AddWithValue("@TransID", transid);

                s.Open();
                cmd.ExecuteNonQuery();

                query = "select max (BalQty) from Itemmaster where ItemId=@ItemId";
                cmd = new SqlCommand(query, s);
                cmd.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);
                int balanceqty = Convert.ToInt32(cmd.ExecuteScalar());
                int updatedqty = Convert.ToInt32(TextBox1.Text) - oldwuantity;

                Response.Write("bq is" + balanceqty);
                Response.Write("update is" + updatedqty);

                if (RadioButton1.Checked)
                {
                    balanceqty = balanceqty - updatedqty;
                }
               else if (RadioButton2.Checked)
                {
                    balanceqty = balanceqty + updatedqty;
                }
                Response.Write("<br> new update is" + balanceqty.ToString());

                if (balanceqty < 0)
                {
                    Label1.Text = "stock not avalilable";
                }
                else
                {
                    query = "update Itemmaster set BalQty=@BalQty where ItemId=@ItemId ";
                    cmd = new SqlCommand(query, s);
                    cmd.Parameters.AddWithValue("@BalQty", balanceqty);
                    cmd.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);
                    cmd.ExecuteNonQuery();
                    Label1.Text = "updated successfully";
                }

            }
            catch(Exception ex) { 

                Label1.Text=ex.ToString();
            }
            finally
            {
                s.Close();
            }


        }
    }
}