using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.DataAccess
{
    public interface IEntityRepository<T>
    {
        List<T> GetAll();
        List<T> GetById(int Id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
