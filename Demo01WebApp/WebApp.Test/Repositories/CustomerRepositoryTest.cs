using Demo01WebApp.Models;
using Demo01WebApp.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp.Test.Repositories
{
    public class CustomerRepositoryTest : ICustomerRepository
    {
        public Customer Get(int id)
        {
            return new Customer()
            {
                Id = id,
                Firstname = "John",
                Lastname = "Smith"
            };
        }
    }
}
