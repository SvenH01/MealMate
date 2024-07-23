using Project.Core.Entities.Business;
using Project.Core.Entities.General;

namespace Project.Core.Interfaces.IServices
{
    public interface IMealService : IBaseService<MealViewModel>
    {
        Task<MealViewModel> Create(MealCreateViewModel model);
        // Task Update(MealViewModel model, CancellationToken cancellationToken);
        // Task Delete(int id, CancellationToken cancellationToken);
    }
}