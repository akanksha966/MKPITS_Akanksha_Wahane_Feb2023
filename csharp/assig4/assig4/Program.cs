using System;

namespace assig4
{
    internal class Program
    {
        static void Main()
        {
            int num1, result;
            Console.WriteLine("enter number");
            num1=Convert.ToInt32(Console.ReadLine());
            result = calculate(num1);
            Console.WriteLine("sqaure is " + result);
            Console.ReadLine();
        }
        static int calculate(int num) {

            int square = num* num;
            return square;
        }
    }
}
