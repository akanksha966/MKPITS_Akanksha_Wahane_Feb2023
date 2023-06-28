namespace CourseDetailsusingmvc.Models
{
    public class course
    {
        public string username { get; set; }
        public string gender{ get; set; }
        public bool batch1 { get; set; }  
        public bool batch2 { get; set; }
        public city getcity { get;set; }
    }
    public enum city
    {
        nagpur,mumbai,pune,bhandara
    }
}


