﻿using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product() { ProductName = "Laptop", UnitPrice = 5000, UnitInStock = 5 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}
