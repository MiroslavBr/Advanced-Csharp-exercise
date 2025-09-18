using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Product>> storeinventory = new();

            string data = string.Empty;
            while ((data = Console.ReadLine()) != "Revision")
            {
                string[] dataParts = data.Split(", ");

                string shopName = dataParts[0];
                string productName = dataParts[1];
                decimal procuctPrice = decimal.Parse(dataParts[2]);

                Product product = new(procuctPrice, productName);
                if (!storeinventory.ContainsKey(shopName))
                {
                    storeinventory[shopName] = new List<Product>();
                }
                storeinventory[shopName].Add(product);
            }

            storeinventory = storeinventory.OrderBy(x => x.Key).ToDictionary();
            foreach ((string shopName, List<Product> products) in storeinventory)
            {
                Console.WriteLine($"{shopName}->");
                foreach (Product product in products)
                {
                    Console.WriteLine($"Product: {product.Name}, Price: {product.Price.ToString().Trim('0')}");
                }
            }
        }

    }

    class Product
    {
        public Product(decimal price, string name)
        {
            Price = price;
            Name = name;
        }
        public decimal Price { get; set; }
        public string Name { get; set; }
    }
}
