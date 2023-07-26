using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string,string> keys = new Dictionary<string,string>();
            //keys.Add("ashu", "wahane");
            //keys.Add("akanksha", "wahane");
            //Console.WriteLine(keys["Ashu"]);

            //Dictionary<string, string> domains = new Dictionary<string, string>();

            //domains.Add("de", "Germany");
            //domains.Add("sk", "Slovakia");
            //Console.WriteLine(domains["sk"]);

            Dictionary<string, string> domains = new Dictionary<string, string>();

            domains.Add("de", "Germany");
            domains.Add("sk", "Slovakia");
            domains.Add("us", "United States");
            domains.Add("ru", "Russia");
            domains.Add("hu", "Hungary");
            domains.Add("pl", "Poland");

            //Console.WriteLine(domains["sk"]);
            //Console.WriteLine("count is{0}",domains.Count);


            //Console.WriteLine("Dictionary has {0} items",
            // domains.Count);

            List<string> keys = new List<string>(domains.Keys);

            foreach (string key in keys)
            {
                Console.WriteLine("{0}", key);
            }

            Console.WriteLine("Values of the dictionary:");







        }
    }
}
