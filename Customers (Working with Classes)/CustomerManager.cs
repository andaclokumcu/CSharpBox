using System;
using System.Collections.Generic;
using System.Text;

namespace Customers__Working_with_Classes_
{
    class CustomerManager
    {
       
        public CustomerManager()
        {
            
            customers = new List<Customer>()

            {
                new Customer { ID = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara", Email = "engin@" },
                new Customer { ID = 2, FirstName = "Derin", LastName = "Demirkan", City = "Eskişehir", Email = "derin@" },
                new Customer { ID = 3, FirstName = "Kerem", LastName = "Keser", City = "Bursa", Email = "kerem@" },
                new Customer { ID = 4, FirstName = "Aslı", LastName = "Yılmaz", City = "İzmir", Email = "aslı@" },
                new Customer { ID = 5, FirstName = "İpek", LastName = "Lokum", City = "İstanbul", Email = "ipek@" }

            };
        }
        
            List<Customer> customers;

            public List<Customer> GetAll()
            {
            return customers;
            }

            public void Add(Customer customer)
            {
                customers.Add(customer);
            }

        }
    }

