using Gamer.DataAccess;
using Gamer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gamer.Business
{
    public class UserManager
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
      

        public List<User>GetAll()
        {
            return _userDal.GetAll();
        }

        
    }


}

