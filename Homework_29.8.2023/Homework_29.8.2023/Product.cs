using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_29._8._2023
{
     class Product
    {
        public int Id;
        public string BrandName;
        public string Model;
        public double Price;
        public double Cost;
        public int Count;
        public double Income;

        public Product(int id, string brandName, string model, double price,double cost, int count)
        {
            Id = id;
            BrandName = brandName;
            Model = model;
            Price = price;
            Cost = cost;
            Count = Math.Max(count, 0); 
            Income = 0;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Product ID: {Id}");
            Console.WriteLine($"Brand: {BrandName}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Cost {Cost}");
            Console.WriteLine($"Count: {Count}");
            Console.WriteLine($"Income: {Income}");

        }
        public void Sale(int quantity)
        {
            Console.WriteLine($"Quantity {quantity}");
            if (quantity <= 0)
            {
                Console.WriteLine("Invalid quantity. Quantity must be positive.");
            }
            else if (quantity > Count)
            {
                Console.WriteLine("Not enough products available for sale.");
            }
            else
            {
                double totalSalePrice = Price * quantity;
                double totalCost = Cost * quantity;
               
                if (totalSalePrice >= totalCost)
                {
                    Console.WriteLine("Sale successful.");
                    Income += totalSalePrice - totalCost;
                    Count -= quantity;
                    
                    Console.WriteLine($"Total Sale Price: {totalSalePrice}");
                    Console.WriteLine($"Total Cost {totalCost}");
                }
                else
                {
                    Console.WriteLine("Sale not profitable. Product(s) not sold.");
                }

            }
        }
     }
}
