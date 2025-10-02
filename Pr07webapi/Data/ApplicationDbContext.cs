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


    }
}
