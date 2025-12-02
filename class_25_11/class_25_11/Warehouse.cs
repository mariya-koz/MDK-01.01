using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_25_11
{
    class Warehouse
    {
        private string number_;
        private string location_;
        private Dictionary<Product, int> products_;
       
        public void SetNumber(string number)
        {
            number = number_;
        }

        public void SetLocation(string location)
        {
            location = location_;
        }

        public void SetProducts (Product p, int i)
        {
            products_.Add(p, i);
        }

        public void GetNumber()
        {
            return;
        }

        public void GetLocation()
        {
            return;
        }

        public void GetProductQantity()
        {
            foreach (Product product in products_.Keys)
            {
                Console.WriteLine($"Товар: {product.GetName() + " " + products_[product]} шт.");
            }
        }

        public void SumPrice()
        {
            double sum = 0;
            foreach (Product product in products_.Keys)
            {
                sum += product.GetPrice() * products_[product];
            }
            Console.WriteLine(sum);
        }
    }
}
