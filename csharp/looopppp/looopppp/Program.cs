using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main()

        {
            int row, col;
            
            for (row = 2; row<=6; row++)
            {
                int s = 1;
                for (col = 1; col<row; col++)
                {
                    Console.Write(s+ "\t");
                    s = s + 2;


                }
                Console.WriteLine();

            }
            Console.ReadLine();

        }
    }
}