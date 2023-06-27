using System.Runtime.ConstrainedExecution;

namespace productlistmvc.Models
{
    public class Class
    {
//        -wap to accept empname, basic salary and designation
//and display bonus = 10000 for manager , 5000 for clerk and 1000 for peon
//and also display total salary
public string empname { get; set; }     
        public int salary { get; set; }
        public string designation { get; set; }
        public int bonus { get; set; }
        public double totalsalary { get; set; }    

    }
}
