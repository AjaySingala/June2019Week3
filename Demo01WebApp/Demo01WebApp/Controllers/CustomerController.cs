using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo01WebApp.Filters;
using Demo01WebApp.Models;
using Demo01WebApp.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Demo01WebApp.Controllers
{
    public class CustomerController : Controller
    {
        ICustomerRepository _repo;

        public CustomerController(ICustomerRepository repository)
        {
            _repo = repository;
        }

        public IActionResult CreateOrder()
        {
            //var order = new Order()
            //{
            //    Id = 901,
            //    CustomerId = 101,
            //    OrderDate = DateTime.Now,

            //    Customer = new Customer()
            //    {
            //        Id = 101,
            //        Firstname = "John",
            //        Lastname = "Smith"
            //    }
            //};

            return View();
        }


        [HttpPost]
        public IActionResult Create(Customer newCustomer)
        {

            return View();
        }

        public IActionResult Create()
        {

            return View();
        }

        public IActionResult GetAllCustomers()
        {
            var customers = new List<Customer>()
            {
                new Customer { Id = 101, Firstname = "John", Lastname = "Smith"},
                new Customer { Id = 102, Firstname = "Mary", Lastname = "Jane"},
                new Customer { Id = 103, Firstname = "Joe", Lastname = "Skar"},
                new Customer { Id = 104, Firstname = "Ben", Lastname = "Smith"},
                new Customer { Id = 105, Firstname = "Jess", Lastname = "Will"}
            };

            return View(customers);
        }

        public IActionResult DisplayOrder()
        {
            var order = new Order()
            {
                Id = 901,
                CustomerId = 101,
                OrderDate = DateTime.Now
            };

            ViewData["DisplayId"] = false;

            return View(order);
        }

        public IActionResult Test()
        {
            ViewData["Firstname"] = "John";
            ViewData["Lastname"] = "Smith";

            var customer = new Customer()
            {
                Id = 101,
                Firstname = "John",
                Lastname = "Smith"
            };

            ViewData["Customer"] = customer;

            return View(customer);
        }

        //[GlobalAttribute("MyKey", "MyValue")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Get(int? id)
        {
            Customer customer = null;
            if (id == null)
            {
                ViewData["Message"] = "Id not specified";
            }
            else
            {
                customer = new Customer()
                {
                    Id = (int)id,
                    Firstname = "John",
                    Lastname = "Smith"
                };
            }
            return View(customer);
        }

        //public IActionResult Get(int? id)
        //{
        //    id = (id == null) ? 101 : id;

        //    var cust = _repo.Get((int)id);
        //    return View(cust);
        //}
    }
}