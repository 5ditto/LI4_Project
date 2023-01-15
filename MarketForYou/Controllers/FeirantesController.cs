using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MarketForYou.Data;
using MarketForYou.Models;

namespace MarketForYou.Controllers
{
    public class FeirantesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FeirantesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Feirantes
        public async Task<IActionResult> Index()
        {
              return View(await _context.Feirante.ToListAsync());
        }

        // GET: Feirantes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Feirante == null)
            {
                return NotFound();
            }

            var feirante = await _context.Feirante
                .FirstOrDefaultAsync(m => m.usernameFei == id);
            if (feirante == null)
            {
                return NotFound();
            }

            return View(feirante);
        }

        // GET: Feirantes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Feirantes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("usernameFei,emailFei,passwordFei,numVisitasFei,feiraID")] Feirante feirante)
        {
            if (ModelState.IsValid)
            {
                _context.Add(feirante);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(feirante);
        }

        // GET: Feirantes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Feirante == null)
            {
                return NotFound();
            }

            var feirante = await _context.Feirante.FindAsync(id);
            if (feirante == null)
            {
                return NotFound();
            }
            return View(feirante);
        }

        // POST: Feirantes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("usernameFei,emailFei,passwordFei,numVisitasFei,feiraID")] Feirante feirante)
        {
            if (id != feirante.usernameFei)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(feirante);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FeiranteExists(feirante.usernameFei))
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
            return View(feirante);
        }

        // GET: Feirantes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Feirante == null)
            {
                return NotFound();
            }

            var feirante = await _context.Feirante
                .FirstOrDefaultAsync(m => m.usernameFei == id);
            if (feirante == null)
            {
                return NotFound();
            }

            return View(feirante);
        }

        // POST: Feirantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Feirante == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Feirante'  is null.");
            }
            var feirante = await _context.Feirante.FindAsync(id);
            if (feirante != null)
            {
                _context.Feirante.Remove(feirante);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FeiranteExists(string id)
        {
          return _context.Feirante.Any(e => e.usernameFei == id);
        }
    }
}
