using System;
using System.Collections.Generic;
using System.Text;

namespace OOP___Interfaces
{
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
           

    }
}
