using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_accesee
{
    class abc
    {
        int age;

        string name;
        public void getdate()
        {
            
        }
    class bbb:abc
        {
            public void getdata2()
            {
                Console.WriteLine("age is " + age);
                 Console.WriteLine("name is " + name);


            }
        }

        internal class Program//if one class is private, then can we inheritate that class?
        {
            static void Main(string[] args)
            {
                bbb s = new bbb();
                s.age = 12;
                s.name = "Test";
                s.getdata2();
                Console.ReadLine();

            }
        }
    }

}
    