using Project.Core.Entities.Business;
using Project.Core.Entities.General;
using Project.Core.Interfaces.IRepositories;
using Project.Core.Interfaces.IServices;

namespace Project.Core.Services;

public class MealService: IMealService
{
    
    private readonly IMealRepository _mealRepository;

    MealService(IMealRepository mealRepository)
    {
        _mealRepository = mealRepository;
    }
    
    public async Task<MealViewModel> Create(MealCreateViewModel model)
    {
        var meal = new Meal()
        {
            Name = model.Name,
            // Ingredients = Array<Ing>.Empty,
        };

        var mealResponse = await _mealRepository.Create(meal);
        return new MealViewModel()
        {
            Name = mealResponse.Name,
            Id = mealResponse.Id
        };
    }
}