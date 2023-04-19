using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace default_constructor
{
    class student
    {
         int rno;
         string name;
                          //creating a parameter constructor
        public student(int rno,string name)
        {
           this. rno = rno;
           this. name = name;
        }
        public void displaydata()
        {

            Console.WriteLine("rno " + rno);
            Console.WriteLine("name " + name);
            Console.ReadLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            student stud1 = new student(123,"ashu");// it will call constructor

            stud1.displaydata();
        }
    }
}
