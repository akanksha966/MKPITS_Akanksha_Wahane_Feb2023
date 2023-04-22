using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace no_argument_no_parameter_revision
{
    class printstatement
    {
        public void print()//method without parameter and not returning a value
        {
            Console.WriteLine("hello world");
            Console.ReadLine();

        }
    }



        internal class Program
        {
            static void Main()
            {
                printstatement stud = new printstatement();
                stud.print();
            }
        }
    }

