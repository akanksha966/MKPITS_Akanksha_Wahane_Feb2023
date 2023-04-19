using System;
using System.Net.Http.Headers;
using System.Reflection;

namespace primenoc_
{
     class Program
    {
        static void Main()
        {

            int num;
            int counter = 2;
            
            Console.WriteLine("enter number");
            
            num = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("it is not prime no " + num);
                    counter++;

                    Console.ReadLine();


                }
                else
                {
                    Console.WriteLine("it is a prime number " + num);
                    


                    Console.ReadLine();
                }

            }
            while (counter < num);



        }
    }
}
