using System;
using System.Xml.Schema;

namespace percent
{
     class Program
    {
        static void Main()
        {
            string empname;
            Console.WriteLine("enter name");
            empname = Console.ReadLine();
            int empno, hrsalary,dasalary;
            float total;

            Console.WriteLine("enter employee id");
            empno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter employee hrsalary");
            hrsalary = Convert.ToInt32(Console.ReadLine());
            total = hrsalary * 0.32f;


            Console.WriteLine("total salary" + total);
            Console.ReadLine();

            Console.WriteLine("enter employee dasalary");
            dasalary = Convert.ToInt32(Console.ReadLine());


            
            total = dasalary * 0.45f;



            Console.WriteLine("total salary" + total);
            Console.ReadLine();


        }
    }
}
