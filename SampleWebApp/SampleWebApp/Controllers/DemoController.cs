using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SampleWebApp.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult VR()
        {
            return View();
        }

        public ViewResult VR2()
        {
            return View("SecondView");
        }

        public ContentResult Content()
        {
            //return Content("This is a content result");
            //return Content("<h2>This is a content result<h2>");
            //return Content("<h3>This is a sample content</h3>", "text/html");
            return Content("<script>alert('Hello!')</script>", "text/html");
        }

        public PartialViewResult PVR()
        {
            return PartialView("SecondView");
        }

        public PartialViewResult PVR2()
        {
            return PartialView("_SecondView");
        }

        public EmptyResult ER()
        {
            return new EmptyResult();
        }

        public ActionResult ER2()
        {
            return null;
        }

        public FileResult FR()
        {
            return File("~/Files/text.txt", "text/plain");
        }

        public FileResult FR2()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes("wwwroot/Files/text.txt");
            return File(fileBytes, "text/plain");
        }

        public FileResult FR3()
        {
            return File(Url.Content("~/Files/text.txt"), "text/plain", "testFile.txt");
        }

        public JsonResult JR()
        {
            return Json(new { Name = "Zain Ul Hassan", ID = 1 });
        }

        public RedirectResult RR()
        {
            return Redirect("http://docs.microsoft.com");
        }

        public RedirectToRouteResult Redirect()
        {
            return RedirectToRoute(new { controller = "Customer", action = "Index" });
        }

        public StatusCodeResult StatusCode()
        {
            return new StatusCodeResult(401);
        }

    }
}