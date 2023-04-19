using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creare_two_windows_from_addition
{
    class addition
    {

        int num1;
        int num2;
        char op;
        int result=0;
        public int calculate(int num1,int num2,char op)
        {
            switch(op)
            {
                case '+':
                    result=num1 + num2;
                    break;


                case '-':
                    result = num1 -num2;
                    break;


                case '*':
                    result = num1 * num2;
                    break;
            }
            return result;
        }
        
            
            


        }

    }
    
    

