using Gamer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gamer.DataAccess
{
    public class UserDal : IUserDal
    {
        IUserValidationService _userValidationService;

        public UserDal(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        List<User> _user;

        public UserDal()
        {
            _user = new List<User>
            {
                new User { Id = 1, FirstName = "Andaç", LastName = "Lokumcu", BirthYear = 1996, IdentityNumber = 111111 },
                new User { Id = 2, FirstName = "İpek", LastName = "Lokumcu", BirthYear = 2001, IdentityNumber = 222222 },
                new User { Id = 3, FirstName = "Özlem", LastName = "Lokumcu", BirthYear = 1972, IdentityNumber = 333333 },
                new User { Id = 4, FirstName = "Ayhan", LastName = "Lokumcu", BirthYear = 1966, IdentityNumber = 444444 },

            };
        }
        public void Add(User user)
        {
            if (_userValidationService.Validate(user) == true)
            {
                Console.WriteLine("Kayıt oldu.");
            }
            else
            {
                Console.WriteLine("Doğrulama başarız oldu. Kayıt başarısız.");

            }
        }

        public void Delete(User user)
        {
            Console.WriteLine("Kayıt silindi.");
        }

        public void Update(User user)
        {
            Console.WriteLine("Kayıt güncellendi.");
        }

        public List<User> GetAll()
        {
            return _user;
        }

        

        
    }
}
