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
    public class FeirasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FeirasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Feiras
        public async Task<IActionResult> Index()
        {
              return View(await _context.Feira.ToListAsync());
        }

        // GET: Feiras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Feira == null)
            {
                return NotFound();
            }

            var feira = await _context.Feira
                .FirstOrDefaultAsync(m => m.feiraID == id);
            if (feira == null)
            {
                return NotFound();
            }

            return View(feira);
        }

        // GET: Feiras/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Feiras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("feiraID,nomeFeira,dataFeira,localizacaoFeira,categoriaFeira,numVisitasFeira")] Feira feira)
        {
            if (ModelState.IsValid)
            {
                _context.Add(feira);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(feira);
        }

        // GET: Feiras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Feira == null)
            {
                return NotFound();
            }

            var feira = await _context.Feira.FindAsync(id);
            if (feira == null)
            {
                return NotFound();
            }
            return View(feira);
        }

        // POST: Feiras/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("feiraID,nomeFeira,dataFeira,localizacaoFeira,categoriaFeira,numVisitasFeira")] Feira feira)
        {
            if (id != feira.feiraID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(feira);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FeiraExists(feira.feiraID))
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
            return View(feira);
        }

        // GET: Feiras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Feira == null)
            {
                return NotFound();
            }

            var feira = await _context.Feira
                .FirstOrDefaultAsync(m => m.feiraID == id);
            if (feira == null)
            {
                return NotFound();
            }

            return View(feira);
        }

        // POST: Feiras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Feira == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Feira'  is null.");
            }
            var feira = await _context.Feira.FindAsync(id);
            if (feira != null)
            {
                _context.Feira.Remove(feira);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FeiraExists(int id)
        {
          return _context.Feira.Any(e => e.feiraID == id);
        }
    }
}
