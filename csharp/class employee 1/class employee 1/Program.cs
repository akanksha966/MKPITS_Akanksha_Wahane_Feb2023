using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_employee_1
{

    class employee
    {
        public int id;
      public  string name;
        public float salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {


            employee stud = new employee();
            stud.id = 2345;
            stud.name = "ashu";
            stud.salary = 10000;
            Console.WriteLine("id is " + stud.id);
            Console.WriteLine("name " + stud.name);
            Console.WriteLine("salary is " + stud.salary);
            Console.ReadLine();


        }
    }
}
