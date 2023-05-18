using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorRecipe.Models;

namespace BlazorRecipe.Services
{
    public class RecipeService
    {
        private List<SpoonacularRecipe> _recipes = new List<SpoonacularRecipe>();

        public void AddRecipe(SpoonacularRecipe recipe)
        {
            _recipes.Add(recipe);
        }

        public List<SpoonacularRecipe> GetRecipes()
        {
            return _recipes;
        }

    }
}