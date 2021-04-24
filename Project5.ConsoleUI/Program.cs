
using Project5.Business;
using Project5.DataAccess;
using System;

namespace Project5.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new ProductDal());

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.Id + "-" + product.ProductName + "-" + product.UnitInStock);
            }

        }
    }
}
