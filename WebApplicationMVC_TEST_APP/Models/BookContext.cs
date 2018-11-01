using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplicationMVC_TEST_APP.Models
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<Purchase> Purchases { get; set; }
    }

    public class BoolDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "War and Peace", Author = "Leo Tolstoy", Price = 100 });
            db.Books.Add(new Book { Name = "Tikhiy Don", Author = "Mikhail Sholokhov", Price = 1337 });
            db.Books.Add(new Book { Name = "Fathers and Sons", Author = "Ivan Turgenev", Price = 228 });

            base.Seed(db);
        }
    }
}