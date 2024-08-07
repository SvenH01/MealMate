using Project.Core.Entities.General;
using Project.Core.Interfaces.IRepositories;
using Project.Infrastructure.Data;

namespace Project.Infrastructure.Repositories
{
    public class MealRepository : IMealRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public MealRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Meal> Create(Meal meal)
        {
            await _dbContext.Set<Meal>().AddAsync(meal);
            await _dbContext.SaveChangesAsync();
            return meal;
        }
    }
}