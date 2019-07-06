using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyRecipesWebApi.Domain.Models;
using EasyRecipesWebApi.Domain.Repositories;
using EasyRecipesWebApi.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EasyRecipesWebApi.Persistence.Repositories
{
    public class IngredientsRepository : BaseRepository, IIngredientRepository
    {
        public IngredientsRepository(EasyRecipesContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Ingredient>> GetAllIngredientsAsync()
        {
            return await _context.Ingredients.ToListAsync();
        }
    }
}