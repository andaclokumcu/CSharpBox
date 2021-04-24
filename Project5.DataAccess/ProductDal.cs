﻿using Project5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project5.DataAccess
{
    public class ProductDal:IProductDal
    {
        List<Product> _products;

        public ProductDal()
        {
            _products = new List<Product>
            {
                new Product{Id=1,ProductName="Acer ado Bilgisayar",QuantityPerUnit="32 gb ram",UnitPrice=1000,UnitInStock=2},
                new Product{Id=2,ProductName="Asus ado Bilgisayar",QuantityPerUnit="32 gb ram",UnitPrice=1500,UnitInStock=3},
                new Product{Id=3,ProductName="Hp ado Bilgisayar",QuantityPerUnit="64 gb ram",UnitPrice=1250,UnitInStock=0},
                new Product{Id=4,ProductName="Mac ado Bilgisayar",QuantityPerUnit="128 gb ram",UnitPrice=1800,UnitInStock=5},
                new Product{Id=5,ProductName="Dell ado Bilgisayar",QuantityPerUnit="32 gb ram",UnitPrice=1950,UnitInStock=1},

            };
        }

       
        public void Add(Product product)
        {
            Console.WriteLine("Ado net ile eklendi");
        }

        public List<Product> GetAll()
        {
            return _products;
        }


        //public class EfProductDal : IProductDal
        //{
        //List<Product> _products;

        //public ProductDal()
        //{
        //_products = new List<Product>
        //{
        //new Product{Id=1,ProductName="Acer Ef Bilgisayar",QuantityPerUnit="32 gb ram",UnitPrice=1000,UnitInStock=2},
        //new Product{Id=2,ProductName="Asus Ef Bilgisayar",QuantityPerUnit="32 gb ram",UnitPrice=1500,UnitInStock=3},
        //new Product{Id=3,ProductName="Hp Ef Bilgisayar",QuantityPerUnit="64 gb ram",UnitPrice=1250,UnitInStock=0},
        //new Product{Id=4,ProductName="Mac Ef Bilgisayar",QuantityPerUnit="128 gb ram",UnitPrice=1800,UnitInStock=5},
        //new Product{Id=5,ProductName="Dell Ef Bilgisayar",QuantityPerUnit="32 gb ram",UnitPrice=1950,UnitInStock=1},

        //};
        //}

        //public void Add(Product product)
        //{
        //Console.WriteLine("Ef ile eklendi");
        //}

        //public List<Product> GetAll()
        //{
        //return _products;
        //}
    }
}
