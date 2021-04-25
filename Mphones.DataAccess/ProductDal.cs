
using Mphones.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mphones.DataAccess
{
    public class ProductDal:IProductDal
    {
        List<Product> _products;

        public ProductDal()
        {
            _products = new List<Product>
            {
                 
                new Product{Id=1,Brand="Apple",Memory="128 GB", UnitPrice=7000,UnitsInStock=89},
                new Product{Id=2,Brand="Samsung",Memory="256 GB", UnitPrice=9000,UnitsInStock=92},
                new Product{Id=3,Brand="LG",Memory="64 GB", UnitPrice=5500,UnitsInStock=79},
                new Product{Id=4,Brand="Huawei",Memory="32 GB", UnitPrice=6000,UnitsInStock=29},
                new Product{Id=5,Brand="Vestel",Memory="16 GB", UnitPrice=2500,UnitsInStock=50},
            };
        }

        public void Add(Product product)
        {
            Console.WriteLine("Telefon Eklendi.");
        }

        public List<Product> GetAll()
        {
            return _products;
        }

       
    }
}
