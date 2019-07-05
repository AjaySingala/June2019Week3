using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyDbCore.BusinessLayer;
using MyDbCore.Models;

namespace MyDbCore.Controllers
{
    public class CustomersController : Controller
    {
        //private readonly MyDbContext _context;
        private readonly ICustomerBL _context;

        //public CustomersController(MyDbContext context)
        //{
        //    _context = context;
        //}

        //public CustomersController()
        //{
        //    _context = new CustomerBL();
        //}

        public CustomersController(ICustomerBL ctx)
        {
            _context = ctx;
        }

        // GET: Customers
        //public async Task<IActionResult> Index()
        public IActionResult Index()
        {
            //return View(await _context.Customers.ToListAsync());
            var customers = _context.Get();
            return View(customers);
        }

        // GET: Customers/Details/5
        //public async Task<IActionResult> Details(int? id)
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var customer = await _context.Customers
            //    .FirstOrDefaultAsync(m => m.Id == id);
            var customer = _context.Get(id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        //    // GET: Customers/Create
        //    public IActionResult Create()
        //    {
        //        return View();
        //    }

        //    // POST: Customers/Create
        //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> Create([Bind("Id,Firstname,Lastname,Email")] Customer customer)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            _context.Add(customer);
        //            await _context.SaveChangesAsync();
        //            return RedirectToAction(nameof(Index));
        //        }
        //        return View(customer);
        //    }

        //    // GET: Customers/Edit/5
        //    public async Task<IActionResult> Edit(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return NotFound();
        //        }

        //        var customer = await _context.Customers.FindAsync(id);
        //        if (customer == null)
        //        {
        //            return NotFound();
        //        }
        //        return View(customer);
        //    }

        //    // POST: Customers/Edit/5
        //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> Edit(int id, [Bind("Id,Firstname,Lastname,Email")] Customer customer)
        //    {
        //        if (id != customer.Id)
        //        {
        //            return NotFound();
        //        }

        //        if (ModelState.IsValid)
        //        {
        //            try
        //            {
        //                _context.Update(customer);
        //                await _context.SaveChangesAsync();
        //            }
        //            catch (DbUpdateConcurrencyException)
        //            {
        //                if (!CustomerExists(customer.Id))
        //                {
        //                    return NotFound();
        //                }
        //                else
        //                {
        //                    throw;
        //                }
        //            }
        //            return RedirectToAction(nameof(Index));
        //        }
        //        return View(customer);
        //    }

        //    // GET: Customers/Delete/5
        //    public async Task<IActionResult> Delete(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return NotFound();
        //        }

        //        var customer = await _context.Customers
        //            .FirstOrDefaultAsync(m => m.Id == id);
        //        if (customer == null)
        //        {
        //            return NotFound();
        //        }

        //        return View(customer);
        //    }

        //    // POST: Customers/Delete/5
        //    [HttpPost, ActionName("Delete")]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> DeleteConfirmed(int id)
        //    {
        //        var customer = await _context.Customers.FindAsync(id);
        //        _context.Customers.Remove(customer);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }

        //    private bool CustomerExists(int id)
        //    {
        //        return _context.Customers.Any(e => e.Id == id);
        //    }
        //}
    }
}
