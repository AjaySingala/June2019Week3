using MyDbCore.BusinessLayer;
using MyDbCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDbCore.TestSimulation
{
    public class CustomerTestBL : ICustomerBL
    {
        public IList<Customer> Get()
        {
            var customers = new List<Customer>()
            {
                new Customer{ Id = 101, Firstname = "John", Lastname = "Smith" },
                new Customer{ Id = 102, Firstname = "Mary", Lastname = "Jane" },
                new Customer{ Id = 103, Firstname = "Fred", Lastname = "Kruger" }
            };
            return customers;
        }

        public Customer Get(int? id)
        {
            var customer = new Customer
            {
                Id = 999,
                Firstname = "Ajay",
                Lastname = "Singala"
            };

            return customer;
        }
    }
}
