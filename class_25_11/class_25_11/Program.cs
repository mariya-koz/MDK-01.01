using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace class_25_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.SetName("Mercedes");
            p1.SetPrice(1000000);

            Product p2 = new Product();
            p2.SetName("VAZ");
            p2.SetPrice(1000000);


            Warehouse w1 = new Warehouse();
            w1.SetNumber("123");
            w1.SetLocation("Studencheskaya, 3");
            w1.SetProducts(p1, 2);
            w1.SetProducts(p2, 5);


        }
    }
}
