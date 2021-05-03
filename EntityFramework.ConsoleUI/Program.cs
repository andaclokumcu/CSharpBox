using EntityFramework.Business;
using EntityFramework.DataAccess;
using EntityFramework.Entities;
using System;

namespace EntityFramework.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new ProductDal());

            productManager.Add(new Product { ProductName = "Masa", CategoryId = 1, QuantityPerUnit = "4 ayaklı masa", UnitPrice = 1000, UnitsInStock = 10 });

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
