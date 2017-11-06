using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mytest.Data;
using mytest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mytest.Controllers
{
    public class HomeController : Controller 
    {
        private readonly ApplicationDbContext _context;
        private UserManager<ApplicationUser> _userManager;
        

       

        public HomeController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
            System.Security.Claims.ClaimsPrincipal currentUser = this.User;
        }

        

        [Authorize]
        public async Task<IActionResult> Index(string sort, string search, string currentFilter, int? page, string pageSize, int sizePage)
        {
            ViewData["CurrentSort"] = sort;
            ViewData["AuthorSort"] = sort==  "Author"?  "Author" : "Author";
            ViewData["TitleSort"] = sort == "Title"  ?  "Title" : "Title";
            ViewData["PriceSortHL"] = sort == "Price (High to Low)" ? "Price (High to Low)" : "Price (High to Low)";
            ViewData["PriceSortLH"] = sort == "Price (Low to High)" ? "Price (Low to High)" : "Price (Low to High)";
            ViewData["ReleaseSort"] = sort ==  "Release Date" ? "Release Date" : "Release Date";
            ViewData["ReleaseSortM"] = sort == "Release Date" ? "Release Date (Most Recent)" : "Release Date (Most Recent)";
            ViewData["PageSize10"] = pageSize == "10" ? "10" : "10";
            ViewData["PageSize20"] = pageSize == "20" ? "20" : "20";
            ViewData["TopSort"] = sort == "Top Sellers" ? "Top Sellers" : "Top Sellers";
            ViewData["BestSort"] = sort == "Best Rated" ? "Best Rated" : "Best Rated";

            Int32.TryParse(pageSize, out sizePage);
          

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
                    books = (_context.Books.OrderBy(x => x.Price));
                    break;
                case "Price (High to Low)":
                    books = (_context.Books.OrderByDescending(x => x.Price));
                    break;
                case "Release Date":
                    books = (_context.Books.OrderBy(x => x.ReleaseDate));
                    break;
                case "Release Date (Most Recent)": 
                    books = (_context.Books.OrderByDescending(x => x.ReleaseDate));
                    break;
                case "Top Sellers":
                    books = (_context.Books.OrderByDescending(x => x.Sold));
                    break;
                case "Best Rated":
                    books = (_context.Books.OrderByDescending(x => x.Rating));
                    break;
                default:
                    books = books.OrderBy(x => x.Title);
                    break;

            }
            
            getCartItems();

            


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
                var book = _context.Books.Where(d => d.ISBN.Equals(field)).ToList();
                var Quantity = book.Sum(d => d.Quantity);
                ViewBag.Quantity = Quantity;
                var comments = _context.Comments.Where(d => d.BookISBN.Equals(field)).ToList();
                ViewBag.Comments = comments;
                ViewBag.UserName = _userManager.GetUserName(User);
                ViewBag.UserId = _userManager.GetUserId(User);

                var UserId = _userManager.GetUserId(User);
                ViewBag.bought = false;



                foreach (BookOwned bo in _context.BooksOwned)
                {
                    if(UserId.Equals(bo.UserId) && field.Equals(bo.BookISBN))
                    {
                        ViewBag.bought = true;
                    }
                }

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
                getCartItems();

                return View(_context.Books.Where(x => x.ISBN.Equals(field) || field == null).ToList());
            }
        }
        [Authorize]
        public IActionResult ShowAuthor(string field)
        {
            getCartItems();
            var books = _context.Books.Where(m => m.Author.ToLower().Equals(field.ToLower()));  //getting all the books written by that author
            ViewBag.books = books;          //viewbag with all the books written by that author

            if (field == null)
                return View();
            else
            {
                return View(_context.Authors.Where(x => x.Name.ToLower().Equals(field.ToLower()) || field == null).ToList());
            }
        }

        public async Task<IActionResult> ShoppingCart()
        {
            getCartItems();
            var UserId = _userManager.GetUserId(User);
            var listofcarts = _context.MyShoppingCart.Where(m => m.UserId.Equals(UserId)).ToList();
            ViewBag.userItems = listofcarts;
            List<Book> booksInCart = new List<Book>();

            foreach (ShoppingCart s in listofcarts)
            {
                var temp = _context.Books.Where(b => b.ISBN.Equals(s.BookISBN)).ToList();
                if (temp.Count() != 0)
                {
                    booksInCart.Add(temp.ElementAt(0));
                }
            }
            ViewBag.booksInCart = booksInCart;
            return View(await _context.MyShoppingCart.ToListAsync());
        }

        public void getCartItems()
        {
            //getting items in shopping cart
            ViewBag.UserId = _userManager.GetUserId(User);

            var UserId = _userManager.GetUserId(User);
            var listofcarts = _context.MyShoppingCart.Where(m => m.UserId.Equals(UserId)).ToList();
            int ItemsInCart = 0;
            foreach (ShoppingCart s in listofcarts)
            {
                ItemsInCart += s.Quantity;
            }
            ViewBag.ItemsInCart = ItemsInCart;
        }
    }
}
