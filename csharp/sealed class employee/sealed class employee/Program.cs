using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_class_employee
{
    sealed class employee
    {
        public void showdata()
        {
            Console.WriteLine("hello");
            Console.ReadLine();//do not create a child class of employee because we can use
        }                           //sealed keyword
    }
    //class emp:employee
    //{
       // public void showdata()
        //{
            //Console.WriteLine("hello");
        //}

    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            employee employee = new employee(); 
            employee.showdata();    
        }
    }
}
