using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EasyRecipesWebApi.Domain.Models
{
    public class MeasurementUnit
    {
        public int Id { get; set; }
        [Required] public string Unit { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }
    }
}

