using System;
namespace threeno
{
    class Program
    {
        static void Main()
        {
            int num1,num2,num3, result;
            Console.WriteLine("enter number 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("enter number 2");
            num2= Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("enter number 3");
            num3 = Convert.ToInt32(Console.ReadLine());
            result = num1+num2+num3;
            Console.WriteLine("total addition of three number" + result);
            Console.ReadKey();
        }
    } 
    }
