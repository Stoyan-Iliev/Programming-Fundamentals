﻿namespace _05._Shopping_Spree
{
    public class Product
    {
        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
