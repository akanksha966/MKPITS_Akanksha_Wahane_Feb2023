using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace runtime_poly_ex_of_late_binding
{

    class account
    {
        public int bal = 1000;
        public virtual void deposit(int amt)
        {
            Console.WriteLine("deposit method of account class");
            Console.ReadLine();

        }

    }
    class saving:account
    {
        int interest = 500;
        public  string deposit(int amt)
        {
            bal=bal+amt+interest;
            Console.WriteLine("deposited bal is " + bal);
            Console.ReadLine();
        }
    }

    class current:account
    {
        public  string deposit(int amt)
        {
            bal= bal+amt;
            Console.WriteLine("deposit without interest balance is " + bal);
            Console.ReadLine();

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            int amount;
            Console.WriteLine("enter amount");
            amount=Convert.ToInt32(Console.ReadLine());
            account act = null;
            string accounttype;
            Console.WriteLine("enter account type saving or current");
            accounttype= Console.ReadLine();
            if(accounttype=="saving")
            {
                act = new saving();
               

            }
            else if(accounttype=="current")
            {
                act = new current();
                
            }
            act.deposit(amount);
        }
    }
}
