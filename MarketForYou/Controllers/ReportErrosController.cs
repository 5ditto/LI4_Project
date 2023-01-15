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
    public class ReportErrosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReportErrosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ReportErros
        public async Task<IActionResult> Index()
        {
              return View(await _context.ReportErros.ToListAsync());
        }

        // GET: ReportErros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ReportErros == null)
            {
                return NotFound();
            }

            var reportErros = await _context.ReportErros
                .FirstOrDefaultAsync(m => m.reportId == id);
            if (reportErros == null)
            {
                return NotFound();
            }

            return View(reportErros);
        }

        // GET: ReportErros/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ReportErros/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("reportId,anexo,descricaoErro,usernameCliente")] ReportErros reportErros)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reportErros);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reportErros);
        }

        // GET: ReportErros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ReportErros == null)
            {
                return NotFound();
            }

            var reportErros = await _context.ReportErros.FindAsync(id);
            if (reportErros == null)
            {
                return NotFound();
            }
            return View(reportErros);
        }

        // POST: ReportErros/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("reportId,anexo,descricaoErro,usernameCliente")] ReportErros reportErros)
        {
            if (id != reportErros.reportId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reportErros);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReportErrosExists(reportErros.reportId))
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
            return View(reportErros);
        }

        // GET: ReportErros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ReportErros == null)
            {
                return NotFound();
            }

            var reportErros = await _context.ReportErros
                .FirstOrDefaultAsync(m => m.reportId == id);
            if (reportErros == null)
            {
                return NotFound();
            }

            return View(reportErros);
        }

        // POST: ReportErros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ReportErros == null)
            {
                return Problem("Entity set 'ApplicationDbContext.ReportErros'  is null.");
            }
            var reportErros = await _context.ReportErros.FindAsync(id);
            if (reportErros != null)
            {
                _context.ReportErros.Remove(reportErros);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReportErrosExists(int id)
        {
          return _context.ReportErros.Any(e => e.reportId == id);
        }
    }
}
