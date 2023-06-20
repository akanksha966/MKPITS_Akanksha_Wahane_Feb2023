using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace DrivenItProject
{
    public partial class transaction : System.Web.UI.Page
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
                string query = "insert into Transaction1 values(@ItemId,@TransType,@TransQty,@TransDate)";
                cmd = new SqlCommand(query, s);
                cmd.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);
                string transa = null;
                if (RadioButton1.Checked)
                {
                    transa = "I";
                }
                else if (RadioButton2.Checked)
                {
                    transa = "R";
                }
                cmd.Parameters.AddWithValue("@TransType", transa);
                cmd.Parameters.AddWithValue("@TransQty", Convert.ToInt32(TextBox1.Text));
                cmd.Parameters.AddWithValue("@TransDate", TextBox2.Text);
                s.Open();
                cmd.ExecuteNonQuery();
                // Label1.Text = "insert successfully";
                //gettring balqty from  itemmaster table for particular item id
                //gettring balqty from  itemmaster table for particular item id

                query = "select max (BalQty) from Itemmaster where ItemId=@ItemId";
                cmd = new SqlCommand(query, s);
                cmd.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);
                int balancequantity = Convert.ToInt32(cmd.ExecuteScalar());
                if (transa == "I")
                {
                    balancequantity = balancequantity - Convert.ToInt32(TextBox1.Text);

                }
                else if (transa == "R")
                {

                    balancequantity = balancequantity + Convert.ToInt32(TextBox1.Text);
                }
                //updating bal qty on item master table
                query = "update Itemmaster set BalQty=@BalQty where ItemId=@ItemId";
                cmd = new SqlCommand(query, s);
                cmd.Parameters.AddWithValue("@BalQty", balancequantity);
                cmd.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);
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
            Response.Write("transaction id" + transid.ToString());
         //    int updatedqty=Convert.ToInt32(TextBox1.Text)-oldqty;
          //  Response.Write("update quantity is" + updatedqty.ToString());
            try
            {


                query = "update Transaction1 set ItemId=@ItemId ,TransType=@transtype,TransQty=@transqty,TransDate=@transdate where TransID= @TransID";
                cmd = new SqlCommand(query, s);

                string transa = null;
                if (RadioButton1.Checked)
                {
                    transa = "I";
                }
                else if (RadioButton2.Checked)
                {

                    transa = "R";
                }
                cmd.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);

                cmd.Parameters.AddWithValue("@transtype", transa);
                cmd.Parameters.AddWithValue("@transqty", Convert.ToInt32(TextBox1.Text));
                cmd.Parameters.AddWithValue("@transdate", TextBox2.Text);
                cmd.Parameters.AddWithValue("@TransID", transid);
                s.Open();
                cmd.ExecuteNonQuery();
                //getting the balqty from itemmaster table for particular item id
                query = "select max(BalQty) from Itemmaster where ItemId=@itemid";
                cmd = new SqlCommand(query, s);
                cmd.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                int bq = Convert.ToInt32(cmd.ExecuteScalar());
                int updatedqty = Convert.ToInt32(TextBox1.Text) - oldqty;

                Response.Write("bq is" + bq);
                Response.Write("update is" + updatedqty);

                if(RadioButton1.Checked)
                {
                    bq = bq - updatedqty;

                    
                }

               else if (RadioButton2.Checked)
                {
                    bq = bq + updatedqty;
                               
                }
                Response.Write("<br> new update is" + bq.ToString());

                if (bq < 0)
                {
                    Label1.Text = "stock not available";
                }
                else
                {


                    //if (transa == "I")
                    //{
                    //    bq = bq - Convert.ToInt32(TextBox1.Text);
                    //}
                    //else if (transa == "R")
                    //{
                    //    bq = bq + Convert.ToInt32(TextBox1.Text);
                    //}
                    //updating bal qty on item master table
                    query = "update Itemmaster set BalQty=@balqty where ItemId=@itemid";
                    cmd = new SqlCommand(query, s);
                    cmd.Parameters.AddWithValue("@balqty", bq);
                    cmd.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                    cmd.ExecuteNonQuery();

                    Label1.Text = "record updated successfully";
                }
            }
            catch (Exception ex)
            {

                Label1.Text = ex.ToString();
            }
            finally
            {
                s.Close();
            }

            }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            TextBox1.Text = GridView1.SelectedRow.Cells[4].Text;
        }
        static int transid = 0;
        static int oldqty = 0;
        protected void GridView1_SelectedIndexChanged2(object sender, EventArgs e)
        {
            TextBox1.Text = GridView1.SelectedRow.Cells[4].Text;
            oldqty=Convert.ToInt32(Convert.ToInt32(TextBox1.Text));//old quantity

            DateTime dd = Convert.ToDateTime(GridView1.SelectedRow.Cells[5].Text);
            TextBox2.Text = dd.ToString("yyyy-MM-dd");

            DropDownList1.SelectedValue = GridView1.SelectedRow.Cells[2].Text;


            string res = GridView1.SelectedRow.Cells[3].Text;
            if(res=="I")
            {
                RadioButton1.Checked = true;
                RadioButton2.Checked = false;
            }
            if(res=="R")
            {
                RadioButton2.Checked= true;
                RadioButton1.Checked= false;
            }
            transid = Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text);

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                query = "delete from Transaction1 where TransID=@TransID";
                cmd = new SqlCommand(query, s);
                cmd.Parameters.AddWithValue("@TransID", transid);
                s.Open();
                cmd.ExecuteNonQuery();
                Label1.Text = "deleted successfully";
            }
            catch (Exception ex)
            {
                Label1.Text=ex.ToString();
            }
            finally
            {
                s.Close();
            }
        }
    }
}