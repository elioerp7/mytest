using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mytest.Data;
using mytest.Models;
using System.Linq;
using System.Threading.Tasks;

namespace mytest.Controllers
{
    public class BooksOwnedController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BooksOwnedController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: BooksOwned
        public async Task<IActionResult> Index()
        {
            return View(await _context.BooksOwned.ToListAsync());
        }

        // GET: BooksOwned/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookOwned = await _context.BooksOwned
                .SingleOrDefaultAsync(m => m.TransactionId == id);
            if (bookOwned == null)
            {
                return NotFound();
            }

            return View(bookOwned);
        }

        // GET: BooksOwned/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BooksOwned/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TransactionId,UserId,BookISBN")] BookOwned bookOwned)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bookOwned);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(bookOwned);
        }

        // GET: BooksOwned/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookOwned = await _context.BooksOwned.SingleOrDefaultAsync(m => m.TransactionId == id);
            if (bookOwned == null)
            {
                return NotFound();
            }
            return View(bookOwned);
        }

        // POST: BooksOwned/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TransactionId,UserId,BookISBN")] BookOwned bookOwned)
        {
            if (id != bookOwned.TransactionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookOwned);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookOwnedExists(bookOwned.TransactionId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(bookOwned);
        }

        // GET: BooksOwned/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookOwned = await _context.BooksOwned
                .SingleOrDefaultAsync(m => m.TransactionId == id);
            if (bookOwned == null)
            {
                return NotFound();
            }

            return View(bookOwned);
        }

        // POST: BooksOwned/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bookOwned = await _context.BooksOwned.SingleOrDefaultAsync(m => m.TransactionId == id);
            _context.BooksOwned.Remove(bookOwned);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool BookOwnedExists(int id)
        {
            return _context.BooksOwned.Any(e => e.TransactionId == id);
        }
    }
}
