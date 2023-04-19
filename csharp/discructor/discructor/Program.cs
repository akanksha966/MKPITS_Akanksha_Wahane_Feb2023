using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discructor
{

    class employee
    {
        public int id;
        public string name;

        ~ employee()
        {
            Console.WriteLine("object destroyed");

        }

        public void display()
        {
            Console.WriteLine("empno " + id);
            Console.WriteLine("empname " + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            employee emp = new employee();
           
            emp.display();
            emp = null;
            Console.ReadLine();
        }
    }
}
