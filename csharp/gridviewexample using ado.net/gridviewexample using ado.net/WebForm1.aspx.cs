using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace gridviewexample_using_ado.net
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable("addrow");
            DataRow dr;
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add(new DataColumn("name", typeof(string)));
            dt.Columns.Add("Admission Date", typeof(DateTime));
            dr = dt.NewRow();
            dr[0] = 22;
            dr[1] = "ashu";
            dr[2] = DateTime.Now;
            dt.Rows.Add(dr);//add rows on datatable

            ////add another row
            dr = dt.NewRow();
            dr[0] = 23;
            dr[1] = "akanksha";
            dr[2] = DateTime.Now;
            dt.Rows.Add(dr);//add rows on datatable

            ds.Tables.Add(dt);
            GridView1.DataSource = ds.Tables["addrow"].DefaultView;
            GridView1.DataBind();



        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            int totalamount = Convert.ToInt32(TextBox1.Text);
            int paidamount = Convert.ToInt32(TextBox2.Text);
           int remainingamt = totalamount - paidamount;
           double eamount = 0;

            if (RadioButton1.Checked)
            {
                clearall();


                if (remainingamt > 0)
                {

                    Label1.Text = "you paid fill amount";
                }
            }
            else if (RadioButton2.Checked)
            {
                clearall();


                if (remainingamt > 0)
                {
                    eamount = remainingamt / 3.0;
                }

                DataSet ds = new DataSet();
                DataTable dt = new DataTable("emi");
                DataRow dr;
                dt.Columns.Add("id", typeof(int));
                dt.Columns.Add("ProductName", typeof(string));
                dt.Columns.Add("Emiamount", typeof(decimal));
                for (int i = 1; i <= 3; i++)
                {
                    dr = dt.NewRow();//newrow add on table
                    dr[0] = i;
                    dr[1] = "Acer";
                    dr[2] =eamount;
                    dt.Rows.Add(dr);    //rows add on table
                }
                ds.Tables.Add(dt);
                GridView2.DataSource = ds.Tables["emi"].DefaultView;
                GridView2.DataBind();



                //clearall();


            }
           
        }
        public void clearall()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
    }
}