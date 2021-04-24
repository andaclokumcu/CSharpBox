using System;
using System.Collections.Generic;
using System.Text;

namespace Veterinary
{
    class VetManager
    {
        public VetManager()
        {
            vets = new List<Vet>()
 
            {
            new Vet { ID=1, AnimalName = "Tukaş", PersonalName = "Ali", ProductName="Köpek Maması" },
            new Vet { ID = 2, AnimalName = "Bulut", PersonalName = "Mehmet", ProductName="Kedi Maması" },
            new Vet { ID = 3, AnimalName = "Köpük", PersonalName = "Ahmet", ProductName="Kuş Maması" }

            
            };
        }

        List<Vet> vets;
        public List<Vet> GetAll()
        {
            return vets;
        }

        public void Add(Vet vet)
        {
            vets.Add(vet);
        }

    }
}

