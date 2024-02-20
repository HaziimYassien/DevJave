using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SnaptStories6.Data;
using SnaptStories6.Models;

namespace SnaptStories6.Controllers
{
    public class authorsController : Controller
    {
        private readonly SnaptStories6Context _context;

        public authorsController(SnaptStories6Context context)
        {
            _context = context;
        }

        // GET: authors
        public async Task<IActionResult> Index()
        {
            return View(await _context.author.ToListAsync());
        }

        // GET: authors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var author = await _context.author
                .FirstOrDefaultAsync(m => m.authorID == id);
            if (author == null)
            {
                return NotFound();
            }

            return View(author);
        }

        // GET: authors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: authors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("authorID,authorName,authorDescription,authorEmail,authorPassword,authorPhoneNumber,authorImage,authorStatus,authorUrl,authorFacebook,authorTwitter,authorLinkedin,authorYoutube,authorInstagram,NumberOfShortStories")] author author)
        {
            if (ModelState.IsValid)
            {
                _context.Add(author);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(author);
        }

        // GET: authors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var author = await _context.author.FindAsync(id);
            if (author == null)
            {
                return NotFound();
            }
            return View(author);
        }

        // POST: authors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("authorID,authorName,authorDescription,authorEmail,authorPassword,authorPhoneNumber,authorImage,authorStatus,authorUrl,authorFacebook,authorTwitter,authorLinkedin,authorYoutube,authorInstagram,NumberOfShortStories")] author author)
        {
            if (id != author.authorID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(author);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!authorExists(author.authorID))
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
            return View(author);
        }

        // GET: authors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var author = await _context.author
                .FirstOrDefaultAsync(m => m.authorID == id);
            if (author == null)
            {
                return NotFound();
            }

            return View(author);
        }

        // POST: authors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var author = await _context.author.FindAsync(id);
            if (author != null)
            {
                _context.author.Remove(author);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool authorExists(int id)
        {
            return _context.author.Any(e => e.authorID == id);
        }
    }
}
