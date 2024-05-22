using System.ComponentModel.DataAnnotations;

namespace Project.Core.Models
{
    public class Ingredient
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public decimal Calories { get; set; }
    }
}

