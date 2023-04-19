using System;
namespace vote
{
    class Program
    {
        static void Main()
        {
            int age;
            Console.WriteLine("enter age");

            age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("not elegible to vote");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("eligible to vote");
                Console.ReadLine();
ax
            }
        }
    }
}
