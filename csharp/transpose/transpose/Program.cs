using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transpose
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] arr1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };


            int[,] arr2 = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr2[i, j] = arr1[i, j];
                }
            }


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr2[i, j]+"\t");


                }
                Console.WriteLine();
                
            }
Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                   
                    Console.Write(arr2[j, i] + "\t");


                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
