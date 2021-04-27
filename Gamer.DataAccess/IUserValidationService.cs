using Gamer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gamer.DataAccess
{
    public interface IUserValidationService
    {
        bool Validate(User user);
    }
}
