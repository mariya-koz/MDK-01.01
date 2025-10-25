using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            string slip = "спать";
                dict.Add(slip, new List<string>() { "кроватка", "одеялко", "подушка" });
                string eat = "кушать";
                dict.Add(eat, new List<string>() { "шавуха", "бутерброд", "чаёк" });
                string holidays = "выходные";
                dict.Add(holidays, new List<string>() { "спать", "кушать", "отдыхать" });
            Console.WriteLine(string.Join(", ", dict.Keys));
            
        }
    }
}
