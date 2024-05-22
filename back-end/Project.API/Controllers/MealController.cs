using back_end.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Core.Models;

namespace back_end.Controllers
{
    [Route("api/meals")]
    [ApiController]
    public class MealController(ApplicationDbContext db) : ControllerBase
    {
        [HttpGet("all")]
        public async Task<ActionResult<List<Meal>>> GetAllMeals()
        {
            var mealsResult = await db.Meals.ToArrayAsync();

            return Ok(mealsResult);
        }
    }
}
