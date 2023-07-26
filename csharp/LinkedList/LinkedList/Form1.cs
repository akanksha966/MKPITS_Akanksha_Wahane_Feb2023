using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        LinkedList<int> li= new LinkedList<int>();  

        private void button2_Click(object sender, EventArgs e)
        {
            li.AddLast(Convert.ToInt32(textBox1.Text));
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(int i in li) {

                sb.Append(i+"\n");
                label2.Text=sb.ToString();
            }
        }
    }
}
