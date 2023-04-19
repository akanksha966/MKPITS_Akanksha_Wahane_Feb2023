using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace continuestatement
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("enter number 2");
            int num1, num2, result=0;
            char op;
            num1=Convert.ToInt32(Console.ReadLine());
            num2=Convert.ToInt32(Console.ReadLine());
            op=Convert.ToChar(Console.ReadLine());  
            if(op=='-')
            {
                goto substraction;
            }
            else if(op=='+')
            {
                goto addition;
            }
            else
            {
                goto end;
            }
            addition:
            result=num1 + num2;
            goto end;
            substraction:
            result=num1 - num2;
            goto end;
        end:
            Console.WriteLine("result=" + result);
            Console.ReadLine();
            
        }
    }
}
