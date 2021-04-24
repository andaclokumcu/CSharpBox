using System;

namespace OOP___Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1;
            Console.WriteLine(product.Id);

            product.UnitInStock = 500;
            Console.WriteLine(product.UnitInStock);

            
            Console.WriteLine(product.UnitPrice);
        }
    }
}
