using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace another_ex_single_label
{

    class newjoing
    {
        public string name;
        public int age;
        public void getdata(string name, int age)
        {
            this.name = name;
            this.age = age;

        }

        public void display()
        {
            Console.WriteLine("name  " + name);
            Console.WriteLine("age  " + age);
            
        }


        class employee : newjoing
        {
            public int empno;
            public float salary;


            public void getdata2(int empno, float salary)
            {
                this.empno = empno;
                this.salary = salary;
            }



            public void display2()
            {
                Console.WriteLine("empno " + empno);
                Console.WriteLine("salary  " + salary);
                Console.ReadLine();
            }



        }

        internal class Program
        {
            static void Main(string[] args)
            {
                employee emp = new employee();
                emp.getdata("ashu", 23);
                emp.display();
                emp.getdata2(1452, 10000);
                emp.display2();


            }
        }
    }
}
