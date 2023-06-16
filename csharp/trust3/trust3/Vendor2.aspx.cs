using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using storelibrary;

namespace trust3
{
    public partial class Vendor2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {
            if (!Page.IsPostBack)
            {
               getvendorid();   
            }
           
           

        }
        public void getvendorid()
        {
            int res = Convert.ToInt32(VendorClass.getvendorid());
            res = res + 1;
            TextBox1.Text = res.ToString();
        }


        //protected void Button1_Click(object sender, EventArgs e)
        
     
        //}

        protected void Button2_Click(object sender, EventArgs e)
        {
            string res = VendorClass.insertvendor_master(TextBox2.Text);
            Label1.Text = res;
           getvendorid();
            TextBox2.Text = "";

        }
        

        //protected void Button3_Click(object sender, EventArgs e)
        //{
           
        //}

        protected void Button3_Click1(object sender, EventArgs e)
        {
            string res = VendorClass.updatevendor(TextBox2.Text, Convert.ToInt32(TextBox1.Text));
            Label1.Text = res;  

//           
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string res=VendorClass.deleted(Convert.ToInt32(TextBox1.Text)); 
            Label1.Text = res;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            DataSet set=new DataSet();
          set=VendorClass.searchvendor(Convert.ToInt32(TextBox1.Text));
            if (set.Tables[0].Rows.Count != 0) {

                TextBox2.Text = set.Tables[0].Rows[0].ItemArray[1].ToString();
            }
            else
            {
                Label1.Text = "no record exists on vendor table";
                TextBox2.Text = "";
            }
        }
    }
}