using EasyRecipesWebApi.Persistence.Contexts;

namespace EasyRecipesWebApi.Persistence.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly EasyRecipesContext _context;

        public BaseRepository(EasyRecipesContext context)
        {
            _context = context;
        }
    }
}