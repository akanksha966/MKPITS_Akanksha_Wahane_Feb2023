using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_concat_me

thod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello";
            
            string s2 = "world";

            Console.WriteLine(string.Concat(s1, s2));

            
            Console.ReadLine();
        }
    }
}
