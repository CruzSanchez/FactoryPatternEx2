using System;
using System.Collections.Generic;
using System.Text;

namespace SpreadSheetReview
{
    class ListDataAccess : DataAccess, IDataAccess
    {
        public override void GetProducts()
        {
            Console.WriteLine("Accessing your static list. . .");

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
            Console.WriteLine("Accessing your static list. . .");

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

            Console.WriteLine("Adding to your static list. . .");
            Data.products.Add(p);

        }
    }
}
