using System;
using System.Collections.Generic;
using System.Text;

namespace SpreadSheetReview
{
    class MongoDBDataAccess : DataAccess, IDataAccess
    {
        public override void GetProducts()
        {
            Console.WriteLine("Accessing your Mongo DataBase. . .");

            Console.WriteLine($"You have {Data.products.Count} products in stock.");
            Console.Write("They are: ");

            foreach (Product p in Data.products)
            {
                Console.Write($"{p.Name} : {p.Price,0:c} ");
                Console.WriteLine();
            }
        }

        public override void CreateProduct()
        {
            Console.WriteLine("Accessing your Mongo DataBase. . .");

            Product p = new Product();

            Console.WriteLine("Please give me the name of your product");
            p.Name = Console.ReadLine();

            Console.WriteLine("Please give me the price of your product");
            string userStringNumber = Console.ReadLine();
            decimal price;
            while (!decimal.TryParse(userStringNumber, out price))
            {
                Console.WriteLine("Invalid number please try again");
                userStringNumber = Console.ReadLine();
            }

            p.Price = price;

            Console.WriteLine("Adding your product to the Mongo DataBase . . .");
            Data.products.Add(p);
        }
    }
}
