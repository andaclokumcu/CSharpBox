using Mphones.DataAccess;
using Mphones.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mphones.Business
{
    public class ProductManager
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product>GetAll()
        {
            return _productDal.GetAll();
        }
    }
}
