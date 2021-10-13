using Microsoft.EntityFrameworkCore;

namespace personaWeb.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options): base(options)
        {

        }
        public DbSet<personaWeb.Models.Person> Person { get; set; }
    }
}
