using Microsoft.EntityFrameworkCore;
using Pr07webapi.Models;

namespace Pr07webapi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "Transformers",
                    Author = "Michael Bay",
                    Year = 2007
                },
                new Book
                {
                    Id = 2,
                    Title = "The Great Gatsby",
                    Author = "F. Scott Fitzgerald",
                    Year = 1925
                },
                new Book
                {
                    Id = 3,
                    Title = "To Kill a Mockingbird",
                    Author = "Harper Lee",
                    Year = 1960
                },
                new Book
                {
                    Id = 4,
                    Title = "1984",
                    Author = "George Orwell",
                    Year = 1949
                },
                new Book
                {
                    Id = 5,
                    Title = "Harry Potter and the Sorcerer's Stone",
                    Author = "J.K. Rowling",
                    Year = 1997
                },
                new Book
                {
                    Id = 6,
                    Title = "The Hobbit",
                    Author = "J.R.R. Tolkien",
                    Year = 1937
                },
                new Book
                {
                    Id = 7,
                    Title = "Pride and Prejudice",
                    Author = "Jane Austen",
                    Year = 1813
                },
                new Book
                {
                    Id = 8,
                    Title = "The Catcher in the Rye",
                    Author = "J.D. Salinger",
                    Year = 1951
                },
                new Book
                {
                    Id = 9,
                    Title = "The Lord of the Rings",
                    Author = "J.R.R. Tolkien",
                    Year = 1954
                },
                new Book
                {
                    Id = 10,
                    Title = "Animal Farm",
                    Author = "George Orwell",
                    Year = 1945
                });
            base.OnModelCreating(modelBuilder);
        }
    }
}
