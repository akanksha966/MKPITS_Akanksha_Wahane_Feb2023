using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parentclass
{

    class account
    {
        public int bal = 10000;
        public void deposit(int amt)
        {
            Console.WriteLine("balance is deposit");
            Console.ReadLine();

        }
    }
        class Saving : account

        {
            public int amt;
            public void deposit(int amt)
            {
                Console.WriteLine("after withdraw balance");
               Console.ReadLine();
            }
        }

    
    internal class Program
    {
        static void Main(string[] args)
        {

            account act = new Saving();
            act.deposit(200);
        }
    }
}
