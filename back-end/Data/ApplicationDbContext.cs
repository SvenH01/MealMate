using Microsoft.EntityFrameworkCore;

namespace back_end.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options) { }

        public DbSet<Meal> Meals { get; set; }
    }
}
