using System;
namespace addno
{
    class Program
    {
        static void Main()
           
        {
            int num1, num2, result;
            Console.WriteLine("enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2");

            num2 = Convert.ToInt32(Console.ReadLine());
            result = num1 + num2;
            Console.WriteLine("addition of two number " + result);
            Console.ReadKey();
        }
    }
}