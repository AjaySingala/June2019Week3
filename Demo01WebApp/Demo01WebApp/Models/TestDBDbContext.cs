using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo01WebApp.Models
{
    public class TestDBDbContext : DbContext
    {
        public TestDBDbContext(DbContextOptions<TestDBDbContext> context)
            :base(context)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"data source=.\SQLEXPRESS;initial catalog=TestDB;integrated security=True;MultipleActiveResultSets=True;");
            }
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
