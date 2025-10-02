using Microsoft.AspNetCore.Mvc;
using Pr07webapi.DTO;
using Pr07webapi.Models;
using Pr07webapi.Persistence;

namespace Pr07webapi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository repo;
        public BooksController(IBookRepository bookRepository)
        {
            repo = bookRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            return Ok(await repo.GetAllBooks());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookById(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            var bookToFind = await repo.GetBookById(id);
            if (bookToFind == null)
            {
                return NotFound();
            }
            return Ok(bookToFind);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBook(BookDTO bookDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var book = new Book
            {
                Title = bookDTO.Title,
                Author = bookDTO.Author,
                Year = bookDTO.Year
            };
            await repo.AddBook(book);
            return Created(string.Empty, book);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook(int id, Book book)
        {
            var bookToUpdate = await repo.GetBookById(id);
            if (bookToUpdate == null)
            {
                return NotFound();
            }
            bookToUpdate.Title = book.Title;
            bookToUpdate.Author = book.Author;
            bookToUpdate.Year = book.Year;
            await repo.EditBook(id, bookToUpdate);
            return Ok(bookToUpdate);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var bookToDelete = await repo.GetBookById(id);
            if (bookToDelete == null)
            {
                return NotFound();
            }
            await repo.DeleteBook(id);
            return Ok(bookToDelete);
        }
    }
}
