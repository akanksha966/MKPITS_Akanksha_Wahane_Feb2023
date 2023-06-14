using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classlibrary1
{
    //class library dot net framework
    public class Class1
    {
        public string addition(int n1,int  n2)//create method
        {
            int res=n1 + n2;
            return "addition is"+res.ToString();
        }

        public string substraction(int n1, int n2)//create method
        {
            int res = n1 - n2;
            return "substraction is" + res.ToString();
        }

        public string multiplication(int n1, int n2)//create method
        {
            int res = n1 * n2;
            return "multiplication is" + res.ToString();
        }
        public string division(int  n1, int n2)
        {
            int res = n1 / n2;
            return "division is" + res;
        }

    }
}
