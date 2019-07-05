using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyDbCore.Models;
using Microsoft.AspNetCore.Http;

namespace MyDbCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("Name", "Ajay Singala");

            var customer = new Customer()
            {
                Id = 101,
                Firstname = "John",
                Lastname = "Smith",
                Email = "jsmith@abc.com"
            };

            HttpContext.Session.Set<Customer>("Customer", customer);
            return View();
        }

        public IActionResult About()
        {
            var name = HttpContext.Session.GetString("Name").ToString();
            ViewData["Name"] = name;

            var cust = HttpContext.Session.Get<Customer>("Customer");
            ViewBag.CustName = $"{cust.Lastname}, {cust.Firstname}";

            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
