using EFLayers.Models;
using EFLayers.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLayers.Tests.Repositories
{
    public class CustomerTestRepository : ICustomerRepository
    {
        private static List<Customer> _customers = new List<Customer>()
        {
            new Customer()
            {
                Id = 101,
                Firstname = "John",
                Lastname = "Smith"
            },
            new Customer()
            {
                Id = 102,
                Firstname = "Mary",
                Lastname = "Jane"
            },
            new Customer()
            {
                Id = 103,
                Firstname = "Joe",
                Lastname = "Salazar"
            }
        };

    public async Task<bool> Create(Customer customer)
    {
        _customers.Add(customer);
        return true;
    }

    public bool CustomerExists(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Edit(int id, Customer customer)
    {
        throw new NotImplementedException();
    }

    public async Task<Customer> Get(int? id)
    {
        var customer = _customers.Where(c => c.Id == (int)id)
            .SingleOrDefault<Customer>();
        return customer;
    }

    public async Task<List<Customer>> Get()
    {
        return _customers;
    }
}
}
