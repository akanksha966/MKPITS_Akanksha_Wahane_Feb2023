using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace read_only_properties
{
    class employee
    {
        private int subjecatmarks=90;
        public int _subjecatmarks
        {
            get
            {
                return subjecatmarks;   
            }
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee employee = new employee();
            Console.WriteLine("marks is " + employee._subjecatmarks);
            Console.ReadLine();
        }
    }
}
