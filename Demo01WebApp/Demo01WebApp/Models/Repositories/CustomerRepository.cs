using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo01WebApp.Models.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public Customer Get(int id)
        {
            return new Customer() {
                Id = id,
                Firstname = "Ajay",
                Lastname = "Singala"
            };
        }
    }
}
