using System.ComponentModel.DataAnnotations;

public class SearchTerm
{
    [Required]

    public string? SearchIngredient { get; set; }
}