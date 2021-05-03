using EntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.DataAccess
{
    public interface IProductDal
    {
        List<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }

}

