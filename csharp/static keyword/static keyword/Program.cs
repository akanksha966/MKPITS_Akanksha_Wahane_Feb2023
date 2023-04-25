using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_keyword
{
    class account
    {
        public int actno;
        public string name;
        public static float rof=4.5f;
            //rate of interest
          public account(int actno,string name)//method
        {
            this.actno = actno;
            this.name=name;
        }
        public void display()
        {
            Console.WriteLine("account no us " + actno);
            Console.WriteLine("account name " + name);
            Console.WriteLine("rate of interest is " + rof);


        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            account act=new account(1234,"ashu");
            act.display();
            account act2 = new account( 22223,"asjs");
            act.display();
            Console.ReadLine();
        }
    }
}
