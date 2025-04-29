using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PROGRESO_UNO_QUISPE_RONNY.Models;

namespace PROGRESO_UNO_QUISPE_RONNY.Controllers
{
    public class ReservacsController : Controller
    {
        private readonly baseProgreso1 _context;

        public ReservacsController(baseProgreso1 context)
        {
            _context = context;
        }

        // GET: Reservacs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Reservacs.ToListAsync());
        }

        // GET: Reservacs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservacs = await _context.Reservacs
                .FirstOrDefaultAsync(m => m.ReservaId == id);
            if (reservacs == null)
            {
                return NotFound();
            }

            return View(reservacs);
        }

        // GET: Reservacs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Reservacs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReservaId,FechaEntrada,FechaSalida,ValorPagar,ClienteId")] Reservacs reservacs)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reservacs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reservacs);
        }

        // GET: Reservacs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservacs = await _context.Reservacs.FindAsync(id);
            if (reservacs == null)
            {
                return NotFound();
            }
            return View(reservacs);
        }

        // POST: Reservacs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReservaId,FechaEntrada,FechaSalida,ValorPagar,ClienteId")] Reservacs reservacs)
        {
            if (id != reservacs.ReservaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reservacs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservacsExists(reservacs.ReservaId))
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
            return View(reservacs);
        }

        // GET: Reservacs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservacs = await _context.Reservacs
                .FirstOrDefaultAsync(m => m.ReservaId == id);
            if (reservacs == null)
            {
                return NotFound();
            }

            return View(reservacs);
        }

        // POST: Reservacs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reservacs = await _context.Reservacs.FindAsync(id);
            if (reservacs != null)
            {
                _context.Reservacs.Remove(reservacs);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservacsExists(int id)
        {
            return _context.Reservacs.Any(e => e.ReservaId == id);
        }
    }
}
