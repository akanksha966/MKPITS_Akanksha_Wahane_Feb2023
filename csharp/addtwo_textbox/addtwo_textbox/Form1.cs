using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addtwo_textbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList list=new ArrayList();

        private void button1_Click(object sender, EventArgs e)
        {
            Student s1 = new Student(Convert.ToInt32(textBox1.Text), textBox2.Text);
            Student s2 = new Student(Convert.ToInt32(textBox3.Text), textBox4.Text);
            list.Add(s1);
            list.Add(s2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Student item in list)
            {
                sb.Append("rno " + item.rno + " name " + item.name + "\n");
            }
            label5.Text = sb.ToString();
            
        }
    }
}
