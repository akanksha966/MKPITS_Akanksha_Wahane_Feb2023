using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_an_array_without_using_function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 13, 12, 11 };
            int temp = 0;


            for(int i=0; i<arr.Length; i++)
            {
                for(int j=i+1; j<arr.Length; j++)
                {
                    if (arr[i] >arr[j])
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }

            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();




        }
    }
}
