using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionex2
{
   class Student
    {
        public int rno { get; set; }
        public string name { get; set; }
        public Student(int rno,string name)
        { 
            this.rno = rno;
            this.name = name;

        }

    }
}
