using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_of_enum
{
    enum month
    {
        jan,feb,march
        

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("jan is vale " +(int)month.jan);
            Console.WriteLine("jan is vale " + (int)month.feb);
            Console.WriteLine("jan is vale " +Convert.ToInt32(month.march));


            Console.ReadLine();


        }
    }
}
