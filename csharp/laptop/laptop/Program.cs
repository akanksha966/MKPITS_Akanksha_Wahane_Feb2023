using System;

namespace laptop
{
     class Program
    {
        static void Main()
        {
            string productname;
            Console.WriteLine("enter product name");
            productname = Console.ReadLine();


            int quantity,rate,totalamount;
            float finalbill;

            Console.WriteLine("enter deposit");
            rate = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("enter quantity");
            quantity = Convert.ToInt32(Console.ReadLine());

            totalamount = rate * quantity;


            if (totalamount >= 10000)
            {
                finalbill = totalamount * 0.18f;

                Console.WriteLine("your tax is" + finalbill);
                Console.ReadLine();

            }

            else if (totalamount >= 5000 && totalamount<10000)
            {
                finalbill = totalamount * 0.12f;

                Console.WriteLine("your tax is" + finalbill);
                Console.ReadLine();

            }

            else if (totalamount<5000)
            {
                finalbill = totalamount * 0.05f;

                Console.WriteLine("your tax is" + finalbill);
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("invalid productname");
            }







        }
    }
}
