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
    public class ShortStoriesController : Controller
    {
        private readonly SnaptStories6Context _context;

        public ShortStoriesController(SnaptStories6Context context)
        {
            _context = context;
        }

        // GET: ShortStories
        public async Task<IActionResult> Index()
        {
            return View(await _context.ShortStory.ToListAsync());
        }

        // GET: ShortStories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shortStory = await _context.ShortStory
                .FirstOrDefaultAsync(m => m.ShortStoryID == id);
            if (shortStory == null)
            {
                return NotFound();
            }

            return View(shortStory);
        }

        // GET: ShortStories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ShortStories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ShortStoryID,ShortStoryName,ShortStoryText,ShortStoryImage,ShortStoryLink,ShortStoryAuthor,ShortStoryDescription,ShortStoryReleaseDate")] ShortStory shortStory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shortStory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shortStory);
        }

        // GET: ShortStories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shortStory = await _context.ShortStory.FindAsync(id);
            if (shortStory == null)
            {
                return NotFound();
            }
            return View(shortStory);
        }

        // POST: ShortStories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ShortStoryID,ShortStoryName,ShortStoryText,ShortStoryImage,ShortStoryLink,ShortStoryAuthor,ShortStoryDescription,ShortStoryReleaseDate")] ShortStory shortStory)
        {
            if (id != shortStory.ShortStoryID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shortStory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShortStoryExists(shortStory.ShortStoryID))
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
            return View(shortStory);
        }

        // GET: ShortStories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shortStory = await _context.ShortStory
                .FirstOrDefaultAsync(m => m.ShortStoryID == id);
            if (shortStory == null)
            {
                return NotFound();
            }

            return View(shortStory);
        }

        // POST: ShortStories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shortStory = await _context.ShortStory.FindAsync(id);
            if (shortStory != null)
            {
                _context.ShortStory.Remove(shortStory);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShortStoryExists(int id)
        {
            return _context.ShortStory.Any(e => e.ShortStoryID == id);
        }
    }
}
