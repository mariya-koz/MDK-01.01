using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_3
{
    public class Product
    {
        private string name_;
        private double price_;
        private int expiryDate_;
        private string picture_;

        public Product(string name, double price, int date, string picture) 
        {
            name_ = name;
            price_ = price;
            expiryDate_ = date;
            picture_ = picture;
        }

        public string Name
        {
            get { return name_; }
        }

        public string Price
        {
            get { return price_.ToString(); }
        }

        public string Data
        {
            get { return expiryDate_.ToString(); }
        }
        public string Picture
        {
            get { return picture_; } 
        }
    }
}
