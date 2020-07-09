using System;
using System.Collections.Generic;
using System.Text;

namespace SpreadSheetReview
{
    static class Data
    {
        //Object initializer - not a method
        public static List<Product> products = new List<Product>()
        {
            new Product() { Name = "Keyboard", Price = 120.99m },
            new Product() { Name = "Monitor", Price = 159.99m },
            new Product() { Name = "Mouse", Price = 65.99m },
            new Product() { Name = "Desk", Price = 250.99m },
            new Product() { Name = "Power Supply", Price = 120.99m }
        };        
    }
}
