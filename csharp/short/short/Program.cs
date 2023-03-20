using System;


namespace shortvariable

{

    class Program
    {
        static void Main(string[] args)
        {
            short b1;
            Console.WriteLine("enter short number ");
            b1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("short entered = " + b1);

            Console.ReadLine();

        }
    }
}