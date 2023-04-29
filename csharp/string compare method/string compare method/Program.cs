using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_compare_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello";
            string s2 = "hello1";
            int res=string.Compare(s1, s2);//compare string method in string class
            if(res == 0) {
                Console.WriteLine("both class are equal ");//if both string zero then compare method
                                                          //return integer value is zero
            }
            else if(res == 1)
            {
                Console.WriteLine("first string is greater ");
            }
            else
            {
                Console.WriteLine("second string is greater ");
            }
            
            Console.ReadLine();
        }
    }
}
