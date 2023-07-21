using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using addtwo_textbox.Properties;

namespace addtwo_textbox
{
    public class Student
    {
        public int rno { get; set; }
        public string name { get; set; }
        public Student(int rno, string name)
        {
            this.rno = rno;
            this.name = name;

        }
    }
}
