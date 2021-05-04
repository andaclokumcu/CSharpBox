using CustomMapping.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomMapping.DataAccess
{
    public class PersonelDal : IPersonelDal
    {
        public PersonelDal()
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

        public List<Personel> GetAll()
        {
            using(NorthwindContext context=new NorthwindContext())
            {
                return context.Personels.ToList();
            }
        }
    }
}
