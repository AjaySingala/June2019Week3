using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EFLayers.Models;
using EFLayers.Models.Repositories;

namespace EFLayers.Controllers
{
    public class CustomRoutingController : Controller
    {
        // GET CustomRouting/search/john
        public string Search(string username)
        {
            return username;
        }

        // GET CustomRouting/john
        // GET CustomRouting/index/john
        public string Index(string username)
        {
            return $"Index: {username}";
        }

        // GET CustomRouting/details/john
        public string Details(string username)
        {
            return $"Details: {username}";
        }

        // GET CustomRouting/create/john
        public string Create(string username)
        {
            return $"Create: {username}";
        }

        // GET CustomRouting/edit/john
        public string Edit(string username)
        {
            return $"Edit: {username}";

        }

        // GET CustomRouting/delete/john
        public string Delete(string username)
        {
            return $"Delete: {username}";

        }
    }
}
