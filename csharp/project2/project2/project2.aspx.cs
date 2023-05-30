using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project2
{
    public partial class project2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //int subject1 = 80;
            int subject1= Convert.ToInt32((TextBox1.Text));
            int subject2 = Convert.ToInt32((TextBox2.Text));
            int subject3 = Convert.ToInt32((TextBox3.Text));

            //int subject2 = 90;
            //    int subject3 = 70;
            int total = 0;
            int per = 0;
            total=subject1 + subject2+subject3;
           Label1.Text=total.ToString();
            per = (total*100)/300;
            Label2.Text=per.ToString();

            if(per >90)
            {
                Label3.Text = "distinction";
            }
            else if(per>70)
            {

                Label3.Text = "First Class";
            }
            else
            {
                Label3.Text = "Fail";
            }
            clearall();


        }
        public void clearall()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }
    }
}