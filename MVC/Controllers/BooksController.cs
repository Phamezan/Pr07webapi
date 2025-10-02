using Microsoft.AspNetCore.Mvc;
using MVC.Services;

namespace MVC.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookHttpService service;

        public BooksController(IBookHttpService service)
        {
            this.service = service;
        }
        public async Task<IActionResult> Index()
        {
            var books = await service.GetAllBooksAsync();
            return View(books);
        }
        public async Task<IActionResult> Book(int id)
        {
            var book = await service.GetBookByIdAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }
    }
}
