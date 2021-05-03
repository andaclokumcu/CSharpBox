using EntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFramework.DataAccess
{
    public class ProductDal : IProductDal
    {
        public ProductDal()
        {
            // _products = new List<Product>
            //{
            // new Product{ProductId=1,ProductName="Acer ado Bilgisayar",QuantityPerUnit="32 gb ram",UnitPrice=1000,UnitInStock=2},
            //new Product {ProductId=2,ProductName="Asus ado Bilgisayar",QuantityPerUnit="32 gb ram",UnitPrice=1500,UnitInStock=3},
            //new Product {ProductId=3,ProductName="Hp ado Bilgisayar",QuantityPerUnit="64 gb ram",UnitPrice=1250,UnitInStock=0},
            //new Product {ProductId=4,ProductName="Mac ado Bilgisayar",QuantityPerUnit="128 gb ram",UnitPrice=1800,UnitInStock=5},
            //new Product {ProductId=5,ProductName="Dell ado Bilgisayar",QuantityPerUnit="32 gb ram",UnitPrice=1950,UnitInStock=1},
            //
            // };
        }

            public void Add(Product product)
            {
                using (NorthwindContext context = new NorthwindContext())
                {
                context.Products.Add(product);
                context.SaveChanges();
               
                }
            }

            public void Delete(Product product)
            {
                    using (NorthwindContext context = new NorthwindContext())
                 {
                context.Products.Remove(context.Products.SingleOrDefault(p => p.ProductId == product.ProductId));
                 }
            }

            public List<Product> GetAll()
            {
                using(NorthwindContext context=new NorthwindContext())
                {
                return context.Products.ToList();
                }
            }

            public Product GetById(int id)
            {
                using (NorthwindContext context = new NorthwindContext())
                {
                return context.Products.SingleOrDefault(p => p.ProductId == id);
                 }
            }

            public void Update(Product product)
            {
                    using (NorthwindContext context = new NorthwindContext())
                    {
                        var productToUpdate = context.Products.SingleOrDefault(p => p.ProductId == product.ProductId);
                        productToUpdate.ProductName = product.ProductName;
                        productToUpdate.QuantityPerUnit = product.QuantityPerUnit;
                        productToUpdate.UnitPrice = product.UnitPrice;
                        productToUpdate.UnitsInStock = product.UnitsInStock;
                        productToUpdate.CategoryId = product.CategoryId;
                        context.SaveChanges();
                 
                    }
                
            }
        }
    }
