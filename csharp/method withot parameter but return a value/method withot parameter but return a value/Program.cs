﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_withot_parameter_but_return_a_value
{
    public class statement
    {
        int a=10; int b=20;
        public int state()
        {
            int result = a + b;
            Console.WriteLine(result);
            Console.ReadLine();
            return result;



        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            statement s = new statement();
            int b = s.state();
            Console.WriteLine(b);

        }
    }
}
