using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EasyRecipesWebApi.Models
{
    public class EasyRecipesContext : DbContext
    {
        public EasyRecipesContext(DbContextOptions<EasyRecipesContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<Ingredient> Ingredients { get; set; }
        
    }
}
