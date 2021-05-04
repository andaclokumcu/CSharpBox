using CustomMapping.DataAccess;
using CustomMapping.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomMapping.Business
{
    public class PersonelManager : IPersonelService
    {
        IPersonelDal _personelDal;

        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }
        public List<Personel> GetAll()
        {
            return _personelDal.GetAll();
        }
    }
}
