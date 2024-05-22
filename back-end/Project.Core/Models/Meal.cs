using System.ComponentModel.DataAnnotations;

namespace Project.Core.Models
{
    public class Meal
    {
        [Key]
        public int Id { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
