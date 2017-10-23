using mytest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace mytest.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any Books.
                if (context.Books.Any())
                {
                    //return;   // DB has been seeded
                }
                foreach (Book b in context.Books)
                {
                    context.Books.Remove(b);
                }
                context.SaveChanges();


                context.Books.AddRange(
                     new Book
                     {
                         ISBN = "978-0062315007",
                         Title = "The Alchemist",
                         Price = 34.99,
                         Description = "http://www.productontology.org/id/The_Alchemist_(novel)",
                         Author = "Paulo Coelho",
                         Genre = "Adventure",
                         Publisher = "HarperOne",
                         Quantity = 60,
                         Image = "http://t2.gstatic.com/images?q=tbn:ANd9GcTAyMeaePHdaWi1UppB8qvu2GtO4jfpufEsS3cR8Sp9Is-x3KXb",
                         IsFeatured = 1
                         
                     },
                     new Book
                     {
                         ISBN = "978-0156012195",
                         Title = "The Little Prince",
                         Price = 7.99,
                         Description = "Description2",
                         Author = "Antoine de Saint-Exupéry",
                         Genre = "Adventure",
                         Publisher = "Mariner Books",
                         Quantity = 70,
                         Image = "https://books.google.com/books/content/images/frontcover/NhTyjt0V9tsC?fife=w300-rw",
                         IsFeatured = 1
                     },
                     new Book
                     {
                         ISBN = "978-0307949486",
                         Title = "The Girl with the Dragon Tattoo",
                         Price = 25.99,
                         Description = "Description3",
                         Author = "Stieg Larsson",
                         Genre = "Suspense",
                         Publisher = "Vintage Crime / Black Lizard",
                         Quantity = 3,
                         Image = "http://t0.gstatic.com/images?q=tbn:ANd9GcT3C9lPaq1RPyrr12irhuZewsNZUX1aXxvU0Llyoc7n3zDqN1Rj",
                         IsFeatured = 1
                     },
                     new Book
                     {
                         ISBN = "978-0349409740",
                         Title = "A Scot in the Dark",
                         Price = 10.14,
                         Description = "Description4",
                         Author = "Sarah MacLean",
                         Genre = "Romance",
                         Publisher = "PIATKUS BOOKS",
                         Quantity = 26,
                         Image = "https://images.gr-assets.com/books/1504741514l/27067875.jpg",
                         IsFeatured = 1
                     },
                     new Book
                     {
                         ISBN = "978-0439708180",
                         Title = "Harry Potter and the Sorcerer''s Stone",
                         Price = 7.99,
                         Description = "Description5",
                         Author = "J. K. Rowling",
                         Genre = "Adventure",
                         Publisher = "Pottermore",
                         Quantity = 20,
                         Image = "http://t0.gstatic.com/images?q=tbn:ANd9GcTltzcooPkGcy1fKKqzSuO8U6S9XBpNDR9MuYc9SS_L5AbAn66O",
                         IsFeatured = 1
                     },
                     new Book
                     {
                         ISBN = "978-0547928197",
                         Title = "The Return of the King",
                         Price = 9.99,
                         Description = "Description6",
                         Author = "J.R.R. Tolkien",
                         Genre = "Fantasy",
                         Publisher = "Mariner Books",
                         Quantity = 70,
                         Image = "http://www.gstatic.com/tv/thumb/movieposters/33156/p33156_p_v8_aa.jpg",
                         IsFeatured = 1
                     },
                     new Book
                     {
                         ISBN = "978-0547928203",
                         Title = "The Two Towers",
                         Price = 12.99,
                         Description = "Description6",
                         Author = "J.R.R. Tolkien",
                         Genre = "Fantasy",
                         Publisher = "Mariner Books",
                         Quantity = 15,
                         Image = "https://images-na.ssl-images-amazon.com/images/I/4123zOAwAgL._SY346_.jpg",
                         IsFeatured = 1
                     },
                     new Book
                     {
                         ISBN = "978-0547928210",
                         Title = "The Fellowship of the Ring",
                         Price = 9.99,
                         Description = "Description7",
                         Author = "J.R.R. Tolkien",
                         Genre = "Fantasy",
                         Publisher = "Mariner Books",
                         Quantity = 35,
                         Image = "https://prodimage.images-bn.com/pimages/9780547928210_p0_v2_s550x406.jpg",
                         IsFeatured = 1
                     },
                     new Book
                     {
                         ISBN = "978-0553593716",
                         Title = "A Game of Thrones (A Song of Ice and Fire, Book 1)",
                         Price = 49.99,
                         Description = "Description8",
                         Author = "George R. Martin",
                         Genre = "Fantasy",
                         Publisher = "Bantam",
                         Quantity = 3,
                         Image = "https://images-na.ssl-images-amazon.com/images/I/51KzcuZMlzL._SY344_BO1,204,203,200_.jpg",
                         IsFeatured = 1
                     },
                     new Book
                     {
                         ISBN = "978-1455582877",
                         Title = "The Notebook",
                         Price = 20.50,
                         Description = "Description9",
                         Author = "Nicholas Sparks",
                         Genre = "Romance",
                         Publisher = "Grand Central Publishing",
                         Quantity = 30,
                         Image = "http://www.gstatic.com/tv/thumb/movieposters/33410/p33410_p_v8_aa.jpg",
                         IsFeatured = 1
                     },
                     new Book
                     {
                         ISBN = "978-1508480563",
                         Title = "Heidi",
                         Price = 5.99,
                         Description = "Description10",
                         Author = "Johanna Spyri",
                         Genre = "Adventure",
                         Publisher = "NorthSouth",
                         Quantity = 20,
                         Image = "https://images-na.ssl-images-amazon.com/images/I/51pTZX8xQ%2BL.jpg",
                         IsFeatured = 1
                     },
                     new Book
                     {
                         ISBN = "978-1537782034",
                         Title = "Witch Hunter: An Urban Fantasy Novel",
                         Price = 14.99,
                         Description = "Description11",
                         Author = "C. N. Crawfors",
                         Genre = "Fantasy",
                         Publisher = "CreateSpace Independent Publishing Platform",
                         Quantity = 20,
                         Image = "https://images-na.ssl-images-amazon.com/images/I/51gdbBo8KNL._SX311_BO1,204,203,200_.jpg",
                         IsFeatured = 1
                     }
                );

                context.SaveChanges();
            }
        }
    }
}
