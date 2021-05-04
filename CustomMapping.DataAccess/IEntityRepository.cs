using CustomMapping.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomMapping.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll();
      
    }
}
