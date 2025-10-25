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
            Console.WriteLine("выберите одну из указанных категорий");
            string x = Console.ReadLine();
            if (x == "спать") 
            {
                List<string> d = dict[slip];
                Console.WriteLine(string.Join(", ", d));
            }
            else if (x== "кушать") 
            {
                List<string> d = dict[eat];
                Console.WriteLine(string.Join(", ", d));
            }
            else
            {
                List<string> d = dict[holidays];
                Console.WriteLine(string.Join(", ", d));
            }
        }
    }
}
