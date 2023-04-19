using System;


namespace findeven
{
     class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Number");
            int num;
            num = Convert.ToInt16(Console.ReadLine());
            if(num%2==0)
            {
                Console.WriteLine("it is even number");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("it is odd number");
                Console.ReadLine();
            }
        }
    }
}
