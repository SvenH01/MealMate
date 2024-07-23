using Microsoft.EntityFrameworkCore;
using Project.Core.Entities.General;

namespace Project.Infrastructure.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Meal> Meals { get; set; }
    }
}
