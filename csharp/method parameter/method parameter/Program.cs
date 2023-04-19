using System;
using System.Security.Cryptography;

namespace method_parameter
{
    class Program
    {
        static void Main()
        {
            string name;
            Console.WriteLine("enter string check palindrome or not");
            name = Convert.ToString(Console.ReadLine());
            string result = check(name);
            Console.WriteLine("it is palindrome" + result);
            Console.ReadLine();

        }
        static string check(string finals)
        {
           

           
            string reverse = "";
            for (int i = finals.Length - 1; i >= 0; i--)
            {
                reverse = reverse + finals[i];
            }



                if (finals == reverse)
                {
               
                }
                else
                {
                    Console.WriteLine("not palindrome");
                       Console.ReadLine();
                   


                }
            
            
            return finals;



        }
    }
}











