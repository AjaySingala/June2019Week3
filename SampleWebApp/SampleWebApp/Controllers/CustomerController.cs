using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using SampleWebApp.Models;

namespace SampleWebApp.Controllers
{
    public class CustomerController : Controller
    {
        //[Route("/Customer/Search/{firstname}/{lastname}")]
        //[HttpGet("/Customer/Search/{firstname}/{lastname}")]
        public IActionResult Search(string firstname, string lastname)
        {
            ViewBag.Firstname = firstname;
            ViewBag.Lastname = lastname;

            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Get()
        {
            return View();
        }

        public IActionResult GetOne(int id)
        {
            ViewBag.CustomerId = id;
            ViewBag.Message = "This is the customer id";

            return View();
        }

        public IActionResult GetCustomer()
        {
            Customer customer = new Customer()
            {
                Id = 110,
                Firstname = "John",
                Lastname = "Smith"
            };

            return View(customer);
        }

        public IActionResult GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer() { Id = 110,Firstname = "John", Lastname = "Smith"},
                new Customer() { Id = 111,Firstname = "Mary",Lastname = "Jane"},
                new Customer() { Id = 112,Firstname = "Julia",Lastname = "Reese"}
            };

            return View(customers);
        }
    }
}