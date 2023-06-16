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
    public partial class DepartmentMaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         if(!Page.IsPostBack)
            {
                getdepartmentid();
            }
        }
        public void getdepartmentid()
        {
            int res = Convert.ToInt32(DepartmentClass.departmentid());
            res = res + 1;
            TextBox1.Text = res.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string res=DepartmentClass.insertrecord(TextBox2.Text);
            Label1.Text = res;
            getdepartmentid();
            TextBox2.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string res = DepartmentClass.updaterecord(TextBox2.Text,Convert.ToInt32(TextBox1.Text));
            Label1.Text = res;

            

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string rex=DepartmentClass.deleterecord(Convert.ToInt32(TextBox1.Text));    
            Label1.Text = rex;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = VendorClass.searchvendor(Convert.ToInt32(TextBox1.Text));
            if (ds.Tables[0].Rows.Count != 0)
            {

                TextBox2.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            }
            else
            {
                Label1.Text = "no record exists on vendor table";
                TextBox2.Text = "";
            }
        }
    }
}