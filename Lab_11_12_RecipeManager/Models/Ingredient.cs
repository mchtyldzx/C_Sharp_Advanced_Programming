using System.ComponentModel.DataAnnotations;

public class Ingredient
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public string Quantity { get; set; } = string.Empty;

    public int RecipeId { get; set; }
    public Recipe? Recipe { get; set; }
}
