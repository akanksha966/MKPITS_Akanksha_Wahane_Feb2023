using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class overloading
    {
        int id;
        string name;

        public void getdata(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
        public void getdata(string name,int id)
        {
            this.id = id;
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine("id is " + id);
            Console.WriteLine("name is " + name);
        
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            overloading stud= new overloading();
            stud.getdata(123,"ashu");
            stud.display();

            stud.getdata(4785, "akanksha");
            stud.display();

            Console.ReadLine();

        }
    }
}
