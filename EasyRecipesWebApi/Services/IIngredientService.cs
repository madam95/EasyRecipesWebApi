using System.Collections.Generic;
using System.Threading.Tasks;
using EasyRecipesWebApi.Models;

namespace EasyRecipesWebApi.Services
{
    public interface IIngredientService
    {
        Task<IEnumerable<Ingredient>> GetAllIngredientsAsync();
    }
}