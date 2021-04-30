using Repository.Business;
using Repository.DataAccess;
using System;

namespace Repository.ConsoleUI
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
