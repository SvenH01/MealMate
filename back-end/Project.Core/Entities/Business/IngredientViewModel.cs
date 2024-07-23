namespace Project.Core.Entities.Business;

public class IngredientViewModel
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Calories { get; set; }
}