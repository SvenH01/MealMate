using System.ComponentModel.DataAnnotations;
using Project.Core.Entities.General;

namespace Project.Core.Entities.Business
{
    public class MealViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // public ICollection<IngredientViewModel> Ingredients { get; set; }
    }
    
    public class MealCreateViewModel
    {
        [Required, StringLength(maximumLength: 100, MinimumLength = 2)]
        public string Name { get; set; }
    }
}