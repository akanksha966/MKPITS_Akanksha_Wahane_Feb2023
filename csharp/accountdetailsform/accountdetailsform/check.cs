using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accountdetailsform
{
    internal class check
    {

         public int bal = 1000;

        public virtual void deposit(int amt)
        {
            Console.WriteLine("deposit method of account class");
        }

        class saving : check
        {
            int interest = 500;
            public override void deposit(int amt)
            {
                bal=bal + amt+interest;
                Console.WriteLine("deposit bal is " + bal);

            }
        class current:check
            {
                public override void deposit(int amt)
                {
                    bal = bal + amt;
                    Console.WriteLine("bal is " + bal);
                }

            }
        }
    }
}
