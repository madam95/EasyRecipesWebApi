using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EasyRecipesWebApi.Models
{
    public class MeasurementUnit
    {
        public int Id { get; set; }
        [Required] public string Unit { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }
    }
}

