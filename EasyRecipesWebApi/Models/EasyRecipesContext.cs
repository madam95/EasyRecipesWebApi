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
            modelBuilder.Entity<MeasurementUnit>().HasData(
                new {Id = 1, Unit = "Gram"},
                new {Id = 2, Unit = "Millilitre"},
                new {Id = 3, Unit = "Piece"},
                new {Id = 4, Unit = "Spoon"},
                new {Id = 5, Unit = "Tablespoon"},
                new {Id = 6, Unit = "Pinch"},
                new {Id = 7, Unit = "Glass"},
                new {Id = 8, Unit = "None"});
        }

        public DbSet<Ingredient> Ingredients { get; set; }
    }
}
