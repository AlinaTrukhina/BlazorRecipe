using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorRecipe.Models
{
public class SpoonacularRecipe
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public List<string>? Ingredients { get; set; }

    public List<string>? Instructions { get; set; }
    
    public List<string>? Steps { get; set; }

    public string? Description { get; set; }
}

}