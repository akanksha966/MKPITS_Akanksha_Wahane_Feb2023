using System;


namespace method_with_parameter_return
{
    class Program
    {
        static void Main()
        {
          
       

            int num1, num2,result;
            Console.WriteLine("enter number 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2");
            num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("calling addition method");
            result = addition(num1, num2);
            Console.WriteLine("addition" + result);
            Console.WriteLine("calling substraction method");
            
            result = substraction(num1, num2);
            Console.WriteLine("substraction" + result);
            Console.ReadLine();
        }

        static int addition(int n1,int n2)
        {
            int result = n1 + n2;
            return result;
        }

        static int substraction(int n1, int n2)
        {
            int result = n1 - n2;
            return result;
        }
    }
}
