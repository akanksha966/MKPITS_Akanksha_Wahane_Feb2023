using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace another_exap_of_enum_data_type
{
    public class perimetr
    {
        public enum shape
        {
            circle,square
        }
        public void peri(int val,shape s1)//checking for shape to be circle

        {
            if(s1==0)
            {
                Console.WriteLine(" circle is " + 2 * 3.14 * val);
            }
            else
            {
                Console.WriteLine(" circle is " + 4*val);
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            perimetr a1= new perimetr();
            a1.peri(3,perimetr.shape.circle);
            a1.peri(3, perimetr.shape.square);
            Console.ReadLine(); 




        }
    }
}
