using System;

namespace OOP___Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();
            personManager.Add();

            PersonManager personManager1 = new PersonManager();
            personManager.Update();

            CustomerManager customerManager = new CustomerManager();
            customerManager.GetBestCustomer();

            EmployeeManager employeeManager = new EmployeeManager();
            employeeManager.GetBestEmployee();

        }
    }
}
