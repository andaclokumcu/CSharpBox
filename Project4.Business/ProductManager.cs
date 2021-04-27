using Project4.DataAccess;
using Project4.Entities;
using System.Collections.Generic;

namespace Project4.Business
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
