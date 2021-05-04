using CustomMapping.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomMapping.DataAccess
{
    public interface IPersonelDal 
    {
        List<Personel> GetAll();
    }
}
