using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using net3._1.Data;
using net3._1.Models;

namespace net3._1.Controllers
{
    public class CarouselFirstsController : Controller
    {
        private readonly net3_1Context _context;

        public CarouselFirstsController(net3_1Context context)
        {
            _context = context;
        }

        // GET: CarouselFirsts
        public async Task<IActionResult> Index()
        {
            return View(await _context.CarouselFirst.ToListAsync());
        }

        // GET: CarouselFirsts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carouselFirst = await _context.CarouselFirst
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carouselFirst == null)
            {
                return NotFound();
            }

            return View(carouselFirst);
        }

        // GET: CarouselFirsts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CarouselFirsts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Image,ImageMobile")] CarouselFirst carouselFirst)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carouselFirst);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carouselFirst);
        }

        // GET: CarouselFirsts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carouselFirst = await _context.CarouselFirst.FindAsync(id);
            if (carouselFirst == null)
            {
                return NotFound();
            }
            return View(carouselFirst);
        }

        // POST: CarouselFirsts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Image,ImageMobile")] CarouselFirst carouselFirst)
        {
            if (id != carouselFirst.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carouselFirst);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarouselFirstExists(carouselFirst.Id))
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
            return View(carouselFirst);
        }

        // GET: CarouselFirsts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carouselFirst = await _context.CarouselFirst
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carouselFirst == null)
            {
                return NotFound();
            }

            return View(carouselFirst);
        }

        // POST: CarouselFirsts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carouselFirst = await _context.CarouselFirst.FindAsync(id);
            _context.CarouselFirst.Remove(carouselFirst);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarouselFirstExists(int id)
        {
            return _context.CarouselFirst.Any(e => e.Id == id);
        }
    }
}
