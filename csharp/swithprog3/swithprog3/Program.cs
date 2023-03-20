using System;


namespace swithprog3
{
     class Program
    {
        static void Main()
        {
            char op;
            string name;
            Console.WriteLine("enter character");
            op = Convert.ToChar(Console.ReadLine());
            switch (op)
            {
                case 'a':
                    Console.WriteLine("Vowel");
                    Console.ReadLine();
                    break;
                case 'e':
                    Console.WriteLine("Vowel");
                    Console.ReadLine();
                    break;
                case 'i':
                    Console.WriteLine("Vowel");
                    Console.ReadLine();
                    break;
                case 'o':
                    Console.WriteLine("Vowel");
                    Console.ReadLine();
                    break;
                case 'u':
                    Console.WriteLine("Vowel");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Not a vowel");
                    Console.ReadLine();
                    break;
           }
        }
    }
}
