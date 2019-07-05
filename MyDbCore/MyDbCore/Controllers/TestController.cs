using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyDbCore.TestSimulation;

namespace MyDbCore.Controllers
{
    public class TestController : Controller
    {
        public string TestBL()
        {
            var di = new SimulateDI();
            di.Call();

            return "Got it!";
        }
    }
}