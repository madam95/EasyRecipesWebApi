using System.Collections.Generic;
using System.Threading.Tasks;
using EasyRecipesWebApi.Domain.Models;

namespace EasyRecipesWebApi.Domain.Services
{
    public interface IIngredientService
    {
        Task<IEnumerable<Ingredient>> GetAllIngredientsAsync();
    }
}