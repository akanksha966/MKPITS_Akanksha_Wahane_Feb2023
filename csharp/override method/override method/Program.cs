using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace override_method
{
    class account
    {
        public int bal = 1000;
        

        public void deposit(int amt)
        {
            Console.WriteLine("deposit payment is 10000");
        }


    }

    class saving:account 
    
    {

        int interest = 400;
        public void deposit(int amt)
        {
            bal=bal+amt+interest;
            Console.WriteLine("after saving balance is " + bal);
            Console.ReadLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            saving stud= new saving();

            stud.deposit(200);

        }
    }
}
