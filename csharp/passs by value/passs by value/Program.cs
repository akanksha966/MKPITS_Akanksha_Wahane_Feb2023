using System;


namespace passbyvalue
{
    class Program
    {
        static void Main()
        {
            int num = 5;
            Console.WriteLine("value of num inside main before passing " + num);
            display(num);
            Console.WriteLine("value of num after calling " + num);
            Console.ReadLine();
        }
        static void display(int num)
        {
            num = num + 2;
            Console.WriteLine("value of num inside display " + num);
            Console.ReadLine();
        }


    }
}