using Microsoft.EntityFrameworkCore;

namespace Booklist_Razor_Pages.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
