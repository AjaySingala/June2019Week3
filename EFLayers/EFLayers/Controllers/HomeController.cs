using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EFLayers.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

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

        // Fetch User details in Controller.
        // DI IHttpContextAccessor in Startup.cs
        private readonly IHttpContextAccessor _httpContextAccessor;
        public HomeController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

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
            // Fetch User details in Controller.
            var username = _httpContextAccessor?.HttpContext?.User?.Identity?.Name;

            var user = _httpContextAccessor.HttpContext.User;
            var userId = _httpContextAccessor.HttpContext.User
                .FindFirst(ClaimTypes.NameIdentifier).Value;

            ViewBag.Username = username;
            ViewBag.UserId = userId;

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
