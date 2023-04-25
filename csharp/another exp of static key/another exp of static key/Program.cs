using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_keyword
{
    class account
    {
        public int empno;
        public string name;
        public static string companyname="trust";
        //rate of interest
        public account(int empno, string name)//method
        {
            this.empno= empno;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine("account no us " + empno);
            Console.WriteLine("account name " + name);
            Console.WriteLine("account name " + companyname);



        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            

            account act = new account(1234, "ashu");
            act.display();
            Console.WriteLine("==========");
            account act2 = new account(22223, "asjs");
            act.display();
            Console.ReadLine();
        }
    }
}
