using Microsoft.EntityFrameworkCore;
using Pr07webapi.Data;
using Pr07webapi.Models;

namespace Pr07webapi.Persistence
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;

        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddBook(Book book)
        {
            if (book != null)
            {
                await _context.AddAsync(book);
                _context.SaveChanges();
            }
        }

        public async Task DeleteBook(int id)
        {
            var bookToDelete = await _context.Books.FindAsync(id);
            if (bookToDelete != null)
            {
                _context.Books.Remove(bookToDelete);
                _context.SaveChanges();
            }
        }

        public async Task EditBook(int id, Book book)
        {
            var bookToEdit = await _context.Books.FindAsync(id);
            if (bookToEdit != null)
            {
                bookToEdit = book;
                _context.SaveChanges();
            }
        }

        public async Task<List<Book>> GetAllBooks()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<Book> GetBookById(int id)
        {
            return await _context.Books.FindAsync(id);

        }
    }
}
