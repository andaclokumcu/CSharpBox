using Gamer.Business;
using Gamer.DataAccess;
using Gamer.Entities;
using System;

namespace Gamer.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            UserManager userManager = new UserManager(new UserDal());

            foreach (var user in userManager.GetAll())
            {
                Console.WriteLine(user.FirstName);
            }

            UserDal userDal = new UserDal(new UserValidationManager());
            userDal.Add(new User
            {
                Id = 6,
                BirthYear = 1985,
                FirstName = "Ceyda",
                LastName = "Lokumcu",
                IdentityNumber = 666666
            });

            Console.WriteLine("Hoşgeldiniz");


        } 

    }




    
    
}
