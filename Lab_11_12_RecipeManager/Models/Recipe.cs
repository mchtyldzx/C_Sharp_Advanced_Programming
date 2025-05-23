using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Recipe
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public DateTime CreatedDate { get; set; }

    public int CategoryId { get; set; }
    public Category? Category { get; set; }

    public ICollection<Ingredient>? Ingredients { get; set; }

    public bool IsFavorite { get; set; } = false;
}
