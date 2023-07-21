using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqexample1
{
    internal class Program
    {
        //using array
        static void Main(string[] args)
        {
           //array name is (names
            string[] names = { "bill", "james", "ashu" };

            var result=from name in names 
                       where name.Contains('a')
                       select name;
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}
