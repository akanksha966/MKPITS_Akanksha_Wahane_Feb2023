using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstarction_class_and_method
{
    abstract class Account
    {
        public int bal=1000;
        public abstract  void BankDetails();


    }

    class Withdraw : Account
    {
        int amt = 400;


        public override void BankDetails()
        {

            int result = bal - amt;



        }




        class Deposit : Withdraw
        {
            
            int interest = 200;


            public override void BankDetails()
            {

                int result = bal + amt + interest;
                Console.WriteLine("deposit bal is " + result);




            }
        }


            internal class Program
            {
                static void Main(string[] args)
                {
                    Deposit deposit = new Deposit();
                    deposit.BankDetails();




                Withdraw w = new Withdraw();
                w.BankDetails();


                Console.WriteLine("withdraw bal is " +w. bal);





                       Console.ReadLine();


                }
            }
        }
    }

