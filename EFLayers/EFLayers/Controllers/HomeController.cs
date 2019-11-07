using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EFLayers.Models;
using Microsoft.AspNetCore.Identity;

namespace EFLayers.Controllers
{
    public class HomeController : Controller
    {
    //    private readonly UserManager<CustomUser> _userManager;
    //    private readonly SignInManager<CustomUser> _signInManager;

    //    public HomeController(
    //    UserManager<CustomUser> userManager,
    //    SignInManager<CustomUser> signInManager)
    //    {
    //        _userManager = userManager;
    //        _signInManager = signInManager;
    //    }
        public IActionResult Partial()
        {
            return View();
        }

        public IActionResult RenderPartial()
        {
            return View();
        }

        public IActionResult Index()
        {
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
