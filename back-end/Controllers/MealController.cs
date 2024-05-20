using back_end.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace back_end.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Meal>>> GetAllMeals()
        {
            var ingredientList = new List<Ingredient>
            {
                new Ingredient {
                    Id = 1,
                    Name = "Test",
                    Calories = 5
                }
            };

            var mealsResult = new List<Meal>
            {
                new Meal
                {
                    Ingredients = ingredientList
                }
            };

            return Ok(mealsResult);
        }
    }
}
