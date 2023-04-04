using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_search
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 1, 2, 3, 4, 6, 8, 10 };
            Console.Write("enter a number to search for");
            int target = int.Parse(Console.ReadLine());
            int result = binarysearch(numbers, target);

            if (result == -1)
            {
                Console.WriteLine("The number {0} was not found.", target);
            }
            else
            {
                Console.WriteLine("The number {0} was found at index {1}.", target, result);
            }

            Console.ReadLine();
        }

        static int binarysearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (arr[middle] == target)
                {
                    return middle;
                }
                else if (arr[middle] < target)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }
            return -1;















        }

    }
}
    

