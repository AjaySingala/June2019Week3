using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SampleWebApp.Controllers
{
    [Route("[controller]")]
    public class RoutesController : Controller
    {
        [Route("{controller}")]
        [Route("")]
        [Route("index")]
        public string Index()
        {
            return "Hello there!";
        }

        [Route("/routes/Welcome")]
        public string Welcome()
        {
            return "Hello there! Welcome";
        }
    }
}