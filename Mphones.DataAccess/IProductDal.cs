using Mphones.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mphones.DataAccess
{
    public interface IProductDal
    {
        List<Product> GetAll();
        void Add(Product product);

    }
}
