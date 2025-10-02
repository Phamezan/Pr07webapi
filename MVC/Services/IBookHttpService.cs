using MVC.Models;

namespace MVC.Services
{
    public interface IBookHttpService
    {
        Task<List<Book>> GetAllBooksAsync();
        Task<Book> GetBookByIdAsync(int id);
    }
}
