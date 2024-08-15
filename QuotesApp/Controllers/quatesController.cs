using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuotesApp.Data;
using QuotesApp.Models;

namespace QuotesApp.Controllers
{
    public class quatesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public quatesController(ApplicationDbContext context)
        {
            _context = context;
        }



        // GET: quates
        public async Task<IActionResult> Index()
        {
            return View(await _context.quate.ToListAsync());
        }




        // GET: quates
        public async Task<IActionResult> ShowSearchForm()
        {
            return View();
        }


        // GET: quates
        public async Task<IActionResult> ShowSearchResults(string SearchPhrase)
        {
            return View("Index", await _context.quate.Where(j => j.QuoteAuthor.Contains(SearchPhrase)).ToListAsync());
        }

        // GET: quates/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quate = await _context.quate
                .FirstOrDefaultAsync(m => m.ID == id);
            if (quate == null)
            {
                return NotFound();
            }

            return View(quate);
        }


        // GET: quates/Create

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: quates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,QuoteAuthor,QuoteText")] quate quate)
        {
            if (ModelState.IsValid)
            {
                _context.Add(quate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(quate);
        }

        // GET: quates/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quate = await _context.quate.FindAsync(id);
            if (quate == null)
            {
                return NotFound();
            }
            return View(quate);
        }

        // POST: quates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, [Bind("ID,QuoteAuthor,QuoteText")] quate quate)
        {
            if (id != quate.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(quate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!quateExists(quate.ID))
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
            return View(quate);
        }

        // GET: quates/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quate = await _context.quate
                .FirstOrDefaultAsync(m => m.ID == id);
            if (quate == null)
            {
                return NotFound();
            }

            return View(quate);
        }

        // POST: quates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize] 
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var quate = await _context.quate.FindAsync(id);
            if (quate != null)
            {
                _context.quate.Remove(quate);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool quateExists(int id)
        {
            return _context.quate.Any(e => e.ID == id);
        }
    }
}
