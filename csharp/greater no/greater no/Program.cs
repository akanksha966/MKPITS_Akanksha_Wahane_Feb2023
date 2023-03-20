using System;
namespace vote
{
    class Program




    {
        static void Main()
        {
            int num1,num2;
            Console.WriteLine("enter number 1");
           


            num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter number 2");
            num2 = Convert.ToInt16(Console.ReadLine());

            if (num1>num2)
            {
                Console.WriteLine("num1 is greater");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("num2 is greater");
                Console.ReadLine();
                
            }
        }
    }
}
