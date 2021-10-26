using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicWebshop.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public double InStock { get; set; }
        public string Type { get; set; }
        public int PriceInEur { get; set; }
        public int PriceInCzk { get; set; }
        public Product(string name, string type, string description, int price, double inStock)
        {
            Name = name;
            Description = description;
            PriceInCzk = price;
            Price = PriceInCzk;
            InStock = inStock;
            Type = type;
            PriceInEur = PriceInCzk / 25;
        }
}
}
