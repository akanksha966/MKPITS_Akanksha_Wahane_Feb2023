using System;

namespace user_input
{
    class program
    { 
        static void Main()
        {
        Console.WriteLine("pls enter your name");
        string name;
        name = Console.ReadLine();
        Console.WriteLine("hello mr/miss" + name);
        Console.ReadKey();

        }
    }
}
