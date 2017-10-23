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
                // Look for any movies.
                if (context.Books.Any())
                {
                    return;   // DB has been seeded
                }

                context.Books.AddRange(
                     new Book
                     {
                         ISBN = "978-0062315007",
                         Title = "The Alchemist",
                         Price = 34.99,
                         Description = "Description1",
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
                     }
                );
                context.SaveChanges();
            }
        }
    }
}
