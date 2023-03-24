using System;


namespace add_sub_method
{
   class Program
    {
        static void Main()
        {
            Console.WriteLine("enter number");
            int num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2");

            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter character");

            char name = Convert.ToChar(Console.ReadLine());


            int result = calculate(num,num2,name);
            Console.WriteLine("total " + result);

            Console.ReadLine();
        }
        static int calculate(int number,int number2,char name)
        {
            int addition=0;
            int substraction=0;
            if(name=='+')
            {
                addition = number+ number2;

                return addition;


            }
            else if(name=='-')
            {
                substraction= number - number2;


             



            }
            return substraction;







        }


    }
}
