using System;


namespace array_parameter_sum
{
    internal class Program
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int result = calculate(arr);
            Console.WriteLine("sum is "+result);
            Console.ReadLine();
        }
        static int calculate(int[] arr2)
        {
            int sum = 0;
            for(int i = 0; i < arr2.Length;i++)
            {
                sum = sum + i;
                
            }
            return sum;


        }
    }
}
