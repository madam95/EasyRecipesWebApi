using System.Collections.Generic;
using System.Threading.Tasks;
using EasyRecipesWebApi.Models;

namespace EasyRecipesWebApi.Repositories
{
    public interface IIngredientRepository
    {
        Task<IEnumerable<Ingredient>> GetAllIngredientsAsync();
    }
}