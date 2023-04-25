using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace public_access_modifier
{
    class student
    {
         public int id;
        public string name;
        public void persondata()
        {
            Console.WriteLine("person id is " + id);
            Console.WriteLine("name is " + name);
            //public access modifier accees the all class 

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student student = new student();
            student.id = 1234;
            student.name = "ashu";
            student.persondata();
        }
    }
}
