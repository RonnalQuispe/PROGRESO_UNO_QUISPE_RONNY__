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
    public class RecompensaClientesController : Controller
    {
        private readonly baseProgreso1 _context;

        public RecompensaClientesController(baseProgreso1 context)
        {
            _context = context;
        }

        // GET: RecompensaClientes
        public async Task<IActionResult> Index()
        {
            var baseProgreso1 = _context.RecompensaCliente.Include(r => r.Cliente);
            return View(await baseProgreso1.ToListAsync());
        }

        // GET: RecompensaClientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recompensaCliente = await _context.RecompensaCliente
                .Include(r => r.Cliente)
                .FirstOrDefaultAsync(m => m.RecompensaId == id);
            if (recompensaCliente == null)
            {
                return NotFound();
            }

            return View(recompensaCliente);
        }

        // GET: RecompensaClientes/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "ClienteId", "Nombre");
            return View();
        }

        // POST: RecompensaClientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RecompensaId,Nombre,FechaInicio,PuntosAcumulados,ClienteId")] RecompensaCliente recompensaCliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(recompensaCliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "ClienteId", "Nombre", recompensaCliente.ClienteId);
            return View(recompensaCliente);
        }

        // GET: RecompensaClientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recompensaCliente = await _context.RecompensaCliente.FindAsync(id);
            if (recompensaCliente == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "ClienteId", "Nombre", recompensaCliente.ClienteId);
            return View(recompensaCliente);
        }

        // POST: RecompensaClientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RecompensaId,Nombre,FechaInicio,PuntosAcumulados,ClienteId")] RecompensaCliente recompensaCliente)
        {
            if (id != recompensaCliente.RecompensaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(recompensaCliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecompensaClienteExists(recompensaCliente.RecompensaId))
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
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "ClienteId", "Nombre", recompensaCliente.ClienteId);
            return View(recompensaCliente);
        }

        // GET: RecompensaClientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recompensaCliente = await _context.RecompensaCliente
                .Include(r => r.Cliente)
                .FirstOrDefaultAsync(m => m.RecompensaId == id);
            if (recompensaCliente == null)
            {
                return NotFound();
            }

            return View(recompensaCliente);
        }

        // POST: RecompensaClientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var recompensaCliente = await _context.RecompensaCliente.FindAsync(id);
            if (recompensaCliente != null)
            {
                _context.RecompensaCliente.Remove(recompensaCliente);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RecompensaClienteExists(int id)
        {
            return _context.RecompensaCliente.Any(e => e.RecompensaId == id);
        }
    }
}
