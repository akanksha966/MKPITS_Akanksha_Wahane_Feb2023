using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace accountdetailsform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amount;
            Console.WriteLine("enter amount");
            amount = Convert.ToInt32(Console.ReadLine());
            check act = null;
            string accounttype;
            Console.WriteLine("enter account type saving or current");
            accounttype = Console.ReadLine();
            if (accounttype == "saving")
            {
                act = new saving();


            }
            else if (accounttype == "current")
            {
                act = new current();

            }
            act.deposit(amount);
        }
    }
}
