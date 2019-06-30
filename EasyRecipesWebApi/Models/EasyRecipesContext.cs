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
            modelBuilder
                .Entity<Ingredient>()
                .Property(e => e.Unit)
                .HasConversion(
                    v => v.ToString(),
                    v => (MeasurementUnit) Enum.Parse(typeof(MeasurementUnit), v));
        }

        public DbSet<Ingredient> Ingredients { get; set; }
        
    }
}
