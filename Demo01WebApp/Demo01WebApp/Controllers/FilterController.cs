using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Demo01WebApp.Filters;

namespace Demo01WebApp.Controllers
{
    //[ServiceFilter(typeof(SampleActionFilter))]
    public class FilterController : Controller
    {
        public string Index()
        {
            return "/Filter/Index";
        }

        public string Demo()
        {
            return "/Filter/Demo";
        }

    }
}