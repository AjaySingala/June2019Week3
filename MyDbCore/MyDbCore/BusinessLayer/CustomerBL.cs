using Microsoft.EntityFrameworkCore;
using MyDbCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDbCore.BusinessLayer
{
    public interface ICustomerBL
    {
        IList<Customer> Get();
        Customer Get(int? id);
    }

    public class CustomerBL : ICustomerBL
    {
        private MyDbContext _context;

        public CustomerBL()
        {
            var options = new DbContextOptionsBuilder<MyDbContext>().Options;
            _context = new MyDbContext(options);
        }

        public IList<Customer> Get()
        {
            var customers = _context.Customers.ToList();

            return customers;
        }

        public Customer Get(int? id)
        {
            var customer = _context.Customers.Find(id);

            return customer;
        }
    }
}
