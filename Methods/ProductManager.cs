using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Ürün sepete eklendi : " + product.ProductName);
        }
    }
}
