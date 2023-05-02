using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorRecipe.Data
{
    public class RecipeProcessor
    {
        public async Task LoadRecipe(string ingredient = "apples")
        {
            string url = "";

            if (ingredient != "")
            {
                url = $"https://api.spoonacular.com/recipes/complexSearch?apiKey=a151019d6e5041dbbee481ab3778e65&ingredients={ingredient}";
            }
            else 
            {
                url = $"https://api.spoonacular.com/recipes/complexSearch?apiKey=a151019d6e5041dbbee481ab3778e65&ingredients=apples";
            }

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {

                }
                else 
                {
                    
                }
            }
        }
    }
}