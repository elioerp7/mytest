using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using mytest.Data;
using mytest.Models;

namespace mytest.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Book
        public async Task<IActionResult> Index()
        {
            return View(await _context.Books.ToListAsync());
        }

        // GET: Book/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id.Equals(null))
            {
                return NotFound();
            }

            var book = await _context.Books
                .SingleOrDefaultAsync(m => m.ISBN.Equals(id));
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // GET: Book/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ISBN,Title,Description,Price,Author,Genre,Publisher,Quantity,Image,IsFeatured")] Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Add(book);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(book);
        }

        // GET: Book/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id.Equals(null))
            {
                return NotFound();
            }

            var book = await _context.Books.SingleOrDefaultAsync(m => m.ISBN.Equals(id));
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // POST: Book/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ISBN,Title,Description,Price,Author,Genre,Publisher,Quantity,Image,IsFeatured")] Book book)
        {
            if (id != book.ISBN)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(book);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(book.ISBN))
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
            return View(book);
        }

        // GET: Book/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id.Equals(null))
            {
                return NotFound();
            }

            var book = await _context.Books
                .SingleOrDefaultAsync(m => m.ISBN == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Book/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var book = await _context.Books.SingleOrDefaultAsync(m => m.ISBN == id);
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool BookExists(string id)
        {
            return _context.Books.Any(e => e.ISBN == id);
        }
        [HttpGet]
        public IActionResult ViewBooks(String search)
        {
            if (search == null)
                return View(_context.Books.ToList());
            else
            {
                return View(_context.Books.Where(x => x.Title.ToLower().Contains(search.ToLower()) ||
                                                             x.Author.ToLower().Contains(search.ToLower()) ||
                                                             x.Genre.ToLower().Contains(search.ToLower()) ||
                                                             x.ISBN.Contains(search) ||
                                                             x.Publisher.ToLower().Contains(search.ToLower()) ||
                                                             search == null).ToList());
            }
        }
        public IActionResult ShowBook(string field)
        {
            if (field == null)
                return View();
            else
            {
                return View(_context.Books.Where(x => x.ISBN.Equals(field) || field == null).ToList());
            }
        }
        public IActionResult ShowAuthor(string field)
        {
            if (field == null)
                return View();
            else
            {
                return View(_context.Books.Where(x => x.Author.ToLower().Equals(field.ToLower()) || field == null).ToList());
            }
        }
    }
}
