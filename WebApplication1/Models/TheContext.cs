using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class TheContext : DbContext
    {
        public TheContext(DbContextOptions<TheContext> options)
            : base(options)
        {
        }

        public DbSet<Item> TodoItems { get; set; }
    }
}