using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_using_inheritance
{
    class employee///////base classs 
    {
        public float salary;
    }

    class programmer : employee /////child class or derived class
    {
        int id;
        int bonus;
       public void getdata(float salary,int id,int bonus)///using method and parameteres
        {
            this.salary = salary;
            this.id = id;
            this.bonus = bonus; 
        }

        public void displaydata()
        {
            Console.WriteLine("salary is " + salary);
            Console.WriteLine("id number is " + id);
            Console.WriteLine("bonus " + bonus);
            Console.ReadLine();

        }
    }
    

    internal class Program
    {
        static void Main(string[] args)
        {

            programmer stud=new programmer();

            stud.getdata(20000,1245,1000);
            stud.displaydata();
        }
    }
}
