using System;
using System.Net.Http.Headers;

namespace prime
{
    internal class Program
    {
        static void Main()
        {
            int num = 6;

            int counter;
            int flag = 0;
            for (counter = 2; counter < num; counter++)
            {
                if (num % counter == 0)
                {
                    flag = 1;
                    break;
                }
            }
                if(flag==0)
                {
                    Console.WriteLine("it is a prime no");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("it is not prime no");
                    Console.ReadLine();

                }
                
            }
        }
    }

