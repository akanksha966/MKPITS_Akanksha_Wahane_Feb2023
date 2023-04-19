using System;
using System.Net.Http.Headers;
using System.Reflection;

namespace primenoc_
{
    class Program
    {
        static void Main()
        {

            int num = 1;

            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("it is not prime no");
                    Console.ReadLine();
                    num = num + 1;
                    
                }
                else
                {
                    Console.WriteLine("it is prime no");
                    Console.ReadLine();
                    
                }
            }
            while (num <= 20) ;

        }
    }
}