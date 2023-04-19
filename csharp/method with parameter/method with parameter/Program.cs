using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_with_parameter
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("enter number");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int result = calculatesquare(n1);
            Console.WriteLine("square " + result);
            Console.ReadLine();
        }

        static int calculatesquare(int num) 
        {
            int square = num * num;
            return square;

        }
    }
}
