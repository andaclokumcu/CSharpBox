using Project4.DataAccess;
using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project4.Business
{
    public class ProductManager
    {
        public ProductManager(global::Project5.DataAccess.ProductDal productDal)
        {
        }

        public List<Product> GetAll()
        {
            ProductDal productDal = new ProductDal();
            //iş kodları, kontrol kodları buraya yazılır
            return productDal.GetAll();
        }
    }
}
