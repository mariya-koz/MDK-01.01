using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_25_11
{
    class Product
    {
        private string name_;
        private double price_;
        public double GetPrice()
        {
            return price_;
        }
        public string GetName()
        {
            return name_;
        }


        public void SetName(string name)
        {
            name = name_;
        }

        public void SetPrice(double price)
        {
            price = price_;
        }
    }
}
