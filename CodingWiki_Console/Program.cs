// See https://aka.ms/new-console-template for more information
using CodingWiki_DataAccess.Data;
using CodingWiki_Model.Models;

Console.WriteLine("Hello, World!");

AddBook();
GetAllBooks();
void GetAllBooks()
{
    using var context = new ApplicationDbContext();
    var books = context.Books.ToList();
    foreach (var book in books)
    {
        Console.WriteLine(book.Title + " - " + book.ISBN);
    }
}

async void AddBook()
{
    Book book = new() { Title = "New EF Core Book", ISBN = "9999", Price = 10.93m, Publisher_Id = 1 };
    await using var context = new ApplicationDbContext();
    var books = await context.Books.AddAsync(book);
    await context.SaveChangesAsync();
}