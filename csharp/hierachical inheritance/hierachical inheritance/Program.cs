using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierachical_inheritance
{

    class person
    {
        public string name;
        public string address;
    }


    class student:person
    {
        public int id;
        public int marks;
    }

    class employee:person
    {
        public int salary;
        public string designation;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.name = "amit";
            s.address = "nagpur";
            s.id = 44;
            s.marks = 999;
            Console.WriteLine("--------------- student details ----------");
            Console.WriteLine("name " + s.name);
            Console.WriteLine("addres " + s.address);
            Console.WriteLine("rno " + s.id);
            Console.WriteLine("marks" + s.marks);
            


            ////creating object of empclass
            ///

            employee emp = new employee();
            emp.name = "ravinesh";
            emp.address = "mumbai";
            emp.salary = 55544;
            emp.designation = "manager";
            Console.WriteLine("--------------- emp details ----------");
            Console.WriteLine("name " + emp.name);
            Console.WriteLine("addres " + emp.address);
            Console.WriteLine("salary " + emp.salary);
            Console.WriteLine("designation" + emp.designation);
            Console.ReadLine();



        }
    }
}
