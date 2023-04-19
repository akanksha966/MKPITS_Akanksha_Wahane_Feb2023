using System;

namespace findvowel
{
    class Program
    {
        static void Main()
        {
            char check;
            Console.WriteLine("enter character");
            check = Convert.ToChar(Console.ReadLine());
            if(check=='a'|| check=='e'||check=='i' ||check=='o'|| check=='u')
            {
                Console.WriteLine("It is vowel");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("It is not vowel");
                Console.ReadLine();

            }
        }
    }
}
