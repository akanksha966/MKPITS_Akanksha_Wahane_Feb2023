namespace OrderDetails.Models
{
    public class order
    {
        public int orderno { get; set; }    
        public string custname { get; set; }    
        public double price { get; set; }
        public double quantity { get; set; }  
        public name getname { get; set; }
    }
    public enum name
    {
        mouse,keyboard,ram,monitor
    }
}
