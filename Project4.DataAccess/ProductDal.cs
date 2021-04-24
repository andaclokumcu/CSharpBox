using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project4.DataAccess
{
    public class ProductDal
    {
        List<Product> _products;

        public ProductDal()
        {
            _products = new List<Product>
            {
                new Product{Id=1,ProductName="Acer Bilgisayar",QuantityPerUnit="32 gb ram",UnitPrice=1000,UnitInStock=2},
                new Product{Id=2,ProductName="Asus Bilgisayar",QuantityPerUnit="32 gb ram",UnitPrice=1500,UnitInStock=3},
                new Product{Id=3,ProductName="Hp Bilgisayar",QuantityPerUnit="64 gb ram",UnitPrice=1250,UnitInStock=0},
                new Product{Id=4,ProductName="Mac Bilgisayar",QuantityPerUnit="128 gb ram",UnitPrice=1800,UnitInStock=5},
                new Product{Id=5,ProductName="Dell Bilgisayar",QuantityPerUnit="32 gb ram",UnitPrice=1950,UnitInStock=1},

            };
        }

        public List<Product> GetAll()
        {
            return _products;
        }

    }
}
