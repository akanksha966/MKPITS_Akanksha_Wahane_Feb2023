using System;
using System.ComponentModel;

namespace methodspriHello
{
   class Program
    {
        static void Main()
        {
            Console.WriteLine("calling the method display");
            display();
            Console.WriteLine("again calling display");
            display();
        }
        static void display()
        {
            Console.WriteLine("hello world");
            Console.ReadLine();
        }

    }
}
