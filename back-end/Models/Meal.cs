using back_end.Models;
using System;
using System.ComponentModel.DataAnnotations;


public class Meal
{
    [Key]
    public int Id { get; set; }
	public ICollection<Ingredient> Ingredients { get; set; }		
}
