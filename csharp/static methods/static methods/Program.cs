using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_methods
{
    class student
    {
        public int id;
        public static string schoolname = "Abc school";
        public static string schoolinfo()
        {
            return schoolname;
            

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student.schoolinfo();
            Console.WriteLine("schoolname is "+student.schoolname);
            Console.ReadLine();
        }
    }
}
