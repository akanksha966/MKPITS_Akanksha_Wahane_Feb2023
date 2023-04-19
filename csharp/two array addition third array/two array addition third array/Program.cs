using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_array_addition_third_array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] arr2 = { { 2, 4, 3 }, { 4, 5, 6 } };
            int[,] sum = new int[2,3];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum[i, j] = arr[i, j] + arr2[i, j];
                }
            }
            ///display value

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(sum[i, j]+"\t");








                }
                Console.WriteLine();
           
            }
            Console.ReadLine();
        }
    }
}
