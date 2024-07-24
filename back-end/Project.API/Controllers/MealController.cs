using Project.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Core.Entities.Business;
using Project.Core.Entities.General;
using Project.Core.Interfaces.IServices;
using Project.Core.Services;

namespace Project.API.Controllers
{
    [Route("api/meals")]
    [ApiController]
    public class MealController: ControllerBase
    {
        private readonly IMealService _mealService;

        public MealController(IMealService mealService)
        {
            _mealService = mealService;
        }
        
        [HttpGet("all")]
        public async Task<ActionResult<List<Meal>>> GetAllMeals()
        {
            // var mealsResult = await db.Meals.ToArrayAsync();
            //
            // return Ok(mealsResult);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateMeal(MealCreateViewModel meal)
        {
            if (ModelState.IsValid)
            {
                await _mealService.Create(meal);
                return Ok(await _mealService.Create(meal));
            }

            
            return Ok();
        }
    }
}
