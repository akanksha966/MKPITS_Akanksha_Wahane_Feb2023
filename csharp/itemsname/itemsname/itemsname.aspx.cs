using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace itemsname
{
    public partial class itemsname : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string itemname;
            itemname = TextBox1.Text;

            int price = 0;
            price = Convert.ToInt32(TextBox2.Text);
            int quantity = 0;
            quantity= Convert.ToInt32(TextBox3.Text);
            int totalprice = 0;

            if(itemname =="Dosa")
            {
                totalprice = price * quantity;
            }
            else if(itemname =="Samosa")
            {
                totalprice = price * quantity; 
            }
            else if(itemname=="Momos")
            {
                totalprice=price * quantity;    
            }
            else 
                {
                Label1.Text = "Sorry Dish not available";
                } 


            Label1.Text= totalprice.ToString();
        }
    }
}