
using MVC.Models;

namespace MVC.Services
{
    public class BookHttpService : IBookHttpService
    {
        private readonly IHttpClientFactory httpClientFactory;

        public BookHttpService(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }
        public async Task<List<Book>> GetAllBooksAsync()
        {
            using var client = httpClientFactory.CreateClient("bookapi");
            var response = await client.GetAsync($"/api/books");
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            return await response.Content.ReadFromJsonAsync<List<Book>>();
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            using var client = httpClientFactory.CreateClient("bookapi");
            var response = await client.GetAsync($"/api/books/{id}");
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            return await response.Content.ReadFromJsonAsync<Book>();
        }
    }
}
