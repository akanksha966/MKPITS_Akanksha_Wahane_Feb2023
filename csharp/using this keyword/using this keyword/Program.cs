using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace using_this_keyword
{
    class program
    {
        int rno;
        string name;
     public void getelemnt(int rno,string name)
        {

            this.rno = rno;
            this.name = name;

        }
        public void display()
        {
            Console.WriteLine("roll no is " + rno);
            Console.WriteLine("name is " + name);
            Console.ReadLine();

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            program stud=new program();
            stud.getelemnt(344,"ashu");
            stud.display();
        }
    }
}
