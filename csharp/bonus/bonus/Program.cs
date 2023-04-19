using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Calculate
    {
        static void Main()
        {

            string empname,designation;
            

            Console.WriteLine("enter empname ");

            

            empname = Console.ReadLine();
            int idno;
            Console.WriteLine("enter no ");
            idno = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("enter designation ");
            designation = Console.ReadLine();
            if(designation == "manager")
            {
                Console.WriteLine("bonus 10000");
            }
            else if (designation=="clerk")
            {
                Console.WriteLine("bonus 5000");

            }
            else if (designation=="peon")
            {
                Console.WriteLine("bonus 2000");

            }

            else
            {
                Console.WriteLine("invalid designation");

            }
            Console.ReadLine();

            

            

        }
    }
}