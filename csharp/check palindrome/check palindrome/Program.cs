using System;

namespace check_palindrome
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("enter a string to check palindronr");
            string name = Console.ReadLine();
            string reverse = "";
            
            for (int i = name.Length -1; i >= 0; i--)
            {
                reverse= reverse += name[i];
            }
            if (name ==reverse)
            {
                Console.WriteLine("it is Palindrome.");
              
            }
            else
            {
                Console.WriteLine("not palindrome");
               
            }
            Console.ReadKey();
        

        }
    }

    }


