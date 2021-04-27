using Project4.DataAccess;

using Project5.DataAccess;
using Project5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project5.Business
{
    public class ProductManager
    {
        DataAccess.IProductDal _productDal;

        public ProductManager(DataAccess.IProductDal productDal)
        {
            _productDal = productDal;

        }

        public List<Product> GetAll()
        {
            //iş kodları,kontrol kodları yazılır

            return _productDal.GetAll();
        }
    }
}
