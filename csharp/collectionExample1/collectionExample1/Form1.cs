using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace collectionExample1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList list= new ArrayList();    
        private void button1_Click(object sender, EventArgs e)
        {
            list.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Capacity" +list.Capacity);
            MessageBox.Show("count" + list.Count);
            StringBuilder sb = new StringBuilder();
            foreach(object o in list)
            {
                sb.Append(o.ToString()+"\n");
            }
            label2.Text = sb.ToString();    
        }
    }
}
