namespace bankexampleusingdropdown.Models
{
    public class account
    {
        public int Accountno { get; set; }  
        public int amount { get; set; } 
        public transtype gettranstype { get; set; }

    }
    public enum transtype
    {
        deposit,withdrawl
    }
}
