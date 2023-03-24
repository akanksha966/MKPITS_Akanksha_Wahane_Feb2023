using System;


namespace factorial_one_parameter
{
    class Program
    {
        static void Main()
        {



            Console.WriteLine("enter number");
            int num = Convert.ToInt32(Console.ReadLine());

            int result = tables(num);
           
            Console.WriteLine("table" + result);
            Console.ReadLine();

        }
        static int tables(int n1)
                        
           

        {


            
            int res=0;
            int i = 1;


            while (i<=10)

            {
                res = n1*i;
                Console.WriteLine(res);
              i=i+1;
                

             }
            
            

            return res;

        }

    }
}
