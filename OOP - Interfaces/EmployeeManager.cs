using System;
using System.Collections.Generic;
using System.Text;

namespace OOP___Interfaces
{
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Calisan eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Calisan güncellendi");
        }
    }
}
