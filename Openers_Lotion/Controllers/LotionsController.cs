using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Openers_Lotion.Data;
using Openers_Lotion.Models;
using Microsoft.AspNetCore.Authorization;

namespace Openers_Lotion.Controllers
{
    public class LotionsController(Openers_LotionContext context) : Controller
    {
        private readonly Openers_LotionContext _context = context;

        // GET: Lotions
        [Authorize]
        public async Task<IActionResult> Index(string lotionType, string searchString)
        {
            if (_context.Lotion == null)
            {
                return Problem("Entity set 'Openers_LotionContext.Lotion'  is null.");
            }

            // Use LINQ to get list of genres.
            IQueryable<string> typeQuery = from m in _context.Lotion
                                            orderby m.SkinType
                                            select m.SkinType;
            var lotions = from m in _context.Lotion
                          select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                lotions = lotions.Where(s => s.ProductName!.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(lotionType))
            {
                lotions = lotions.Where(x => x.SkinType == lotionType);
            }

            var lotionTypeVM = new LotionTypeViewModel
            {
                SkinTypes = new SelectList(await typeQuery.Distinct().ToListAsync()),
                Lotions = await lotions.ToListAsync()
            };

            return View(lotionTypeVM);
        }

        // GET: Lotions/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lotion = await _context.Lotion
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lotion == null)
            {
                return NotFound();
            }

            return View(lotion);
        }

        // GET: Lotions/Create
        [Authorize (Roles = "Administrator") ]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Lotions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductName,ItemForm,SkinType,Quantity,Description,Price,Review")] Lotion lotion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lotion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lotion);
        }

        // GET: Lotions/Edit/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lotion = await _context.Lotion.FindAsync(id);
            if (lotion == null)
            {
                return NotFound();
            }
            return View(lotion);
        }

        // POST: Lotions/Edit/5
        [Authorize(Roles = "Administrator")]
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProductName,ItemForm,SkinType,Quantity,Description,Price,Review")] Lotion lotion)
        {
            if (id != lotion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lotion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LotionExists(lotion.Id))
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
            return View(lotion);
        }

        // GET: Lotions/Delete/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lotion = await _context.Lotion
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lotion == null)
            {
                return NotFound();
            }

            return View(lotion);
        }

        // POST: Lotions/Delete/5
        [Authorize(Roles = "Administrator")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lotion = await _context.Lotion.FindAsync(id);
            if (lotion != null)
            {
                _context.Lotion.Remove(lotion);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LotionExists(int id)
        {
            return _context.Lotion.Any(e => e.Id == id);
        }
    }
}
