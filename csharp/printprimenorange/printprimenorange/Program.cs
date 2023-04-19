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
            var flag = 0;
            Console.WriteLine("enter number");
            while (num <= 20)
            {
                if (num % 2 == 0)
                {
                    flag = 1;
                    break;
                    
                }
                
                
                  

                   
                
                if(flag==0)
                {
                    Console.WriteLine(num);
                }
                num = num + 1;
                Console.ReadLine();



            }

        }
    }
}