using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleWebApp.Models;

namespace SampleWebApp.Controllers
{
    public class NewCustomerController : Controller
    {
        public IActionResult Index()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer() { Id = 110,Firstname = "John", Lastname = "Smith"},
                new Customer() { Id = 111,Firstname = "Mary",Lastname = "Jane"},
                new Customer() { Id = 112,Firstname = "Julia",Lastname = "Reese"}
            };

            return View(customers);
        }

        public IActionResult Get()
        {
            Customer customer = new Customer()
            {
                Id = 110,
                Firstname = "John",
                Lastname = "Smith"
            };

            return View(customer);
        }
    }
}