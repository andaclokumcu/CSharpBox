using Project5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project5.DataAccess
{
    public interface IProductDal
    {
        List<Product> GetAll();
        void Add(Product product);
    }
}
