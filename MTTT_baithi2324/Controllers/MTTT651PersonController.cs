using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MTTT_baithi2324.Data;
using MTTT_baithi2324.Models;

namespace MTTT_baithi2324.Controllers
{
    public class MTTT651PersonController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MTTT651PersonController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MTTT651Person
        public async Task<IActionResult> Index()
        {
            return View(await _context.Person.ToListAsync());
        }

        // GET: MTTT651Person/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mTTT651Person = await _context.Person
                .FirstOrDefaultAsync(m => m.PersonID == id);
            if (mTTT651Person == null)
            {
                return NotFound();
            }

            return View(mTTT651Person);
        }

        // GET: MTTT651Person/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MTTT651Person/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonID,FullName,Age")] MTTT651Person mTTT651Person)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mTTT651Person);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mTTT651Person);
        }

        // GET: MTTT651Person/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mTTT651Person = await _context.Person.FindAsync(id);
            if (mTTT651Person == null)
            {
                return NotFound();
            }
            return View(mTTT651Person);
        }

        // POST: MTTT651Person/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PersonID,FullName,Age")] MTTT651Person mTTT651Person)
        {
            if (id != mTTT651Person.PersonID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mTTT651Person);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MTTT651PersonExists(mTTT651Person.PersonID))
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
            return View(mTTT651Person);
        }

        // GET: MTTT651Person/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mTTT651Person = await _context.Person
                .FirstOrDefaultAsync(m => m.PersonID == id);
            if (mTTT651Person == null)
            {
                return NotFound();
            }

            return View(mTTT651Person);
        }

        // POST: MTTT651Person/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mTTT651Person = await _context.Person.FindAsync(id);
            if (mTTT651Person != null)
            {
                _context.Person.Remove(mTTT651Person);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MTTT651PersonExists(int id)
        {
            return _context.Person.Any(e => e.PersonID == id);
        }
    }
}
