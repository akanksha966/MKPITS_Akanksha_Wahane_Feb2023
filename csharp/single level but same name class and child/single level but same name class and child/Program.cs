using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace another_ex_single_label
{

    class person
    {
        public string name;
        public string address;
        public string city;
        public long phoneno;
        public int age;
        public void getdata(string name,string address,string city,long phoneno, int age)
        {
            this.name = name;
            this.address = address;
            this.city = city;
            this.phoneno = phoneno;
             this.age = age;

        }

        public void display()
        {
            Console.WriteLine("name  " + name);
            Console.WriteLine("address is  " + address);
            Console.WriteLine("city " + city);
            Console.WriteLine("phone no  " + phoneno);



            Console.WriteLine("age  " + age);

        }


        class student : person
        {
            public int rno;
            public string course;
          

            public double admission_fees;


            public void getdata(int rno, string course,double admission_fees, string name,string address,string city,long phoneno,int age)
            {
                this.rno = rno;
                this.course = course;
                this.admission_fees = admission_fees;

                getdata(name,address,city,phoneno,age); 
            }



            public void display()
            {
                base.display();
                Console.WriteLine("rno is " + rno);
                Console.WriteLine("course  " + course);

                Console.WriteLine("admission fees " + admission_fees);

               
            }

        }

        internal class Program
        {
            static void Main()
            {
                student emp = new student();
                emp.getdata(4,"DotNet",75000.00,"ashu","Gaytri mandir"," nagpur ",4587125478,24);
                emp.display();
                Console.ReadLine();


            } 
        }
    }
}
