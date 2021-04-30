using System;
using System.Collections.Generic;
using Repository.Entities;
using System.Text;

namespace Repository.DataAccess
{
    public class ProductDal : IProductDal
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

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
