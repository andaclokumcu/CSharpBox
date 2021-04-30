﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1,CategoryName="Bilgisayar"},
                new Category{CategoryId=2,CategoryName="Telefon"},
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1,ProductName="Acer Laptop",QuantityPerUnit="32 GB Ram",UnitPrice=10000,UnitsInStock=5},
                new Product{ProductId=2,CategoryId=1,ProductName="Asus Laptop",QuantityPerUnit="16 GB Ram",UnitPrice=8000,UnitsInStock=3},
                new Product{ProductId=3,CategoryId=1,ProductName="Hp Laptop",QuantityPerUnit="8 GB Ram",UnitPrice=6000,UnitsInStock=2},
                new Product{ProductId=4,CategoryId=2,ProductName="Smasung Telefon",QuantityPerUnit="4 GB Ram",UnitPrice=5000,UnitsInStock=15},
                new Product{ProductId=5,CategoryId=2,ProductName="Apple Telefon",QuantityPerUnit="4 GB Ram",UnitPrice=8000,UnitsInStock=0},
            };

            var result = products.Where(product => product.UnitPrice > 4000 && product.UnitsInStock>1);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }

           
            
        }

       
        static List<Product> GetProductsLinq (List<Product>products)
        {
            return products.Where(product => product.UnitPrice > 4000 && product.UnitsInStock>1).ToList();
        }

    }
}
