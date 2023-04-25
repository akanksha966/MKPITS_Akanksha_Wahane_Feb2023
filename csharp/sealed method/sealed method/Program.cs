using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_method
{
    class person
    {
        public virtual void display()
        {
            Console.WriteLine("hello from person");
        }
    }
    class student:person
    {
        public sealed override void display()
        {
            Console.WriteLine("hello from student");
        }
    }
    class person2:student
    {
        //public sealed override void display()
        //{
        //    Console.WriteLine("hello from student");
        //}
        public void shows()
        {
            Console.WriteLine("hello from another method");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            person p=new person(); 
            p.display();
            person2 per=new person2();
            per.display();
            per.shows();
            Console.ReadLine(); 
        }
    }
}
