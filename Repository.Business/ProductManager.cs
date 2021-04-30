using Repository.DataAccess;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Business
{
    public class ProductManager
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            ProductDal productDal = new ProductDal();
            return _productDal.GetAll();
        }
    }
}
