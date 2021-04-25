using Mphones.Business;
using Mphones.DataAccess;
using System;

namespace Mphones.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new ProductDal());

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.Brand);
            }
        }
    }
}
