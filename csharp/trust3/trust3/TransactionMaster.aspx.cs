using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using storelibrary;

namespace trust3
{
    public partial class TransactionMaster : System.Web.UI.Page
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
            if (RadioButton1.Checked)
            {
                string res = TransactionClass.inserted(Convert.ToInt32(DropDownList1.SelectedValue), DateTime.Today, Convert.ToInt32(DropDownList2.SelectedValue), Convert.ToInt32(TextBox2.Text));
                Label4.Text = "inserted successfully";
            }
            else if (RadioButton2.Checked)
            {
                string res = TransactionClass.purinserted(Convert.ToInt32(DropDownList1.SelectedValue), DateTime.Today, Convert.ToInt32(DropDownList2.SelectedValue), Convert.ToInt32(TextBox2.Text));
                Label4.Text = "inserted successfully";
            }

            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }

    }
