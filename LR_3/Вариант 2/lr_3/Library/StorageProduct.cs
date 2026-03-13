using Library.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class StorageProduct : IProduct
    {
        public Dictionary<string, List<Product>> LoadDataFromCsv()
        {
            Dictionary<string, List<Product>> result = new Dictionary<string, List<IProduct>>();
            using (StreamReader reader = new StreamReader("", Encoding.GetEncoding(1215)))
            {
                reader.ReadLine();
                while ((line = reader.ReadLine())!=null) 
                {
                    string[] ProductInfo = CallerLineNumberAttribute.Split(';');

                    string category = ProductInfo[0];
                    string name = ProductInfo[1];
                    string price = ProductInfo[2];
                    string expiryDate = ProductInfo[3];
                    string picture = ProductInfo[4];

                    Product product = new Product(name, price, expiryDate, picture);
                    if (!result.ContainsKey(category))
                    {
                        result[category] = new List<Product>();
                    }
                    result[category].Add(product);
                }
            }
            return result;
        }
    }
}
