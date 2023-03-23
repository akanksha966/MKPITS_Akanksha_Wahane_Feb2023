using System;

namespace returning_method
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("calling the method");
            int result = calculatesquare();
            Console.WriteLine("square" + result);
            Console.ReadLine();


        }

        static  int calculatesquare()
        {
            int num;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            int square = num * num;
            return square;
            
        }
    }
}
