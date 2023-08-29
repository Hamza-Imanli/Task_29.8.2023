using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_29._8._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(2, "Chevrolet", "Cruze", 16205.3, 13000, 5);

            product.GetInfo();

            Console.WriteLine("\nPerforming a sale...\n");
            product.Sale(2);
            Console.WriteLine($"Income {product.Income}");

        }
    }
}
