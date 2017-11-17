using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using mytest.Data;
using System;
using System.Linq;

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
                    return;   // DB has been seeded
                }
                foreach (Book b in context.Books)
                {
                    context.Books.Remove(b);
                }
                foreach (Author a in context.Authors)
                {
                    context.Authors.Remove(a);
                }
                context.SaveChanges();


                context.Books.AddRange(
                     new Book
                     {
                         ISBN = "978-0062315007",
                         Title = "The Alchemist",
                         Price = 34.99,
                         Description = "Paulo Coelho's enchanting novel has inspired a devoted following around the world. This story, dazzling " +
                         "in its powerful simplicity and inspiring wisdom, is about an Andalusian shepherd boy named Santiago who travels from his " +
                         "homeland in Spain to the Egyptian desert in search of a treasure buried in the Pyramids. Along the way he meets a Gypsy" +
                         " woman, a man who calls himself king, and an alchemist, all of whom point Santiago in the direction of his quest. No" +
                         " one knows what the treasure is, or if Santiago will be able to surmount the obstacles along the way. But what starts" +
                         " out as a journey to find worldly goods turns into a discovery of the treasure found within. Lush, evocative, and deeply" +
                         " humane, the story of Santiago is an eternal testament to the transforming power of our dreams and the importance of" +
                         " listening to our hearts",
                         Author = "Paulo Coelho",
                         Genre = "Adventure",
                         Publisher = "HarperOne",
                         Quantity = 60,
                         Image = "http://t2.gstatic.com/images?q=tbn:ANd9GcTAyMeaePHdaWi1UppB8qvu2GtO4jfpufEsS3cR8Sp9Is-x3KXb",
                         IsFeatured = 1,
                         ReleaseDate = DateTime.Parse("05/01/1993"),
                         Rating = 0,
                         Sold = 0

                     },
                     new Book
                     {
                         ISBN = "978-0156012195",
                         Title = "The Little Prince",
                         Price = 7.99,
                         Description = "Few stories are as widely read and as universally cherished by children and " +
                         "adults alike as The Little Prince. Richard Howard's translation of the beloved classic" +
                         " beautifully reflects Saint-Exupéry's unique and gifted style. Howard, an acclaimed poet " +
                         "and one of the preeminent translators of our time, has excelled in bringing the English " +
                         "text as close as possible to the French, in language, style, and most important, spirit." +
                         " The artwork in this edition has been restored to match in detail and in color " +
                         "Saint-Exupéry's original artwork. Combining Richard Howard's translation with restored" +
                         " original art, this definitive English-language edition of The Little Prince will capture " +
                         "the hearts of readers of all ages.",
                         Author = "Antoine de Saint-Exupéry",
                         Genre = "Adventure",
                         Publisher = "Mariner Books",
                         Quantity = 70,
                         Image = "https://books.google.com/books/content/images/frontcover/NhTyjt0V9tsC?fife=w300-rw",
                         IsFeatured = 1,
                         ReleaseDate = DateTime.Parse("04/06/1943"),
                         Rating = 0,
                         Sold = 0
                     },
                     new Book
                     {
                         ISBN = "978-0307949486",
                         Title = "The Girl with the Dragon Tattoo",
                         Price = 25.99,
                         Description = "Murder mystery, family saga, love story, and financial intrigue combine into " +
                         "one satisfyingly complex and entertainingly atmospheric novel, the first in Stieg Larsson's " +
                         "thrilling Millenium series featuring Lisbeth Salander. Look for The Girl Who Takes an Eye for " +
                         "an Eye featuring Lisbeth Salander, coming September 12th. Harriet Vanger, a scion of one of " +
                         "Sweden's wealthiest families disappeared over forty years ago. All these years later, her aged " +
                         "uncle continues to seek the truth. He hires Mikael Blomkvist, a crusading journalist recently " +
                         "trapped by a libel conviction, to investigate. He is aided by the pierced and tattooed punk " +
                         "prodigy Lisbeth Salander. Together they tap into a vein of unfathomable iniquity and astonishing corruption.",
                         Author = "Stieg Larsson",
                         Genre = "Suspense",
                         Publisher = "Vintage Crime / Black Lizard",
                         Quantity = 3,
                         Image = "http://t0.gstatic.com/images?q=tbn:ANd9GcT3C9lPaq1RPyrr12irhuZewsNZUX1aXxvU0Llyoc7n3zDqN1Rj",
                         IsFeatured = 1,
                         ReleaseDate = DateTime.Parse("08/01/2005"),
                         Rating = 0,
                         Sold = 0

                     },
                     new Book
                     {
                         ISBN = "978-0349409740",
                         Title = "A Scot in the Dark",
                         Price = 10.14,
                         Description = "Miss Lillian Hargrove has lived much of her life alone in a gilded cage, " +
                         "longing for love and companionship. When an artist offers her pretty promises and begs" +
                         " her to pose for a scandalous portrait, Lily doesn’t hesitate . . . until the lying libertine leaves her in disgrace. With the painting now public, Lily has no choice but to turn to the one man who might save her from ruin.",
                         Author = "Sarah MacLean",
                         Genre = "Romance",
                         Publisher = "PIATKUS BOOKS",
                         Quantity = 26,
                         Image = "https://images.gr-assets.com/books/1504741514l/27067875.jpg",
                         IsFeatured = 1,
                         ReleaseDate = DateTime.Parse("08/30/2016"),
                         Rating = 0,
                         Sold = 0
                     },
                     new Book
                     {
                         ISBN = "978-0439708180",
                         Title = "Harry Potter and the Sorcerer's Stone",
                         Price = 7.99,
                         Description = "Harry Potter has never been the star of a Quidditch team, scoring points while riding a broom far" +
                         " above the ground. He knows no spells, has never helped to hatch a dragon, and has never worn a cloak of invisibility. " +
                         "All he knows is a miserable life with the Dursleys, his horrible aunt and uncle, and their abominable son, " +
                         "Dudley — a great big swollen spoiled bully.Harry’s room is a tiny closet at the foot of the stairs, " +
                         "and he hasn’t had a birthday party in eleven years. But all that is about to change when a mysterious letter arrives " +
                         "by owl messenger: a letter with an invitation to an incredible place that Harry — and anyone who reads about him — will find unforgettable. " +
                         "For it’s there that he finds not only friends, aerial sports, and magic in everything from classes to meals, " +
                         "but a great destiny that’s been waiting for him… if Harry can survive the encounter.",
                         Author = "J. K. Rowling",
                         Genre = "Adventure",
                         Publisher = "Pottermore",
                         Quantity = 20,
                         Image = "http://t0.gstatic.com/images?q=tbn:ANd9GcTltzcooPkGcy1fKKqzSuO8U6S9XBpNDR9MuYc9SS_L5AbAn66O",
                         IsFeatured = 1,
                         ReleaseDate = DateTime.Parse("06/26/1997"),
                         Rating = 0,
                         Sold = 0
                     },
                     new Book
                     {
                         ISBN = "978-0547928197",
                         Title = "The Return of the King",
                         Price = 9.99,
                         Description = "The awesome conclusion to The Lord of the Rings—the greatest fantasy epic of all time—which " +
                         "began in The Fellowship of the Ring and The Two Towers. While the evil might of the Dark Lord Sauron swarms out" +
                         " to conquer all Middle-earth, Frodo and Sam struggle deep into Mordor, seat of Sauron’s power. To defeat the Dark Lord," +
                         " the One Ring, ruler of all the accursed Rings of Power, must be destroyed in the fires of Mount Doom. But the way is " +
                         "impossibly hard, and Frodo is weakening. Weighed down by the compulsion of the Ring, he begins finally to despair.",
                         Author = "J.R.R. Tolkien",
                         Genre = "Fantasy",
                         Publisher = "Mariner Books",
                         Quantity = 70,
                         Image = "http://www.gstatic.com/tv/thumb/movieposters/33156/p33156_p_v8_aa.jpg",
                         IsFeatured = 1,
                         ReleaseDate = DateTime.Parse("10/20/1955"),
                         Rating = 0,
                         Sold = 0
                     },
                     new Book
                     {
                         ISBN = "978-0547928203",
                         Title = "The Two Towers",
                         Price = 12.99,
                         Description = "The middle novel in The Lord of the Rings—the greatest fantasy epic of all time—which began in " +
                         "The Fellowship of the Ring, and which reaches its magnificent climax in The Return of the King. The Fellowship is " +
                         "scattered. Some are bracing hopelessly for war against the ancient evil of Sauron. Some are contending with the treachery" +
                         " of the wizard Saruman. Only Frodo and Sam are left to take the accursed One Ring, ruler of all the Rings of Power, to" +
                         " be destroyed in Mordor, the dark realm where Sauron is supreme. Their guide is Gollum, deceitful and lust-filled, slave" +
                         " to the corruption of the Ring.",
                         Author = "J.R.R. Tolkien",
                         Genre = "Fantasy",
                         Publisher = "Mariner Books",
                         Quantity = 15,
                         Image = "https://images-na.ssl-images-amazon.com/images/I/4123zOAwAgL._SY346_.jpg",
                         IsFeatured = 1,
                         ReleaseDate = DateTime.Parse("11/11/1954"),
                         Rating = 0,
                         Sold = 0
                     },
                     new Book
                     {
                         ISBN = "978-0547928210",
                         Title = "The Fellowship of the Ring",
                         Price = 9.99,
                         Description = "The opening novel of The Lord of the Rings—the greatest fantasy epic of all time—which continues in The " +
                         "Two Towers and The Return of the King. The dark, fearsome Ringwraiths are searching for a Hobbit. Frodo Baggins knows " +
                         "that they are seeking him and the Ring he bears—the Ring of Power that will enable evil Sauron to destroy all that is " +
                         "good in Middle-earth. Now it is up to Frodo and his faithful servant, Sam, with a small band of companions, to carry the " +
                         "Ring to the one place it can be destroyed: Mount Doom, in the very center of Sauron’s realm.",
                         Author = "J.R.R. Tolkien",
                         Genre = "Fantasy",
                         Publisher = "Mariner Books",
                         Quantity = 35,
                         Image = "https://prodimage.images-bn.com/pimages/9780547928210_p0_v2_s550x406.jpg",
                         IsFeatured = 1,
                         ReleaseDate = DateTime.Parse("07/29/1954"),
                         Rating = 0,
                         Sold = 0
                     },
                     new Book
                     {
                         ISBN = "978-0553593716",
                         Title = "A Game of Thrones (A Song of Ice and Fire, Book 1)",
                         Price = 49.99,
                         Description = "From a master of contemporary fantasy comes the first novel of a landmark series unlike any you’ve ever " +
                         "read before. With A Game of Thrones, George R. R. Martin has launched a genuine masterpiece, bringing together the best " +
                         "the genre has to offer. Mystery, intrigue, romance, and adventure fill the pages of this magnificent saga, the first " +
                         "volume in an epic series sure to delight fantasy fans everywhere.",
                         Author = "George R. Martin",
                         Genre = "Fantasy",
                         Publisher = "Bantam",
                         Quantity = 3,
                         Image = "https://images-na.ssl-images-amazon.com/images/I/51KzcuZMlzL._SY344_BO1,204,203,200_.jpg",
                         IsFeatured = 1,
                         ReleaseDate = DateTime.Parse("08/01/1996"),
                         Rating = 0,
                         Sold = 0
                     },
                     new Book
                     {
                         ISBN = "978-1455582877",
                         Title = "The Notebook",
                         Price = 20.50,
                         Description = "Every so often a love story so captures our hearts that it becomes more than a story-it becomes an " +
                         "experience to remember forever. The Notebook is such a book. It is a celebration of how passion can be ageless and " +
                         "timeless, a tale that moves us to laughter and tears and makes us believe in true love all over again... At thirty-one, " +
                         "Noah Calhoun, back in coastal North Carolina after World War II, is haunted by images of the girl he lost more than a " +
                         "decade earlier. At twenty-nine, socialite Allie Nelson is about to marry a wealthy lawyer, but she cannot stop thinking " +
                         "about the boy who long ago stole her heart. Thus begins the story of a love so enduring and deep it can turn tragedy " +
                         "into triumph, and may even have the power to create a miracle",
                         Author = "Nicholas Sparks",
                         Genre = "Romance",
                         Publisher = "Grand Central Publishing",
                         Quantity = 30,
                         Image = "http://www.gstatic.com/tv/thumb/movieposters/33410/p33410_p_v8_aa.jpg",
                         IsFeatured = 1,
                         ReleaseDate = DateTime.Parse("10/01/1996"),
                         Rating = 0,
                         Sold = 0
                     },
                     new Book
                     {
                         ISBN = "978-1508480563",
                         Title = "Heidi",
                         Price = 5.99,
                         Description = "The story of Heidi was written over one hundred years ago, however, it is far from a period piece. " +
                         "In the Swiss Alps, where it is set, a hundred years is just the blink of an eye. We see in her the daughter that every " +
                         "mother dreams of having and every little girl dreams of being. Her presence makes us happy, and so her story has " +
                         "endured. This deluxe Children’s Classic edition is produced with high-quality, leatherlike binding with gold stamping, " +
                         "full-color covers, colored endpapers with a book nameplate. Some of the other titles in this series include: Anne of " +
                         "Green Gables, Black Beauty, King Arthur and His Knights, Little Women, and The Secret Garden.",
                         Author = "Johanna Spyri",
                         Genre = "Adventure",
                         Publisher = "NorthSouth",
                         Quantity = 20,
                         Image = "https://images-na.ssl-images-amazon.com/images/I/51pTZX8xQ%2BL.jpg",
                         IsFeatured = 1,
                         ReleaseDate = DateTime.Parse("01/01/1981"),
                         Rating = 0,
                         Sold = 0
                     },
                     new Book
                     {
                         ISBN = "978-1537782034",
                         Title = "Witch Hunter: An Urban Fantasy Novel",
                         Price = 14.99,
                         Description = "Humans are going missing all over the city. Bloodthirsty shadow demons are attacking, and the Brotherhood " +
                         "want to return to the old ways to control the chaos. Digging deeper into these sinister new threats, Rosalind once again" +
                         " joins forces with Caine. But the sexy incubus has been keeping some major secrets from her—secrets that hold clues to" +
                         " her own history. And as Rosalind uncovers the truth about herself, she realizes she has to risk her sanity if she wants" +
                         " to save humanity.",
                         Author = "C. N. Crawford",
                         Genre = "Fantasy",
                         Publisher = "CreateSpace Independent Publishing Platform",
                         Quantity = 20,
                         Image = "https://images-na.ssl-images-amazon.com/images/I/51gdbBo8KNL._SX311_BO1,204,203,200_.jpg",
                         IsFeatured = 1,
                         ReleaseDate = DateTime.Parse("03/07/2017"),
                         Rating = 0,
                         Sold = 0
                     },
                     new Book
                     {
                         ISBN = "978-1449486792",
                         Title = "The Sun and Her Flowers",
                         Price = 10.19,
                         Description = "From Rupi Kaur, the #1 New York Times bestselling author of milk and honey, comes her long-awaited second collection" +
                         "of poetry.  A vibrant and transcendent journey about growth and healing. Ancestry and honoring one’s roots. Expatriation and rising up to find a " +
                         "home within yourself.",
                         Author = "Rupi Kaur",
                         Genre = "Poetry",
                         Publisher = "Andrews McMeel Publishing",
                         Quantity = 20,
                         Image = "https://images-na.ssl-images-amazon.com/images/I/416ZrnNLj6L._SX321_BO1,204,203,200_.jpg",
                         IsFeatured = 1,
                         ReleaseDate = DateTime.Parse("10/03/2017"),
                         Rating = 0,
                         Sold = 0
                     },
                     new Book
                     {
                         ISBN = "978-1449474256",
                         Title = "Milk and Honey",
                         Price = 8.99,
                         Description = "#1 New York Times bestseller Milk and Honey is a collection of poetry and prose about survival. " +
                         "About the experience of violence, abuse, love, loss, and femininity.The book is divided into four chapters, and each chapter serves a different purpose. Deals with a different pain. Heals a different heartache. Milk and Honey takes readers through a journey of the most bitter moments in life" +
                         " and finds sweetness in them because there is sweetness everywhere if you are just willing to look.",
                         Author = "Rupi Kaur",
                         Genre = "Poetry",
                         Publisher = "Andrews McMeel Publishing",
                         Quantity = 900,
                         Image = "https://images-na.ssl-images-amazon.com/images/I/41J43ERHtLL._SX321_BO1,204,203,200_.jpg",
                         IsFeatured = 1,
                         ReleaseDate = DateTime.Parse("10/06/2015"),
                         Rating = 0,
                         Sold = 0
                     },
                     new Book
                     {
                         ISBN = "978-1501139154",
                         Title = "Leonardo da Vinci",
                         Price = 20.99,
                         Description = "Based on thousands of pages from Leonardo’s astonishing notebooks and new discoveries about his life and work, Walter Isaacson weaves a narrative that connects his art to his science. He shows how Leonardo’s genius was based on skills we can improve in ourselves, such as passionate curiosity, careful observation, and an imagination so playful that it flirted with fantasy.",
                         Author = "Walter Isaacson",
                         Genre = "Biographies & Memoirs",
                         Publisher = "Simon & Schuster",
                         Quantity = 900,
                         Image = "https://images-na.ssl-images-amazon.com/images/I/51PHThzD-2L._SX330_BO1,204,203,200_.jpg",
                         IsFeatured = 1,
                         ReleaseDate = DateTime.Parse("10/17/2017"),
                         Rating = 0,
                         Sold = 100
                     },
                     new Book
                     {
                         ISBN = "978-1501111860",
                         Title = "Bobby Kennedy: A Raging Spirit",
                         Price = 18.89,
                         Description = "A revealing new portrait of Robert F. Kennedy that gets closer" +
                         " to the man than any book before, by bestselling author Chris Matthews, an esteemed Kennedy expert and anchor of MSNBC’s Hardball.",
                         Author = "Chris Matthews",
                         Genre = "Biographies & Memoirs",
                         Publisher = "Simon & Schuster",
                         Quantity = 900,
                         Image = "https://images-na.ssl-images-amazon.com/images/I/519X7iHNc1L._SX334_BO1,204,203,200_.jpg",
                         IsFeatured = 1,
                         ReleaseDate = DateTime.Parse("10/31/2017"),
                         Rating = 0,
                         Sold = 0
                     },
                     new Book
                     {
                         ISBN = "978-0375869020",
                         Title = "Wonder",
                         Price = 10.65,
                         Description = "August Pullman was born with a facial difference that, up until now, has prevented him from going to a mainstream school. Starting 5th grade at Beecher Prep, he wants nothing more than to be treated as an" +
                         " ordinary kid—but his new classmates can’t get past Auggie’s extraordinary face. WONDER, now a #1 New York Times bestseller and included on the Texas Bluebonnet Award master list, begins from Auggie’s point of view, but soon switches to include his classmates, his sister, her boyfriend, and others. These perspectives converge in a portrait of one community’s struggle with empathy, compassion, and acceptance. ",
                         Author = "Raquel J. Palacio",
                         Genre = "Adventure",
                         Publisher = "Knopf Books for Young Readers",
                         Quantity = 900,
                         Image = "https://images-na.ssl-images-amazon.com/images/I/41NzPGErMYL._SX328_BO1,204,203,200_.jpg",
                         IsFeatured = 1,
                         ReleaseDate = DateTime.Parse("02/14/2012"),
                         Rating = 0,
                         Sold = 0
                     },
                     new Book
                     {
                         ISBN = "978-1101934852",
                         Title = "Auggie & Me: Three Wonder Stories",
                         Price = 12.42,
                         Description = "These stories are an extra peek at Auggie before he started at Beecher Prep and during his first year there. Readers get to see him through the eyes of Julian, the bully; Christopher, Auggie’s oldest friend; and Charlotte, Auggie’s new friend at school. Together, these three stories are a treasure for readers who don’t want to leave Auggie behind when they finish Wonder.",
                         Author = "Raquel J. Palacio",
                         Genre = "Adventure",
                         Publisher = "Knopf Books for Young Readers",
                         Quantity = 900,
                         Image = "https://images-na.ssl-images-amazon.com/images/I/51u6t3Sc9EL._SX326_BO1,204,203,200_.jpg",
                         IsFeatured = 1,
                         ReleaseDate = DateTime.Parse("08/18/2015"),
                         Rating = 0,
                         Sold = 0
                     },
                     new Book
                     {
                         ISBN = "978-1524766498",
                         Title = "We're All Wonders",
                         Price = 14.24,
                         Description = "We’re All Wonders may be Auggie’s story, but it taps into every child’s longing to belong, and to be seen for who they truly are. It’s the perfect way for families and educators to talk about empathy and kindness with young children.",
                         Author = "Raquel J. Palacio",
                         Genre = "Adventure",
                         Publisher = "Knopf Books for Young Readers",
                         Quantity = 900,
                         Image = "https://images-na.ssl-images-amazon.com/images/I/51tZ6QVaNbL._SX377_BO1,204,203,200_.jpg",
                         IsFeatured = 1,
                         ReleaseDate = DateTime.Parse("03/28/2017"),
                         Rating = 0,
                         Sold = 98
                     },
                     new Book
                     {
                         ISBN = "978-0399559181",
                         Title = "365 Days of Wonder: Mr. Browne's Precepts",
                         Price = 8.48,
                         Description = "In Wonder, readers were introduced to memorable English teacher Mr. Browne and his love of precepts. This companion book features conversations between Mr. Browne and Auggie, Julian, Summer, Jack Will, and others, giving readers a special peek at their lives after Wonder ends. Mr. Browne's essays and correspondence are rounded out by a precept for each day of the year—drawn from popular songs to children’s books to inscriptions on Egyptian tombstones to fortune cookies. His selections celebrate the goodness of human beings, the strength of people’s hearts, and the power of people’s wills.",
                         Author = "Raquel J. Palacio",
                         Genre = "Adventure",
                         Publisher = "Knopf Books for Young Readers",
                         Quantity = 900,
                         Image = "https://images-na.ssl-images-amazon.com/images/I/51xBpuuS5RL._SX331_BO1,204,203,200_.jpg",
                         IsFeatured = 1,
                         ReleaseDate = DateTime.Parse("08/30/2016"),
                         Rating = 0,
                         Sold = 0
                     }
                     ,
                     new Book
                     {
                         ISBN = "978-1451644289",
                         Title = "Kennedy & Nixon: The Rivalry that Shaped Postwar America ",
                         Price = 13.86,
                         Description = "In this compelling, smart, and well-researched dual biography, " +
                         "Chris Matthews shows how the contest between the charismatic John F. Kennedy and " +
                         "the talented yet haunted Richard Nixon propelled America toward Vietnam and Watergate. John F. Kennedy and Richard Nixon each dreamed of becoming the great young leader of their age. First as friends, then as bitter enemies, they were linked by a historic rivalry that changed both them and their country. Fresh, entertaining, and revealing, Kennedy & Nixon reveals that the early fondness between the two men—Kennedy, for example, told a trusted friend that if he didn’t receive the Democratic nomination in 1960, he would vote for Nixon—degenerated into distrust and bitterness. Using White House tapes, this book exposes Richard Nixon’s dread of a Kennedy “restoration” in 1972 drove the dark deeds of Watergate.",
                         Author = "Chris Matthews",
                         Genre = "Biographies & Memoirs",
                         Publisher = "Free Press",
                         Quantity = 900,
                         Image = "https://images-na.ssl-images-amazon.com/images/I/5140KbFlOVL._SX327_BO1,204,203,200_.jpg",
                         IsFeatured = 1,
                         ReleaseDate = DateTime.Parse("11/01/2011"),
                         Rating = 0,
                         Sold = 0
                     }


                );
                context.Authors.AddRange(
                     new Author
                     {
                         Name = "Paulo Coelho",
                         DateofBirth = DateTime.Parse("08/24/1947"),
                         DateofDeath = null,
                         BirthCity = "Rio de Janeiro",
                         BirthCountry = "Brazil",
                         Bio = "The Brazilian author PAULO COELHO is considered one of the most influential authors of our times. " +
                         "His books have sold more than 165 million copies worldwide, have been released in 170 countries and been " +
                         "translated into 80 languages. Born in Rio de Janeiro in 1947, he soon discovered his vocation " +
                         "for writing.He worked as a director, theater actor, songwriter and journalist. His collaboration with Brazilian " +
                         "composer and singer Raúl Seixas gave some of the greatest classic rock songs in Brazil. He has received numerous " +
                         "prestigious international awards. He is member of the Academy of Letters of Brazil since 2002 and Messenger of Peace" +
                         " by the United Nations since 2007. In 2009 he received the Guinness World Record for the most translated author" +
                         " for the same book (The Alchemist).",
                         Image = "http://s3.amazonaws.com/dldwebsite-production/black_and_white_avatars/paulo-coelho/pulse/coelho-quadrat-web.jpg"
                     },
                     new Author
                     {
                         Name = "Raquel J. Palacio",
                         DateofBirth = DateTime.Parse("07/13/1963"),
                         DateofDeath = null,
                         BirthCity = "New York City",
                         BirthCountry = "United States",
                         Bio = "R. J. Palacio was born and raised in New York City. She attended the High School of Art and " +
                         "Design and the Parsons School of Design, where she majored in illustration with the hopes of someday" +
                         " following in the footsteps of her favorite childhood author-illustrators, Antoine de Saint-Exupéry," +
                         " Maurice Sendak, and the D’Aulaires. She was a graphic designer and art director for many years before" +
                         " writing Wonder. We’re All Wonders, which is based conceptually on the themes of her novel, represents" +
                         " the fulfillment of her dream to write and illustrate her own picture book. R.J. is also the author of " +
                         "Auggie & Me: Three Wonder Stories and 365 Days of Wonder: Mr. Browne’s Book of Precepts. She lives in" +
                         " Brooklyn, where she is surrounded by magical water towers, with her husband, their two sons, and their" +
                         " two dogs, Bear and Beau.",
                         Image = "http://rjpalacio.com/uploads/2/9/3/1/2931329/121753.jpg?269"
                     },

                     new Author
                     {
                         Name = "Stieg Larsson",
                         DateofBirth = DateTime.Parse("08/15/1954"),
                         DateofDeath = DateTime.Parse("09/11/2004"),
                         BirthCity = "Umeå",
                         BirthCountry = "Sweden",
                         Bio = "Karl Stig-Erland Stieg Larsson(15 August 1954 – 9 November 2004) was " +
                          "a Swedish journalist and writer.He is best known for writing the Millennium " +
                          "trilogy of crime novels, which were published posthumously and adapted as " +
                          "motion pictures.Larsson lived much of his life in Stockholm and worked there " +
                          "as a journalist and as an independent researcher of right - wing extremism.He " +
                          "was the second best - selling author in the world for 2008, behind Khaled " +
                          "Hosseini.The third novel in the Millennium trilogy, The Girl Who Kicked the " +
                          "Hornets' Nest, became the most sold book in the United States in 2010, " +
                          "according to Publishers Weekly. By March 2015, his series had sold 80 million " +
                          "copies worldwide.",
                         Image = "https://www.biography.com/.image/t_share/MTE4MDAzNDEwODE2MzcwMTkw/stieg-larsson-17181752-1-402.jpg"
                     },

                     new Author
                     {
                         Name = "Antoine de Saint-Exupéry",
                         DateofBirth = DateTime.Parse("07/29/1900"),
                         DateofDeath = DateTime.Parse("07/31/1944"),
                         BirthCity = "Lyon",
                         BirthCountry = "Frances",
                         Bio = "Antoine de Saint-Exupéry was born in Lyon, France, in 1900. Raised in an aristocratic family," +
                         "he took his first airplane ride at the age of 12 and immediately fell in love. He received his pilot’s " +
                         "wings during his compulsory military service in 1922, around which time he also began to write. " +
                         "His adventures as a pilot would supply the inspiration for all of his literary endeavors, which " +
                         "culminated with the 1943 publication of the classic The Little Prince. Saint-Exupéry disappeared in " +
                         "July 1944 while flying a reconnaissance mission over occupied France during World War II, leading to " +
                         "speculation over the cause of his death that persists to the present day.",
                         Image = "https://charterforcompassion.org/images/menus/Peace_non_violence/saint-exupery.jpg"
                     },
                     new Author
                     {
                         Name = "Sarah MacLean",
                         DateofBirth = DateTime.Parse("12/17/1978"),
                         DateofDeath = null,
                         BirthCity = "Linocln, RI",
                         BirthCountry = "United States",
                         Bio = "New York Times, Washington Post & USA Today bestseller Sarah MacLean " +
                            "is the author of historical romance novels that have been translated into " +
                            "more than twenty languages, and winner of back-to-back RITA Awards for " +
                            "best historical romance from the Romance Writers of America." +
                            "Sarah is a leading advocate for the romance genre, speaking widely on its " +
                            "place at the nexus of gender and cultural studies. She is the author of a " +
                            "monthly column celebrating the best of the genre for the Washington Post. " +
                            "Her work in support of romance and the women who read it earned her a place " +
                            "on Jezebel.com's Sheroes list of 2014 and led Entertainment Weekly to call " +
                            "her gracefully furious." +
                            "Sarah lives in New York City with her husband and daughter.",
                         Image = "https://static1.squarespace.com/static/52654ec3e4b099d3af71cbb4/t/58c1f8176a4963a1d42d2a20/1489107004533/maclean.jpg?format=500w"
                     },
                     new Author
                     {
                         Name = "J. K. Rowling",
                         DateofBirth = DateTime.Parse("07/31/1965"),
                         DateofDeath = null,
                         BirthCity = "Yate",
                         BirthCountry = "England",
                         Bio = "Born in Yate, England, on July 31, 1965, J.K. Rowling came from humble " +
                            "economic means before writing Harry Potter and the Sorcerer's Stone, a " +
                            "children's fantasy novel. The work was an international hit and Rowling " +
                            " wrote six more books in the series, which sold hundreds of millions of " +
                            "copies and was adapted into a blockbuster film franchise. In 2012, Rowling " +
                            "released the novel The Casual Vacancy.",
                         Image = "https://vignette.wikia.nocookie.net/harrypotter/images/3/3e/JKRowling.jpg/revision/latest/scale-to-width-down/336?cb=20151001174249"
                     },
                     new Author
                     {
                         Name = "J.R.R. Tolkien",
                         DateofBirth = DateTime.Parse("01/03/1892"),
                         DateofDeath = DateTime.Parse("09/09/1973"),
                         BirthCity = "Bloemfontein",
                         BirthCountry = "South Africa",
                         Bio = "Born on January 3, 1892, in Bloemfontein, South Africa, " +
                                "J.R.R. Tolkien settled in England as a child, going on to study at Exeter " +
                                "College. While teaching at Oxford University, he published the popular " +
                                "fantasy novels The Hobbit and the Lord of the Rings trilogy. The works have " +
                                "had a devoted international fan base and been adapted into award-winning " +
                                "blockbuster films. Tolkien died in 1973 at 81.",
                         Image = "https://www.tolkiensociety.org/wp-content/uploads/2016/11/pamela_chandler_tolkien1-290x366.jpg"
                     },
                     new Author
                     {
                         Name = "George R. Martin",
                         DateofBirth = DateTime.Parse("07/13/1963"),
                         DateofDeath = null,
                         BirthCity = "Bayonne, NJ",
                         BirthCountry = "United States",
                         Bio = "George Raymond Richard Martin (born George Raymond Martin; " +
                            "September 20, 1948), often referred to as George R. R. Martin, is an " +
                            "American novelist and short-story writer in the fantasy, horror, and " +
                            "science fiction genres, screenwriter, and television producer. He is best " +
                            "known for his series of epic fantasy novels, A Song of Ice and Fire, which " +
                            "was later adapted into the HBO series Game of Thrones (2011–present). " +
                            "Martin serves as the series's co-executive producer, and also scripted four " +
                            "episodes of the series." +
                            "In 2005, Lev Grossman of Time called Martin the American Tolkien, and in " +
                            "2011, he was included on the annual Time 100 list of the most influential " +
                            "people in the world.",
                         Image = "https://photos.vanityfair.com/2015/01/21/54c03653eac9a2571a187323_george-rr-martin.jpg"
                     },
                     new Author
                     {
                         Name = "Nicholas Sparks",
                         DateofBirth = DateTime.Parse("12/31/1965"),
                         DateofDeath = null,
                         BirthCity = "Omaha, NE",
                         BirthCountry = "United States",
                         Bio = "Nicholas Charles Sparks (born December 31, 1965) is an American " +
                            "romance novelist, screenwriter and producer. He has published eighteen " +
                            "novels and two non-fiction books. Several of his novels have become " +
                            "international bestsellers, and eleven of his romantic-drama novels have " +
                            "been adapted to film all with multimillion-dollar box office grosses." +
                            "Sparks was born in Omaha, Nebraska and wrote his first novel, The Passing, " +
                            "in 1985, while a student at the University of Notre Dame. His first " +
                            "published work came in 1990, when he co-wrote with Billy Mills Wokini: " +
                            "A Lakota Journey to Happiness and Self-Understanding, which sold " +
                            "approximated 50,000 copies in its first year. In 1993, Sparks wrote his " +
                            "breakthrough novel The Notebook in his spare time while selling " +
                            "pharmaceuticals in Washington, D.C.. Two years later, his novel was " +
                            "discovered by literary agent Theresa Park who offered to represent him. " +
                            "The novel was published in October 1996 and made the New York Times " +
                            "best-seller list in its first week of release.",
                         Image = "http://cdn.collider.com/wp-content/image-base/People/N/Nicholas_Sparks/Nicholas%20Sparks%20%20(1).jpg"
                     },
                     new Author
                     {
                         Name = "Johanna Spyri",
                         DateofBirth = DateTime.Parse("06/12/1827"),
                         DateofDeath = DateTime.Parse("07/07/1901"),
                         BirthCity = "Hirzel",
                         BirthCountry = "Switzerland",
                         Bio = "She was born Johanna Heusser in Hirzel, Switzerland. Her father was a doctor and her mother was a poet. " +
                                "She lived with her extended family: her grandmother, two aunties, and two " +
                                "cousins as well as her mother, father, two brothers and three sisters. " +
                                "This large household inspired her when she wrote Gritli's Children. " +
                                "She spent several summers around Chur in Graubünden when she was young. " +
                                "This setting was later used in her novels." +
                                "Her only education was her village school in Hirzel. She wrote poetry as a child." +
                                "She married Bernhard Spyri, an employee , when she was 25. They met when " +
                                "they were children. They lived in Zurich, Switzerland and had only one " +
                                "child, a son, Berhard Diethelm Spyri, in 1855. In Zurich, they were " +
                                "friends with the musician Richard Wagner and poet Conrad Ferdinand Meyer. " +
                                "Both her husband and son died of tuberculosis in 1884.",
                         Image = "https://upload.wikimedia.org/wikipedia/commons/f/f3/Zentralbibliothek_Z%C3%BCrich_-_Johanna_Spyri_-_000006279_2.jpg"
                     },
                     new Author
                     {
                         Name = "C. N. Crawford",
                         DateofBirth = null,
                         DateofDeath = null,
                         BirthCity = "Lexington, MA",
                         BirthCountry = "United States",
                         Bio = "C. N. Crawford is not one person but two. We write our novels " +
                            "collaboratively, passing our laptops back and forth to edit each other's " +
                            "words. Christine (C) has a lifelong interest in New England folklore - " +
                            "with a particular fondness for creepy old cemeteries. Nick (N) spent his " +
                            "childhood reading fantasy and science fiction which may partly explain " +
                            "why he is also a scientist.",
                         Image = "https://images-na.ssl-images-amazon.com/images/I/41BsomkIgPL._UX250_.jpg"
                     },
                     new Author
                     {
                         Name = "Rupi Kaur",
                         DateofBirth = DateTime.Parse("10/05/1992"),
                         DateofDeath = null,
                         BirthCity = "Punjab",
                         BirthCountry = "India",
                         Bio = "Rupi Kaur is a #1 ‘New York Times' bestselling author and illustrator " +
                            "of two collections of poetry. She started drawing at the age of five when " +
                            "her mother handed her a paintbrush and said—draw your heart out. Rupi " +
                            "views her life as an exploration of that artistic journey. After " +
                            "completing her degree in rhetoric studies, she published her first " +
                            "collection of poems ‘milk and honey’ in 2014. The internationally " +
                            "acclaimed collection sold well over a million copies gracing the New York " +
                            "Times bestseller list every week for over a year. It has since been " +
                            "translated into over thirty languages. Her long-awaited second collection " +
                            "‘the sun and her flowers’ was published in 2017. Through this collection " +
                            "she continues to explore a variety of themes ranging from love. Loss. " +
                            "Trauma. Healing. Femininity. Migration. And revolution. Rupi has performed " +
                            "her poetry across the world. Her photography and art direction are warmly " +
                            "embraced and she hopes to continue this expression for years to come.",
                         Image = "https://rupikaur.com/wp-content/uploads/2017/07/Rupi-Kaur-about.jpg"
                     },
                     new Author
                     {
                         Name = "Walter Isaacson",
                         DateofBirth = DateTime.Parse("05/20/1952"),
                         DateofDeath = null,
                         BirthCity = "New Orleans, LA",
                         BirthCountry = "United States",
                         Bio = "Walter Isaacson, University Professor of History at Tulane, has been " +
                            "CEO of the Aspen Institute, chairman of CNN, and editor of Time magazine. " +
                            "He is the author of Leonardo da Vinci; The Innovators; Steve Jobs; " +
                            "Einstein: His Life and Universe; Benjamin Franklin: An American Life; " +
                            "and Kissinger: A Biography, and the coauthor of The Wise Men: Six Friends " +
                            "and the World They Made.",
                         Image = "https://prodimage.images-bn.com/cimages/0000000311778_p0_v2_s280x180.jpg"
                     },
                     new Author
                     {
                         Name = "Chris Matthews",
                         DateofBirth = DateTime.Parse("12/17/1945"),
                         DateofDeath = null,
                         BirthCity = "Philadelphia, PA",
                         BirthCountry = "United States",
                         Bio = "A revealing new portrait of Robert F. Kennedy that gets closer to " +
                            "the man than any book before, by bestselling author Chris Matthews, an " +
                            "esteemed Kennedy expert and anchor of MSNBC’s Hardball." +
                            "With his bestselling biography Jack Kennedy, Chris Matthews shared a new " +
                            "look of one of America’s most beloved Presidents and the patriotic spirit " +
                            "that defined him. Now, with Bobby Kennedy, Matthews returns with a " +
                            "gripping, in-depth, behind-the-scenes portrait of one of the great " +
                            "figures of the American twentieth century." +
                            "Overlooked by his father, and overshadowed by his war-hero brother, Bobby " +
                            "Kennedy was the perpetual underdog. When he had the chance to become a " +
                            "naval officer like Jack, Bobby turned it down, choosing instead to join " +
                            "the Navy as a common sailor. It was a life changing experience that led " +
                            "him to connect with voters from all walks of life: young or old, black or " +
                            "white, rich or poor. They were the people who turned out for him in his " +
                            "1968 campaign. RFK would prove himself to be the rarest of politicians—both " +
                            "a pragmatist who knew how to get the job done and an unwavering idealist " +
                            "who could inspire millions.",
                         Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b3/Chris_Matthews_2011_Shankbone.JPG/800px-Chris_Matthews_2011_Shankbone.JPG"
                     }
               );
                context.SaveChanges();

                foreach (Book b in context.Books)
                {
                    var ratings = context.Comments.Where(d => d.BookISBN.Equals(b.ISBN)).ToList();
                    int ratingSum;
                    int ratingCount;
                    ratingSum = ratings.Sum(d => d.Rating.Value);
                    ratingCount = ratings.Count();

                    var book = context.Books.Where(x => x.ISBN.Equals(b.ISBN)).FirstOrDefault<Book>();
                    if(ratingCount!=0)
                        book.Rating = ratingSum / ratingCount;
                    else
                    {
                        book.Rating = 0;
                    }

                    context.Entry(book).State = EntityState.Modified;
                    
                }
                context.SaveChanges();
            }
        }
    }
}
