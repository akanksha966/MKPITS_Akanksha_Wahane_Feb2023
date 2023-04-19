using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace balance_class
{





    class bank
    {
        int balance=10000;
        int total;
        

        public int deposit(int balance)
        {
            int depoamount = Convert.ToInt32(Console.ReadLine());


            if (balance>0)
            {
                total = balance + depoamount;
                
            }
            return total;
        }

        public int withdraw(int balance)
        {
            int withdrawamt = Convert.ToInt32(Console.ReadLine());


            if (withdrawamt<=balance)
            {
                total = balance - withdrawamt;

            }

            else
            {
                Console.WriteLine("insufficient balance");
            }
            return total;
        }


        public int showbalance(int balance)
        {
            Console.WriteLine("total withdraw balance is " + total);
            Console.WriteLine("total deposit balance is " + total);

            return total;
        }
     





    }
    internal class balance
    {
    }
}
