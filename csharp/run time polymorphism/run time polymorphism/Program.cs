using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace run_time_polymorphism
{
    class parent
    {
        public virtual void getinfo()
        {
            Console.WriteLine("it is a PARENT class");
        }
    }

    class child : parent
    {
        public override void getinfo()
        {
            Console.WriteLine("it is a CHILD class");// run time polymorphism
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                parent p= new child();//reference variable child class ke object me reference variable 
                                      // store hota hai..
                
                p.getinfo();
                Console.ReadLine();
            }
        }
    }
}
