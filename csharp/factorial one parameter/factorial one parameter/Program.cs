using System;


namespace factorial_one_parameter
{
    class Program
    {
        static void Main()
        {

            

            Console.WriteLine("enter number");
            int num= Convert.ToInt32(Console.ReadLine());

            int result= factorials(num);
            Console.WriteLine("fact" + result);
            Console.ReadLine();

        } 
        static int factorials(int n1) {
            int factor = 1;
      
            while(n1>0)

            {
                factor = factor * n1;
                n1 = n1 - 1;
             

       
            
           



            }
            return factor;

        }
    }
}
