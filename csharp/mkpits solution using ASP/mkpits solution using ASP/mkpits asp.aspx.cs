using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mkpits_solution_using_ASP
{
    public partial class mkpits_asp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("country " + DropDownList1.Text + "<br>");
            sb.Append("City " + DropDownList2.Text + "<br>");
                //courses checkbox
           foreach(ListItem li in CheckBoxList1.Items)
            {
                if(li.Selected)
                {
                    sb.Append("Courses " + li.Value + "<br>");
                }
            }
            sb.Append("center " + ListBox1.SelectedItem.ToString() + "<br>");
            Label1.Text = sb.ToString();        
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList2.Items.Clear();
            switch(DropDownList1.Text)
            {
                case "India":
                    DropDownList2.Items.Add("Nagpur");
                    DropDownList2.Items.Add("Mumbai");
                    break;
                case "Nepal":
                    DropDownList2.Items.Add("kathmandu");
                    DropDownList2.Items.Add("lalitpur");
                    break;





            }
        }
    }
}