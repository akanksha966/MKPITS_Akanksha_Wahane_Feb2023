using System;


namespace assi1_ques
{
    class Program
    {
        static void Main()
        {

            int num1, num2, result;
            Console.WriteLine("enter number1");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number2");

            num2 = Convert.ToInt32(Console.ReadLine());
            result=addition(num1, num2);
            Console.WriteLine("addition " + result);
            Console.ReadLine();
        }

        static int addition(int n1,int n2)
        {
            int final=n1 + n2;
            return final;
        }
    }
}
