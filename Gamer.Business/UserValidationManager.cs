using Gamer.DataAccess;
using Gamer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gamer.Business
{
    public class UserValidationManager: IUserValidationService
    {
        public bool Validate(User user)
        {
            if (user.BirthYear == 1985 && user.FirstName == "Ceyda"
                && user.LastName == "Lokumcu" && user.IdentityNumber == 666666)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
