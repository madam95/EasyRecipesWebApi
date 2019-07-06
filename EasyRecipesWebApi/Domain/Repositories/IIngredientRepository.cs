using System.Collections.Generic;
using System.Threading.Tasks;
using EasyRecipesWebApi.Domain.Models;

namespace EasyRecipesWebApi.Domain.Repositories
{
    public interface IIngredientRepository
    {
        Task<IEnumerable<Ingredient>> GetAllIngredientsAsync();
    }
}