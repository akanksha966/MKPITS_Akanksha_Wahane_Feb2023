using System;


namespace method_with_parameter_return
{
    class Program
    {
        static void Main()
        {
            calculate();
        }
        static void calculate()
        {




            int num1, num2, result;
            Console.WriteLine("enter number 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("calling addition method");
            addition(num1, num2);
            
            Console.WriteLine("calling substraction method");

            substraction(num1, num2);
           
            Console.ReadLine();
        }

        static void addition(int n1, int n2)
        {
            int result = n1 + n2;
            Console.WriteLine("addtion is" + result);
        }

        static void substraction(int n1, int n2)
        {
            int result = n1 - n2;
            Console.WriteLine("substraction is" + result);

        }
    }
}
