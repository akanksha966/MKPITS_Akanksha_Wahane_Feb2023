using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banklibrary
{
    public class Class1
    {
        int bal = 10000;
        public string withdraw(int amount)
        {
            int result=bal-amount;
            return "withdraw bal is " + result;
        }

        public string deposit(int amount)
        {
            
            int result = bal + amount;
            return "deposit bal is " + result;
        }
    }
}
