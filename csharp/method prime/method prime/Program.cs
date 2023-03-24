using System;
using System.Diagnostics;
using System.Reflection;

namespace factorial_one_parameter
{
    class Program
    {
        static void Main()
        {



            Console.WriteLine("enter number");
            int num = Convert.ToInt32(Console.ReadLine());

            primeno(num);

            //Console.WriteLine("prime no" + result);
            Console.ReadLine();
        }

       
        static void primeno(int n1)
        {
            int counter = 2;
            while(counter<n1)
            {
                if(n1%2==0)
                {
                    Console.WriteLine("it is not prime no");
                    break;
                    
                }
                else
                {
                    Console.WriteLine("it is prime no");
                    break;
                    

                }
                counter = counter + 1;




            }
            



            

        }

    }
}
