using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo01WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Demo01WebApp.Controllers
{
    public class CustomerEFController : Controller
    {
        public IActionResult Index()
        {
            var options = new DbContextOptionsBuilder<TestDBDbContext>()
                .Options;
            var context = new TestDBDbContext(options);
            var customers = context.Customers.ToList<Customer>();

            return View(customers);
        }
    }
}