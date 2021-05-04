using CustomMapping.Business;
using CustomMapping.DataAccess;
using System;

namespace CustomMapping.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonelManager personelManager = new PersonelManager(new PersonelDal());

            foreach (var personel in personelManager.GetAll())
            {
                Console.WriteLine("{0}/{1}/{2}", personel.Id, personel.Name,personel.Surname);
            }
        }
    }
}
