namespace mvcexp1.Models
{
    public class Person
    {
         string name;
        int age;
        //constructor used
        public Person(string name,int age) 
        {
            this.name = name;
            this.age = age;

        }
        //creating property named Name and Age
        public string Name
        {
            get { return name; }
        }
        public int Age
        {
            get
            {
                return age;
            }
        }

    }
}
