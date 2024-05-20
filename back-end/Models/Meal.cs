using back_end.Models;
using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Meal
{
	public ICollection<Ingredient> Ingredients { get; set; }		
}
