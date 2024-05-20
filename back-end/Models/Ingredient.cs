namespace back_end.Models
{
    public class Ingredient
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public decimal Calories { get; set; }
    }
}
