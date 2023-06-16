using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using storelibrary;
using System.Reflection.Emit;

namespace trust3
{
    public partial class ItemMaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                getitemid();
            }
        }
        public void getitemid()
        {
            int res = Convert.ToInt32(ItemClass.itemid());//method
            res = res + 1;
            TextBox1.Text = res.ToString();
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            string res = ItemClass.insertrecord(TextBox2.Text,DropDownList1.Text,Convert.ToInt32(TextBox3.Text),Convert.ToInt32(TextBox4.Text));        
            Label1.Text = res;
            getitemid();
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string res=ItemClass.updaterecord(TextBox2.Text,Convert.ToInt32(TextBox3.Text),Convert.ToInt32(TextBox4.Text),Convert.ToInt32(TextBox1.Text));
            Label1.Text= res;       
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string res = ItemClass.delete(Convert.ToInt32(TextBox1.Text));
            Label1.Text=res;    
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = ItemClass.serch(Convert.ToInt32(TextBox1.Text));
            if (ds.Tables[0].Rows.Count != 0)
            {

                TextBox2.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                TextBox3.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                TextBox4.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
                Label1.Text = "search successfully";


            }
            else
            {
                Label1.Text = "no record exists on item table";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";


            }
        }
    }
}