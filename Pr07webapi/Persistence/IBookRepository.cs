using Pr07webapi.Models;

namespace Pr07webapi.Persistence
{
    public interface IBookRepository
    {
        Task AddBook(Book book);
        Task EditBook(int id, Book book);
        Task DeleteBook(int id);
        Task<List<Book>> GetAllBooks();
        Task<Book> GetBookById(int id);
    }
}
