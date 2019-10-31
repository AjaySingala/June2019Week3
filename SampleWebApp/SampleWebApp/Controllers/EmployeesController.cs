using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleWebApp.Models;

namespace SampleWebApp.Controllers
{
    public class EmployeesController : Controller
    {
        private static List<Employee> _employees = new List<Employee>
        {
            new Employee() { Id = 1, Firstname = "John", Lastname = "Smith", City = "NYC", DOB = new DateTime(1999,10,01) },
            new Employee() { Id = 2, Firstname = "Mary", Lastname = "Jane", City = "Dallas", DOB = new DateTime(1987,12,01) },
            new Employee() { Id = 3, Firstname = "Joe", Lastname = "Pesci", City = "Reston", DOB = new DateTime(1990,12,12) },
        };

        // GET: Employees
        public ActionResult Index()
        {
           return View(_employees);
        }

        // GET: Employees/Details/5
        public ActionResult Details(int id)
        {
            var emp = new Employee();
            if (id == 0)
            {
                ViewBag.Message = "ID not provided.";
            }
            else
            {
                emp = _employees.Where(e => e.Id == id)
                    .SingleOrDefault<Employee>();
                if(emp == null)
                {
                    ViewBag.Message = $"Employee for id {id} not found.";
                }
            }

            return View(emp);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        public ActionResult Create(Employee employee)
        {
            try
            {
                // TODO: Add insert logic here
                _employees.Add(employee);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int id)
        {
            var emp = _employees.Where(e => e.Id == id)
                .SingleOrDefault<Employee>();
            if(emp != null)
            {
                return View(emp);
            }
            else
            {
                return RedirectToAction("Display", "Error");
            }
        }

        // POST: Employees/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(int id, Employee employee)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int id)
        {
            var emp = _employees.Where(e => e.Id == id)
                            .SingleOrDefault<Employee>();
            if (emp != null)
            {
                return View(emp);
            }
            else
            {
                return RedirectToAction("Display", "Error");
            }
        }

        // POST: Employees/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}