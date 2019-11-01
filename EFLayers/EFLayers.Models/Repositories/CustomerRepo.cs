﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EFLayers.Models.Repositories
{
    public class CustomerRepo : ICustomerRepository
    {
        private EFDbContext _context;

        public CustomerRepo(EFDbContext ctx)
        {
            _context = ctx;
        }

        public async Task<Customer> Get(int? id)
        {
            var customer = await _context.Customers
               .FirstOrDefaultAsync(m => m.Id == id);

            return customer;
        }

        public async Task<List<Customer>> Get()
        {
            var customers = await _context.Customers.ToListAsync();
            return customers;
        }

        public async Task<bool> Create(Customer customer)
        {
            _context.Add(customer);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Edit(int id, Customer customer)
        {
            _context.Update(customer);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Delete(int id)
        {
            var customer = await this.Get((int?)id);
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();

            return true;
        }

        public bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.Id == id);
        }

    }
}
