using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEx2ConsoleUI
{
    class ListDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product() { Name = "Pearl Jam Ten", Price = 12.99m },
                new Product() { Name = "Megaman X Collection", Price = 59.99m },
                new Product() { Name = "Keyboard", Price = 120.99m },
                new Product() { Name = "Monitor", Price = 159.99m },
                new Product() { Name = "Mouse", Price = 65.99m },
                new Product() { Name = "Desk", Price = 250.99m },
                new Product() { Name = "Power Supply", Price = 120.99m }
        };

        public void SaveData()
        {
            Console.WriteLine("Saving your static list. . .");
        }

        /// <summary>
        /// This method will return a static list of Products. The data will never change
        /// </summary>
        /// <returns>List<Product></returns>
        public List<Product> LoadData()
        {
            Console.WriteLine("Accessing your static list. . .");

            return Products;
        }
    }
}
