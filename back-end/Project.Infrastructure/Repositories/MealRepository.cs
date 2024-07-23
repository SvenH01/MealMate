using Project.Core.Entities.General;
using Project.Core.Interfaces.IRepositories;
using Project.Infrastructure.Data;

namespace Project.Infrastructure.Repositories;

public class MealRepository: IMealRepository
{
    protected readonly ApplicationDbContext _dbContext;
    
    MealRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Meal> Create(Meal meal)
    {
        await _dbContext.Set<Meal>().AddAsync(meal);
        return meal;
    }
}