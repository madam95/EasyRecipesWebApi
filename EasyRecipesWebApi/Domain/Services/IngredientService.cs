using System.Collections.Generic;
using System.Threading.Tasks;
using EasyRecipesWebApi.Domain.Models;
using EasyRecipesWebApi.Domain.Repositories;

namespace EasyRecipesWebApi.Domain.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly IIngredientRepository _ingredientRepository;

        public IngredientService(IIngredientRepository ingredientRepository)
        {
            _ingredientRepository = ingredientRepository;
        }

        public async Task<IEnumerable<Ingredient>> GetAllIngredientsAsync()
        {
            return await _ingredientRepository.GetAllIngredientsAsync();
        }
    }
}