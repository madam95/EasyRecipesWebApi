using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EasyRecipesWebApi.Models
{
    public class EasyRecipesContext : DbContext
    {
        public EasyRecipesContext(DbContextOptions<EasyRecipesContext> options) : base(options)
        {
            
        }

        public DbSet<Ingredient> Ingredients { get; set; }
        
    }
}
