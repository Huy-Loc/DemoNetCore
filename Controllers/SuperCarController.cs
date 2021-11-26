using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoMVC.Data;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class SuperCarController : Controller
    {
        private readonly ApplicationDBContext _context;

        public SuperCarController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: SuperCar
        public async Task<IActionResult> Index()
        {
            return View(await _context.SuperCar.ToListAsync());
        }

        // GET: SuperCar/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var superCar = await _context.SuperCar
                .FirstOrDefaultAsync(m => m.CarID == id);
            if (superCar == null)
            {
                return NotFound();
            }

            return View(superCar);
        }

        // GET: SuperCar/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SuperCar/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SuperCarID,SuperCarName,SuperCarPrice,CarID,CarName")] SuperCar superCar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(superCar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(superCar);
        }

        // GET: SuperCar/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var superCar = await _context.SuperCar.FindAsync(id);
            if (superCar == null)
            {
                return NotFound();
            }
            return View(superCar);
        }

        // POST: SuperCar/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("SuperCarID,SuperCarName,SuperCarPrice,CarID,CarName")] SuperCar superCar)
        {
            if (id != superCar.CarID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(superCar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SuperCarExists(superCar.CarID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(superCar);
        }

        // GET: SuperCar/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var superCar = await _context.SuperCar
                .FirstOrDefaultAsync(m => m.CarID == id);
            if (superCar == null)
            {
                return NotFound();
            }

            return View(superCar);
        }

        // POST: SuperCar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var superCar = await _context.SuperCar.FindAsync(id);
            _context.SuperCar.Remove(superCar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SuperCarExists(string id)
        {
            return _context.SuperCar.Any(e => e.CarID == id);
        }
    }
}
