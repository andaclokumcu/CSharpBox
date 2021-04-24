using System;

namespace OOP___Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //IPersonmanager customermanager  = new CustomerManager();
            //customerManager.Add(); ---> "Müşteri eklendi." verir

            //IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Add(); ---> "Çalışan eklendi." verir

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());  //(new EmployeeManager());  //(new CustomerManager());
            
            //eklemek istediğimiz kişiyi stajyer,çalışan ya da müşteri yukarıdaki şekilde ekleyebiliriz.
             
        }
    }
}
