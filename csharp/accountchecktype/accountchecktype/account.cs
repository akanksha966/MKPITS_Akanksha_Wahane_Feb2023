using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace accountchecktype
{
    internal class Account
    {

        public int bal = 1000;
        public virtual int deposite(int amt)
        {

            return bal;
        }
    }
    internal class Saving : Account
    {
        public int intrest = 500;
        public override int deposite(int amt)
        {
            bal = bal + amt + intrest;
            return bal;
        }
    }
    internal class Current : Account
    {
        public override int deposite(int amt)
        {
            bal = bal + amt;
            return bal;
        }
    }
}

