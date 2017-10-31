using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mytest.Data;
using mytest.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace mytest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private UserManager<ApplicationUser> _userManager;
        //private readonly string sortOrder;

        public HomeController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
            System.Security.Claims.ClaimsPrincipal currentUser = this.User;
        }

        [Authorize]
        public async Task<IActionResult> Index(string sort, string search, string currentFilter, int? page, string pageSize)
        {
            ViewData["CurrentSort"] = sort;
            ViewData["AuthorSort"] = sort==  "Author"?  "" : "Author";
            ViewData["TitleSort"] = sort == "Title"  ?  "" : "Title";
            ViewData["PriceSort"] = sort == "Price (High to Low)" ? "Price (Low to High)" : "Price (High to Low)";
            ViewData["ReleaseSort"] = sort ==  "Release Date" ? "Release Date (Most Recent)" : "Release Date";
            ViewData["PageSize"] = pageSize == "10" ? "20" : "10";

            if (search != null)
            {
                page = 1;
            }
            else
            {
                search = currentFilter;
            }

            ViewData["CurrentFilter"] = search;

            var books = from x in _context.Books select x;

            if (!String.IsNullOrEmpty(search))
            {
                books = _context.Books.Where(x => x.Title.ToLower().Contains(search.ToLower()) ||
                                                             x.Author.ToLower().Contains(search.ToLower()) ||
                                                             x.Genre.ToLower().Contains(search.ToLower()) ||
                                                             x.ISBN.Contains(search) ||
                                                             x.Publisher.ToLower().Contains(search.ToLower()) );
            }

            switch (sort)
            {
                case "Author":
                    books = (_context.Books.OrderBy(x => x.Author));
                    break;
                case "Title":
                    books = (_context.Books.OrderBy(x => x.Title));
                    break;
                case "Price (Low to High)":
                    books = (_context.Books.OrderByDescending(x => x.Price));
                    break;
                case "Price (High to Low)":
                    books = (_context.Books.OrderBy(x => x.Price));
                    break;
                case "Release Date":
                    books = (_context.Books.OrderBy(x => x.ReleaseDate));
                    break;
                case "Release Date (Most Recent)": 
                    books = (_context.Books.OrderByDescending(x => x.ReleaseDate));
                    break;
                default:
                    books = books.OrderBy(x => x.Title);
                    break;

            }
            int sizePage = 12;
            switch (pageSize)
            {
                case "10":
                    sizePage = 10;
                    break;
                case "20":
                    sizePage = 20;
                    break;

            }
            
            return View(await GeekTextBooks.PaginatedList<Book>.CreateAsync(books.AsNoTracking(), page ?? 1, sizePage));

        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Team 5";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        [Authorize]
        public IActionResult ShowBook(string field)
        {
            if (field == null)
                return View();
            else
            {
                ViewBag.BookISBN = field;
                var comments = _context.Comments.Where(d => d.BookISBN.Equals(field)).ToList();
                ViewBag.Comments = comments;
                ViewBag.UserId = _userManager.GetUserName(User);


                var ratings = _context.Comments.Where(d => d.BookISBN.Equals(field)).ToList();

                if (ratings.Count() > 0)
                {
                    var ratingSum = ratings.Sum(d => d.Rating.Value);
                    ViewBag.RatingSum = ratingSum;
                    var ratingCount = ratings.Count();
                    ViewBag.RatingCount = ratingCount;
                }
                else
                {
                    ViewBag.RatingSum = 0;
                    ViewBag.RatingCount = 0;
                }

                return View(_context.Books.Where(x => x.ISBN.Equals(field) || field == null).ToList());
            }
        }
        [Authorize]
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
