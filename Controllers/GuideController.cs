using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WowRoads.Data;
using WowRoads.Models;

namespace WowRoads.Controllers
{
    public class GuideController : Controller
    {
        private readonly DataContext _context;

        public GuideController(DataContext context)
        {
            _context = context;
        }

        // GET: Agent
        public async Task<IActionResult> Index()
        {
            return View(await _context.Guide.ToListAsync());
        }

        // GET: Agents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guide = await _context.Guide
                .FirstOrDefaultAsync(m => m.GuideID == id);
            if (guide == null)
            {
                return NotFound();
            }

            return View(guide);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        
        public async Task<IActionResult> Create([Bind("GuideID,LastNameGuide,FirstNameGuide,Place")] Guide guide)
        {
            if (ModelState.IsValid)
            {
                _context.Add(guide);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(guide);
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guide = await _context.Guide.FindAsync(id);
            if (guide == null)
            {
                return NotFound();
            }
            return View(guide);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GuideID,LastNameGuide,FirstNameGuide,Place")] Guide guide)
        {
            if (id != guide.GuideID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(guide);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AgentExists(guide.GuideID))
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
            return View(guide);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guide = await _context.Guide
                .FirstOrDefaultAsync(m => m.GuideID == id);
            if (guide == null)
            {
                return NotFound();
            }

            return View(guide);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var guide = await _context.Guide.FindAsync(id);
            _context.Guide.Remove(guide);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AgentExists(int id)
        {
            return _context.Guide.Any(e => e.GuideID == id);
        }
    }
}