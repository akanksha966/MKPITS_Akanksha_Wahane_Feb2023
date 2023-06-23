namespace mvcexp1.Models
{
    public class Department
    {

        public int id;
        public string name;
        public string position;
        public string worktimedaily;
        public string companyaddress;

        //constructor used
        public Department(int id, string name, string position, string worktimedaily, string companyaddress)
        {
            this.id = id;
            this.name = name;
            this.position = position;
            this.worktimedaily = worktimedaily;
            this.companyaddress = companyaddress;

        }
        //creating property named Name and Age
        public int ID
        {
            get
            {
                return id;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Position
        {
            get
            {
                return position;
            }
        }
        public string Work
        {
            get
            {
                return worktimedaily;
            }
        }

        public string Comp
        {
            get
            {
                return companyaddress;
            }
        }



    }
}
