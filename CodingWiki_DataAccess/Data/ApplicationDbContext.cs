using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;

namespace CodingWiki_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-UQA779G;Database=CodingWiki;TrustServerCertificate=True;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(u => u.Price).HasPrecision(10, 5);

            modelBuilder.Entity<BookAuthorMap>().HasKey(u => new { u.Author_Id, u.IDBook });

            var bookList = new Book[]
            {
                new Book { IDBook = 3, Title = "Fake Sunday 999", ISBN = "77652", Price = 20.99m, Publisher_Id = 3 },
                new Book { IDBook = 4, Title = "Cookie Jar1 999", ISBN = "CC12B12", Price = 25.99m , Publisher_Id = 2},
                new Book { IDBook = 5, Title = "Cloudy Forest 999", ISBN = "90392B33", Price = 40.99m , Publisher_Id = 1}
            };
            modelBuilder.Entity<Book>().HasData(bookList);

            modelBuilder.Entity<Publisher>().HasData(
                new Publisher { Publisher_Id = 1, Name = "Pub 1 Jimmy", Location = "Chicago" },
                new Publisher { Publisher_Id = 2, Name = "Pub 2 John", Location = "New York" },
                new Publisher { Publisher_Id = 3, Name = "Pub 3 Ben", Location = "Hawaii" }
            );
        }
    }
}
