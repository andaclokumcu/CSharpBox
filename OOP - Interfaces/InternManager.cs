using System;
using System.Collections.Generic;
using System.Text;

namespace OOP___Interfaces
{
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi.");
        }
    }
}
