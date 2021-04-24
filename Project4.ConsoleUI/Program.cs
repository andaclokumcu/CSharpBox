using Project4.Business;
using Project4.Entities;
using System;

namespace Project4.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager();

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.Id + "-" + product.ProductName + "-" + product.UnitInStock);
            }

            
        }
    }
}
