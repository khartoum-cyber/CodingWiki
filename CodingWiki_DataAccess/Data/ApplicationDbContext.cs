﻿using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;

namespace CodingWiki_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-UQA779G;Database=CodingWiki;TrustServerCertificate=True;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(u => u.Price).HasPrecision(10, 5);

            modelBuilder.Entity<Book>().HasData(
                new Book { IDBook = 1, Title = "Spider without Duty", ISBN = "123B12", Price = 10.99m },
                new Book { IDBook = 2, Title = "Fortune of time", ISBN = "12123B12", Price = 11.99m }
            );

            var bookList = new Book[]
            {
                new Book { IDBook = 3, Title = "Fake Sunday", ISBN = "77652", Price = 20.99m },
                new Book { IDBook = 4, Title = "Cookie Jar", ISBN = "CC12B12", Price = 25.99m },
                new Book { IDBook = 5, Title = "Cloudy Forest", ISBN = "90392B33", Price = 40.99m }
            };
            modelBuilder.Entity<Book>().HasData(bookList);
        }
    }
}
